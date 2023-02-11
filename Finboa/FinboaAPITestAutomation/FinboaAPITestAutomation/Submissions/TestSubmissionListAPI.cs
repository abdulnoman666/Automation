using NUnit.Framework;
using RestSharp;
using RestSharp.Authenticators;
using System.Net;
using System.Threading.Tasks;

namespace FinboaAPITestAutomation
{
    [TestFixture]
    class TestSubmissionListAPI
    {
        RestClient restClient = null;

        [OneTimeSetUp]
        public void Setup()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();
        }

        [Test]
        public async Task Test_Get_Company_Settings_On_Submission_List_Page()
        {
            var request = HelperFunctions.CreateGetRequest("api/companysetting");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Users_On_Submission_List_Page()
        {
            var request = HelperFunctions.CreateGetRequest("api/company/users");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Alerts_On_Submission_List_Page()
        {
            var request = HelperFunctions.CreateGetRequest("api/customerdispute/alerts");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Custom_View_On_Submission_List_Page()
        {
            var request = HelperFunctions.CreateGetRequest("api/customview");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Withdraw_Submission_On_Submission_List_Page()
        {
            var request = HelperFunctions.CreateGetRequest("api/customerdispute/3489/withdrawdispute");

            var jsonBody = HelperFunctions.ReadJsonBody("JSONData\\WithdrawSubmission.json");
            
            request.AddJsonBody(jsonBody);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Alert_Dialog_On_Submission_List_Page()
        {
            var restClient2 = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/partials/alerts-dialog.html");

            var response = await restClient2.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Search_Submission_List_On_Submission_List_Page()
        {
            var restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/customerdispute/searchsubmissionlist");

            request = HelperFunctions.AddParametersInRequest(request, "reportedOnDateEnd", "Thu Oct 06 2022");
            request = HelperFunctions.AddParametersInRequest(request, "reportedOnDateStart", "Mon Sep 05 2022");
            request = HelperFunctions.AddParametersInRequest(request, "orderDirection", true);
            request = HelperFunctions.AddParametersInRequest(request, "orderBy", "reportedOn");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Search_Submission_List_By_Field_On_Submission_List_Page()
        {
            var restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/customerdispute/searchsubmissionlist");

            request = HelperFunctions.AddParametersInRequest(request, "customerName", "singal");
            request = HelperFunctions.AddParametersInRequest(request, "reportedOnDateEnd", "Thu Oct 06 2022");
            request = HelperFunctions.AddParametersInRequest(request, "reportedOnDateStart", "Mon Sep 05 2022");
            request = HelperFunctions.AddParametersInRequest(request, "orderDirection", true);
            request = HelperFunctions.AddParametersInRequest(request, "orderBy", "reportedOn");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Search_Submission_List_By_View_On_Submission_List_Page()
        {
            var restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/customerdispute/searchsubmissionlist");

            request = HelperFunctions.AddParametersInRequest(request, "source", "Debit Card");
            request = HelperFunctions.AddParametersInRequest(request, "reportedOnDateEnd", "Thu Oct 06 2022");
            request = HelperFunctions.AddParametersInRequest(request, "reportedOnDateStart", "Mon Sep 05 2022");
            request = HelperFunctions.AddParametersInRequest(request, "status", "New Dispute");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Reassign_Submission_On_Submission_List_Page()
        {
            var restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/customerdispute/3534/reassigndispute");

            request = RequestHelper.CreateReassignDisputeRequest(request, 1, 0, null, 50, null, 2, "FINBOA Demo Test2", false, null, 81, "2022-09-27",
                5, "Dheeraj Singal 1", 0, 0, null, 0, 1, null, 3532, 0, 0, 1, "2022-09-27", "Debit Card", "New Dispute", null, 321, 0, 1, null);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
