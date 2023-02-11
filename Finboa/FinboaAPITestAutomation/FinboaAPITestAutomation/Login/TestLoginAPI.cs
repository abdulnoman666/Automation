using NUnit.Framework;
using RestSharp;
using RestSharp.Authenticators;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace FinboaAPITestAutomation
{
    [TestFixture, Order(1)]
    class TestLoginAPI
    {
        RestClient restClient = null;
        string authenticationToken = string.Empty;
        string otpToken = string.Empty;
        public static string AccessToken = string.Empty;
        public static string AntiForgeryTokenSSO = string.Empty;
        public static string AntiForgeryToken = string.Empty;
        string appUsername = "abdul@finboa.com";
        string appPassword = "Password@4";
        string emailPassword = "$Pak35tan$2024";
        public static string xsrf_cookie = string.Empty;
        public static RestClient globalRestClient = null;

        [OneTimeSetUp]
        public void Setup()
        {
            restClient = new RestClient("https://finboasso.azurewebsites.net");
        }

        [Test, Order(1)]
        public async Task Test_Post_Authentication_Token_On_Login_Page()
        {
            //restClient = new RestClient("https://finboasso.azurewebsites.net");

            var request = HelperFunctions.CreatePostRequest("token");
            

            request.AddParameter("grant_type", "password");
            request.AddParameter("username", appUsername);
            request.AddParameter("password", appPassword);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = HelperFunctions.DeserializeResponseToJson(response);

            authenticationToken = output["access_token"];

            Assert.That(output["access_token"].Length, Is.GreaterThanOrEqualTo(283));

            Assert.That(output["token_type"], Is.EqualTo("bearer"));

            Assert.That(output["expires_in"], Is.EqualTo("43199"));

            Assert.That(output["otp_required"], Is.EqualTo("Please provide otp"));
        }

        [Test, Order(2)]
        public async Task Test_Get_Acount_Otp_Auth_On_Login_Page()
        {
            //restClient = new RestClient("https://finboasso.azurewebsites.net");

            var request = HelperFunctions.CreateGetRequest("api/Account/otp/auth");
            restClient.Authenticator = new JwtAuthenticator(authenticationToken);
            
            request.AddHeader("Origin", "https://finboasso.azurewebsites.net");  

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            Thread.Sleep(10000);
            otpToken = HelperFunctions.GetEmailAuthenticationCode2(appUsername, emailPassword);
        }

        [Test, Order(3)]
        public async Task Test_Post_Login_On_Login_Page()
        {
            //restClient = new RestClient("https://finboasso.azurewebsites.net");

            var request = HelperFunctions.CreatePostRequest("Token");

            request.AddHeader("Origin", "https://finboasso.azurewebsites.net");

            
            request.AddParameter("grant_type", "password");
            request.AddParameter("username", appUsername);
            request.AddParameter("password", appPassword);
            request.AddParameter("scope", $"otp:{otpToken}");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = HelperFunctions.DeserializeResponseToJson(response);

            AccessToken = output["access_token"];

            Assert.That(output["token_type"], Is.EqualTo("bearer"));

            Assert.That(output["expires_in"], Is.EqualTo("43199"));

            Assert.That(AccessToken.Length, Is.GreaterThanOrEqualTo(368));
        }

        [Test, Order(4)]
        public async Task Test_Get_AntiForgery_Token_SSO_On_Login_Page()
        {
            //restClient = new RestClient("https://finboasso.azurewebsites.net");

            restClient.Authenticator = new JwtAuthenticator(AccessToken);

            var request = HelperFunctions.CreateGetRequest("antiforgerytokensso");

            var response = await restClient.ExecuteAsync(request); //xsrf-token-sso=5j4bmmWdWr810oT-x2e2ZoCTVxSrnJEOxJrJpGNDEQlxF9kdcRvLjSYa55OU1h_eLPKNMOtQkc5Cvis7cSMyprAQx181

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = HelperFunctions.DeserializeResponseToJson(response);

            AntiForgeryTokenSSO = output["AntiForgeryToken"];

            Assert.That(output["AntiForgeryToken"].Length, Is.GreaterThanOrEqualTo(92));
        }

        [Test, Order(5)]
        public async Task Test_Get_AntiForgery_Token_On_Login_Page()
        {
            var restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("antiforgerytoken");

            //restClient.Authenticator = new JwtAuthenticator(AccessToken);

            //request.AddParameter("Cookie", cookie, ParameterType.HttpHeader);

            var response = await restClient.ExecuteAsync(request);

            xsrf_cookie = response.Cookies[0].ToString(); //xsrf-token=CTorSh9QjQpQaVKZXxIdJHOGXJov_xXmsU95OoaqtN86MUaaf1W8YreMr6fQr-DTbj6dDACDXeE39-nW-86Kn5b8VPs1

            /*cookieName = response.Cookies[0].Name;
            cookieValue = response.Cookies[0].Value;
            cookiePath = response.Cookies[0].Path;
            cookieDomain = response.Cookies[0].Domain;*/

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = HelperFunctions.DeserializeResponseToJson(response);

            AntiForgeryToken = output["AntiForgeryToken"];

            Assert.That(output["AntiForgeryToken"].Length, Is.GreaterThanOrEqualTo(92));

            /*these lines of code also works
             * restClient.AddDefaultHeader("Cookie", xsrf_cookie);

            restClient.AddDefaultHeader("X-CSRF-Token", AntiForgeryToken);

            restClient.AddDefaultHeader("X-CSRF-Token-SSO", TestLoginAPI.AntiForgeryTokenSSO);*/

            globalRestClient = restClient;

            /*var request2 = new RestRequest("api/note", Method.Post);

            request2.AddParameter("Cookie", xsrf_cookie, ParameterType.HttpHeader);

            request2.AddParameter("X-CSRF-Token", AntiForgeryToken, ParameterType.HttpHeader);

            request2.AddParameter("X-CSRF-Token-SSO", TestLoginAPI.AntiForgeryTokenSSO, ParameterType.HttpHeader);

            var jsonBody = HelperFunctions.ReadJsonBody("JSONData\\AddNote.json");

            //request2.AddJsonBody(jsonBody);

            request2.AddParameter(jsonBody, ParameterType.RequestBody);

            //restClient.AddCookie(response.Cookies[0].Name, response.Cookies[0].Value, response.Cookies[0].Path, response.Cookies[0].Domain);

            var response2 = await restClient.ExecuteAsync(request2);

            Assert.That(response2.StatusCode, Is.EqualTo(HttpStatusCode.OK));*/
        }

        [Test, Order(6)]
        public async Task Test_Post_Vaidation_On_Login_Page()
        {
            //restClient = new RestClient("https://finboasso.azurewebsites.net");

            restClient.Authenticator = new JwtAuthenticator(AccessToken);

            var request = HelperFunctions.CreatePostRequest("validation");

            request.AddParameter("grant_type", "password");
            request.AddParameter("username", appUsername);
            request.AddParameter("password", appPassword);

            var response = await restClient.ExecuteAsync(request); //xsrf-token-sso=5j4bmmWdWr810oT-x2e2ZoCTVxSrnJEOxJrJpGNDEQlxF9kdcRvLjSYa55OU1h_eLPKNMOtQkc5Cvis7cSMyprAQx181

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
