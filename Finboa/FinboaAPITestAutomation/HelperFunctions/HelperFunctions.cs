using Newtonsoft.Json;
using OpenPop.Pop3;
using RestSharp;
using RestSharp.Authenticators;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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

                return authenticationCode;

            }
        }

        public static Dictionary<string, string> DeserializeResponseToJson(RestResponse response)
        {
            return JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
        }

        public static RestClient InitializeRestClient()
        {
            var restClient = new RestClient("https://disputedevapi.azurewebsites.net");
            restClient.Authenticator = new JwtAuthenticator(TestLoginAPI.AccessToken);

            return restClient;
        }

        public static RestClient InitializeRestClient2()
        {
            var restClient = new RestClient("https://disputedev.azurewebsites.net");
            restClient.Authenticator = new JwtAuthenticator(TestLoginAPI.AccessToken);

            return restClient;
        }

        public static RestRequest CreateGetRequest(string URI)
        {
            var request = new RestRequest(URI, Method.Get);

            return request;
        }

        public static RestRequest CreatePostRequest(string URI)
        {
            var request = new RestRequest(URI, Method.Post);

            return request;
        }
    }
}
