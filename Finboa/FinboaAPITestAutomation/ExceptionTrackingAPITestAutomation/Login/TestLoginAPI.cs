using FinboaAPITestAutomation;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using RestSharp.Authenticators;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace ExceptionTrackingAPITestAutomation
{
    [TestFixture, Order(1)]
    public class TestLoginAPI
    {
        //RestClient restClient;
        public static string appUsername = "testautomationfinboa@gmail.com";
        string appPassword = "Password@4";
        public static string ETAccessToken = string.Empty;


        [Test]
        public async Task Test001_Post_Login_On_Login_Page()
        {
            var restClient = HelperFunctions.InitializeFinboaAccountAPIV3Client();

            var request = HelperFunctions.CreatePostRequest("Token");

            request.AddParameter("grant_type", "password");
            request.AddParameter("username", appUsername);
            request.AddParameter("password", appPassword);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = HelperFunctions.DeserializeResponseToJson(response);

            ETAccessToken = output["access_token"];
            
            Assert.That(output["access_token"].Length, Is.GreaterThanOrEqualTo(256));

            Assert.That(output["token_type"], Is.EqualTo("bearer"));

            Assert.That(output["expires_in"], Is.EqualTo("43199"));
        }

        [Test]
        public async Task Test002_Post_Check_On_Login_Page()
        {
            var restClient = HelperFunctions.InitializeFinboaAccountAPIV3Client();

            var request = HelperFunctions.CreatePostRequest("api/account/check");

            request.AddParameter("email", "dGVzdGF1dG9tYXRpb25maW5ib2FAZ21haWwuY29t");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

        }

        [Test]
        public async Task Test003_Get_LoginHTML_On_Login_Page()
        {
            var restClient = HelperFunctions.InitializeFinboaAccountV3Client();
            var request = HelperFunctions.CreateGetRequest("app/views/login.html");
            var response = await restClient.ExecuteAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test004_Get_ExceptionsHTML_On_Login_Page()
        {
            var restClient = HelperFunctions.InitializeFinboaAccountV3Client();
            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/exceptions.html");
            var response = await restClient.ExecuteAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test005_Get_FiltrationHTML_On_Login_Page()
        {
            var restClient = HelperFunctions.InitializeFinboaAccountV3Client();
            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/directivehtml/filtration.html");
            var response = await restClient.ExecuteAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test006_Get_AssignedToHTML_On_Login_Page()
        {
            var restClient = HelperFunctions.InitializeFinboaAccountV3Client();
            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/directivehtml/assignedTo.html");
            var response = await restClient.ExecuteAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test007_Get_ExceptionNewNoteHTML_On_Login_Page()
        {
            var restClient = HelperFunctions.InitializeFinboaAccountV3Client();
            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/directivehtml/exceptionNewNote.html");
            var response = await restClient.ExecuteAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test008_Get_DeleteConfirmationHTML_On_Login_Page()
        {
            var restClient = HelperFunctions.InitializeFinboaAccountV3Client();
            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/directivehtml/deleteConfirmation.html");
            var response = await restClient.ExecuteAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test009_Get_Settings_On_Login_Page()
        {
            var restClient = HelperFunctions.InitializeFinboaAccountAPIV3Client();
            restClient.Authenticator = new JwtAuthenticator(TestLoginAPI.ETAccessToken);
            var request = HelperFunctions.CreateGetRequest("api/exceptiondefinition/setting");
            var response = await restClient.ExecuteAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            var settings = JsonConvert.DeserializeObject<ExceptionTrackingEntities.Settings>(response.Content);
            Assert.That(settings.Id, Is.EqualTo(9), "User Id is not correct");
            Assert.That(settings.CompanyId, Is.EqualTo(2), "Company Id is not correct");
            Assert.That(settings.ShowAfterReviewed, Is.EqualTo(true), "ShowAfterReviewed flage is not correct");
            Assert.That(settings.SendExceptionEmails, Is.EqualTo(true), "SendExceptionEmails flage is not correct");
            Assert.That(settings.BranchManagerOverrideAccountCsr, Is.EqualTo(true), "BranchManagerOverrideAccountCsr flage is not correct");
            Assert.That(settings.EnableCases, Is.EqualTo(true), "EnableCases flage is not correct");
        }
        [Test]
        public async Task Test010_Get_Checklist_On_Login_Page()
        {
            var restClient = HelperFunctions.InitializeFinboaAccountAPIV3Client();
            restClient.Authenticator = new JwtAuthenticator(TestLoginAPI.ETAccessToken);
            var request = HelperFunctions.CreateGetRequest("/api/checklist/");
            var response = await restClient.ExecuteAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            var checklistsData = JsonConvert.DeserializeObject<List<ExceptionTrackingEntities.Checklists>>(response.Content);

        }

        [Test]
        public async Task Test011_Post_Count_On_Login_Page()
        {
            var restClient = HelperFunctions.InitializeFinboaAccountAPIV3Client();
            restClient.Authenticator = new JwtAuthenticator(TestLoginAPI.ETAccessToken);
            var request = HelperFunctions.CreatePostRequest("api/finboaalert/alerts/count");

           // request.AddParameter("email", "YWJkdWxAZmluYm9hLmNvbQ==");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

        }

    }
}