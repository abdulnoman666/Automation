using NUnit.Framework;
using RestSharp;
using System.Net;
using System.Threading.Tasks;

namespace FinboaAPITestAutomation
{
    [TestFixture]
    class TestCompanyDetailsAPI
    {
        RestClient restClient = null;
        string companyID = string.Empty;
        string id = string.Empty;
        string companyId = string.Empty;
        string category = string.Empty;
        string description = string.Empty;
        string reference = string.Empty;

        [OneTimeSetUp]
        public void Setup()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();
        }

        [Test]
        public async Task Test_Get_App_User_On_Company_Details_Page()
        {
            var request = HelperFunctions.CreateGetRequest("api/appuser");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = HelperFunctions.DeserializeResponseToJson(response);

            companyID = output["id"];

        }

        [Test]
        public async Task Test_Get_Home_On_Company_Details_Page()
        {
            var restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/home.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_User_Company_On_Company_Details_Page()
        {
            var request = HelperFunctions.CreateGetRequest($"api/appuser/{companyID}/usercompany");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(1)]
        public async Task Test_Post_Submission_Status_On_Company_Details_Page()
        {
            var request = HelperFunctions.CreatePostRequest("api/company/savelookupvalue");

            request.AddParameter("category", "3");
            request.AddParameter("description", "Closed");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = HelperFunctions.DeserializeResponseToJson(response);

            id = output["id"];
            category= output["category"];
            description= output["description"];
            companyId = output["companyId"];
        }

        [Test, Order(2)]
        public async Task Test_Delete_Submission_Status_On_Company_Details_Page()
        {
            var request = HelperFunctions.CreatePostRequest("api/company/deletelookupvalue");

            request.AddParameter("category", category);
            request.AddParameter("companyId", companyId);
            request.AddParameter("description", description);
            request.AddParameter("id",id);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(3)]
        public async Task Test_Post_Third_Party_Breach_Source_On_Company_Details_Page()
        {
            var request = HelperFunctions.CreatePostRequest("api/company/savelookupvalue");

            request.AddParameter("category", "4");
            request.AddParameter("description", "Third Party Breach Source");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = HelperFunctions.DeserializeResponseToJson(response);

            id = output["id"];
            category = output["category"];
            description = output["description"];
            companyId = output["companyId"];
        }

        [Test, Order(4)]
        public async Task Test_Delete_Third_Party_Breach_Source_On_Company_Details_Page()
        {
            var request = HelperFunctions.CreatePostRequest("api/company/deletelookupvalue");

            request.AddParameter("category", category);
            request.AddParameter("companyId", companyId);
            request.AddParameter("description", description);
            request.AddParameter("id", id);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(5)]
        public async Task Test_Post_Account_Type_On_Company_Details_Page()
        {
            var request = HelperFunctions.CreatePostRequest("api/company/savelookupvalue");

            request.AddParameter("category", "5");
            request.AddParameter("description", "CCA");
            request.AddParameter("reference", "Ref1");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = HelperFunctions.DeserializeResponseToJson(response);

            id = output["id"];
            category = output["category"];
            description = output["description"];
            companyId = output["companyId"];
            reference = output["reference"];
        }

        [Test, Order(6)]
        public async Task Test_Delete_Account_Type_On_Company_Details_Page()
        {
            var request = HelperFunctions.CreatePostRequest("api/company/deletelookupvalue");

            request.AddParameter("category", category);
            request.AddParameter("companyId", companyId);
            request.AddParameter("description", description);
            request.AddParameter("id", id);
            request.AddParameter("reference", reference);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(7)]
        public async Task Test_Post_Branch_On_Company_Details_Page()
        {
            var request = HelperFunctions.CreatePostRequest("api/company/savelookupvalue");

            request.AddParameter("category", "6");
            request.AddParameter("description", "Test Branch");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = HelperFunctions.DeserializeResponseToJson(response);

            id = output["id"];
            category = output["category"];
            description = output["description"];
            companyId = output["companyId"];
        }

        [Test, Order(8)]
        public async Task Test_Delete_Branch_On_Company_Details_Page()
        {
            var request = HelperFunctions.CreatePostRequest("api/company/deletelookupvalue");

            request.AddParameter("category", category);
            request.AddParameter("companyId", companyId);
            request.AddParameter("description", description);
            request.AddParameter("id", id);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(9)]
        public async Task Test_Post_Charter_Branding_On_Company_Details_Page()
        {
            var request = HelperFunctions.CreatePostRequest("api/company/savelookupvalue");

            request.AddParameter("category", "7");
            request.AddParameter("description", "Test Charter");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = HelperFunctions.DeserializeResponseToJson(response);

            id = output["id"];
            category = output["category"];
            description = output["description"];
            companyId = output["companyId"];
        }

        [Test, Order(10)]
        public async Task Test_Delete_Charter_Branding_On_Company_Details_Page()
        {
            var request = HelperFunctions.CreatePostRequest("api/company/deletelookupvalue");

            request.AddParameter("category", category);
            request.AddParameter("companyId", companyId);
            request.AddParameter("description", description);
            request.AddParameter("id", id);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(11)]
        public async Task Test_Post_Contact_Lookup_On_Company_Details_Page()
        {
            var request = HelperFunctions.CreatePostRequest("api/company/savelookupvalue");

            request.AddParameter("category", "32");
            request.AddParameter("description", "Test Contact Lookup");
            request.AddParameter("reference", "Ref1");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = HelperFunctions.DeserializeResponseToJson(response);

            id = output["id"];
            category = output["category"];
            description = output["description"];
            companyId = output["companyId"];
            reference = output["reference"];
        }

        [Test, Order(12)]
        public async Task Test_Delete_Contact_Lookup_On_Company_Details_Page()
        {
            var request = HelperFunctions.CreatePostRequest("api/company/deletelookupvalue");

            request.AddParameter("category", category);
            request.AddParameter("companyId", companyId);
            request.AddParameter("description", description);
            request.AddParameter("id", id);
            request.AddParameter("reference", reference);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(13)]
        public async Task Test_Post_Transaction_Decline_Reason_On_Company_Details_Page()
        {
            var request = HelperFunctions.CreatePostRequest("api/company/savelookupvalue");

            request.AddParameter("category", "33");
            request.AddParameter("description", "Test Reason 1");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = HelperFunctions.DeserializeResponseToJson(response);

            id = output["id"];
            category = output["category"];
            description = output["description"];
            companyId = output["companyId"];
        }

        [Test, Order(14)]
        public async Task Test_Delete_Transaction_Decline_Reason_On_Company_Details_Page()
        {
            var request = HelperFunctions.CreatePostRequest("api/company/deletelookupvalue");

            request.AddParameter("category", category);
            request.AddParameter("companyId", companyId);
            request.AddParameter("description", description);
            request.AddParameter("id", id);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(15)]
        public async Task Test_Post_Batch_Reporting_Reference_On_Company_Details_Page()
        {
            var request = HelperFunctions.CreatePostRequest("api/company/savelookupvalue");

            request.AddParameter("category", "34");
            request.AddParameter("description", "Test Reason 1");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = HelperFunctions.DeserializeResponseToJson(response);

            id = output["id"];
            category = output["category"];
            description = output["description"];
            companyId = output["companyId"];
        }

        [Test, Order(16)]
        public async Task Test_Delete_Batch_Reporting_Reference_On_Company_Details_Page()
        {
            var request = HelperFunctions.CreatePostRequest("api/company/deletelookupvalue");

            request.AddParameter("category", category);
            request.AddParameter("companyId", companyId);
            request.AddParameter("description", description);
            request.AddParameter("id", id);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(17)]
        public async Task Test_Post_Dipute_Research_Detail_On_Company_Details_Page()
        {
            var request = HelperFunctions.CreatePostRequest("api/company/savelookupvalue");

            request.AddParameter("category", "1");
            request.AddParameter("description", "Test Dispute Research");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = HelperFunctions.DeserializeResponseToJson(response);

            id = output["id"];
            category = output["category"];
            description = output["description"];
            companyId = output["companyId"];
        }

        [Test, Order(18)]
        public async Task Test_Delete_Dipute_Research_Detail_On_Company_Details_Page()
        {
            var request = HelperFunctions.CreatePostRequest("api/company/deletelookupvalue");

            request.AddParameter("category", category);
            request.AddParameter("companyId", companyId);
            request.AddParameter("description", description);
            request.AddParameter("id", id);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(19)]
        public async Task Test_Update_Company_Detail_On_Company_Details_Page()
        {
            var request = HelperFunctions.CreatePostRequest("api/company/update");

            request.AddParameter("accountDigits", "0");
            request.AddParameter("active", true);
            request.AddParameter("activeUntil", "2019-01-26T23:24:32.007");
            request.AddParameter("address", "Evacuee Trust");
            request.AddParameter("camsImportConfigurationId", 0);
            request.AddParameter("cardDigits", "0");
            request.AddParameter("cardValidation", false);
            request.AddParameter("customerAppLink", "https://disputedev.azurewebsites.net/customerapp2/");
            request.AddParameter("customerAppReadOnly", true);
            request.AddParameter("customerUploadInProgress", false);
            request.AddParameter("customersImportConfigurationId", 0);
            request.AddParameter("defaultCycleDay", 1);
            request.AddParameter("defaultMEStatement", true);
            request.AddParameter("email", "support@finboa.com");
            request.AddParameter("emailDistributionList", "disputes@finboa.com");
            request.AddParameter("integrated", true);
            request.AddParameter("keyGUID", "ac704571-1f8c-4d5b-ac6d-cf3bbfea63d4");
            request.AddParameter("keyVersion", "b9cd7138f902434ba62af241c09d7209");
            request.AddParameter("logo", false);
            request.AddParameter("cardValidation", "https://bsddev.blob.core.windows.net/logos/logo-d036936ca7a14c11bd116f6a92d0a23dlogo-f660a6896cc64e07a6cc09e130a825befinboa-logo.png");
            //request.AddParameter("logoStoragePath", "logo-d036936ca7a14c11bd116f6a92d0a23dlogo-f660a6896cc64e07a6cc09e130a825befinboa-logo.png");
            request.AddParameter("masterCompanyId", 0);
            request.AddParameter("minClaim", 25);
            request.AddParameter("nonFraudSubmission", false);
            request.AddParameter("phone", "03325166674");
            request.AddParameter("processor", 1);
            request.AddParameter("redirect", false);
            request.AddParameter("responseEmail", "support@finboa.com");
            request.AddParameter("signaturePad", "topaz-signature");
            request.AddParameter("softwareVersion", "Enterprise");
            request.AddParameter("state", "PU");
            request.AddParameter("city", "RWP");
            request.AddParameter("companyName", "FINBOA Dev Test");
            request.AddParameter("id", 2);
            request.AddParameter("idleTime", 60);
            request.AddParameter("zip",66000);
            request.AddParameter("timeZone", "Central Standard Time");
            request.AddParameter("transactionsImportConfigurationId", 0);
            request.AddParameter("usePrefix", true);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
