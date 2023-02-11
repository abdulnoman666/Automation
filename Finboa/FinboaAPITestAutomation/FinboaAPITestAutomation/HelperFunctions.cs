using Limilabs.Mail.Headers;
using Newtonsoft.Json;
using Octopus.Client.Model.Git;
using OpenPop.Mime;
using OpenPop.Pop3;
using RestSharp;
using RestSharp.Authenticators;
using System.Collections.Generic;
using System.Linq;
using System.Net.Imap4;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System;

namespace FinboaAPITestAutomation
{
    public static class HelperFunctions
    {
        public static string AccessToken = string.Empty;

        public static string GetEmailAuthenticationCode(string username, string password)
        {
            using (Pop3Client client = new Pop3Client())
            {
                // Connect to the server
                client.Connect("pop.gmail.com", 995, true);

                // Authenticate ourselves towards the server
                client.Authenticate(username, password, AuthenticationMethod.UsernameAndPassword);

                // Get the number of messages in the inbox
                int messageCount = client.GetMessageCount();

                // We want to download all messages
                List<string> allMessages = new List<string>(messageCount);

                // Messages are numbered in the interval: [1, messageCount]
                // Ergo: message numbers are 1-based.
                // Most servers give the latest message the highest number

                var message = client.GetMessage(messageCount);
                var body = message.FindFirstHtmlVersion().GetBodyAsText();
                var authenticationCode = Regex.Match(body, @"\d+").Value;

                client.Disconnect();
                client.Dispose();

                return authenticationCode;

            }
        }

        internal static RestRequest AddParametersInRequest(RestRequest request, string ParamName, string ParamValue)
        {
            request.AddParameter(ParamName, ParamValue);

            return request;
        }

        private static Imap4Client client;

        public static string GetEmailAuthenticationCode2(string username, string password)
        {
            client = new Imap4Client();
            client.Connect("imap.gmail.com", 993, true);
            
            client.SendAuthUserPass(username, password, Imap4Client.AuthTypes.Plain);
            var folders = client.ListFolders();
            client.SelectFolder("Inbox");
            //var currentFolder = client.CurrentFolder;
            var emailCount = client.GetEmailCount();
            //var unreadEmails = client.UnreadEmails; 
            //uint availableType = client.AvailableEmails;
            var message = client.GetEmail(emailCount);
            var body = message.Body;
            var authenticationCode = Regex.Match(body, @"\d+").Value;
            client.Disconnect();

            return authenticationCode;
        }

        public static Dictionary<string, string> DeserializeResponseToJson(RestResponse response)
        {
            return JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
        }

        public static RestClient InitializeDisputeDevAPIClient()
        {
            var restClient = new RestClient("https://disputedevapi.azurewebsites.net")
            {
                Authenticator = new JwtAuthenticator(TestLoginAPI.AccessToken),
            };

            return restClient;
        }

        public static RestClient InitializeFinboaTemplatesAPIClient()
        {
            var restClient = new RestClient("https://finboatemplatesapi.azurewebsites.net")
            {
                Authenticator = new JwtAuthenticator(TestLoginAPI.AccessToken),
            };

            return restClient;
        }

        internal static RestRequest AddParametersInRequest(RestRequest request, string ParamName, bool ParamValue)
        {
            request.AddParameter(ParamName, ParamValue);

            return request;
        }

        public static RestClient InitializeFinboaTemplateTestAPIClient()
        {
            var restClient = new RestClient("https://finboatemplatestestapi.azurewebsites.net")
            {
                Authenticator = new JwtAuthenticator(TestLoginAPI.AccessToken)
            };

            return restClient;
        }

        public static RestClient InitializeDisputeDevClient()
        {
            var restClient = new RestClient("https://disputedev.azurewebsites.net")
            {
                Authenticator = new JwtAuthenticator(TestLoginAPI.AccessToken)
            };

            return restClient;
        }

        public static RestRequest CreateGetRequest(string URI)
        {
            var request = new RestRequest(URI, Method.Get);

            request.AddHeader("Accept", "*/*");

            return request;
        }

        public static RestRequest CreateOptionsRequest(string URI)
        {
            var request = new RestRequest(URI, Method.Options);

            return request;
        }

        public static RestRequest CreatePostRequest(string URI)
        {
            var request = new RestRequest(URI, Method.Post);

            request.AddParameter("Cookie", TestLoginAPI.xsrf_cookie, ParameterType.HttpHeader);

            request.AddParameter("X-CSRF-Token", TestLoginAPI.AntiForgeryToken, ParameterType.HttpHeader);

            request.AddParameter("X-CSRF-Token-SSO", TestLoginAPI.AntiForgeryTokenSSO, ParameterType.HttpHeader);

            //request.AddParameter("Content-Type", "application/json", ParameterType.HttpHeader);

            return request;
        }

        public static RestRequest CreateDeleteRequest(string URI)
        {
            var request = new RestRequest(URI, Method.Delete);

            request.AddParameter("Cookie", TestLoginAPI.xsrf_cookie, ParameterType.HttpHeader);

            request.AddParameter("X-CSRF-Token", TestLoginAPI.AntiForgeryToken, ParameterType.HttpHeader);

            request.AddParameter("X-CSRF-Token-SSO", TestLoginAPI.AntiForgeryTokenSSO, ParameterType.HttpHeader);

            //request.AddParameter("Content-Type", "application/json", ParameterType.HttpHeader);

            return request;
        }

        public static RestClient InitializeFinboaAccountAPIV3Client()
        {
            var restClient = new RestClient("https://finboaaccountapiv3.azurewebsites.net");

            return restClient;
        }

        public static RestClient InitializeFinboaSSOClient()
        {
            var restClient = new RestClient("https://finboasso.azurewebsites.net")
            {
                Authenticator = new JwtAuthenticator(TestLoginAPI.AccessToken)
            };

            return restClient;
        }

        public static string ReadJsonBody(string location)
        {
            var relativePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            var completePath = Path.Combine(relativePath, location);

            if (!File.Exists(completePath))
                return null;

            var json = File.ReadAllText(completePath);

            return json;
        }

        public static RestClient InitializeFinboaAccountV3Client()
        {
            RestClient restClient  = new RestClient("https://finboaaccountv3.azurewebsites.net/");
            
            return restClient;
        }
    }
}
