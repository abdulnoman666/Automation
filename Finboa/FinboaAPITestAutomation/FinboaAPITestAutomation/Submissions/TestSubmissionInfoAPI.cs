using NUnit.Framework;
using RestSharp;
using RestSharp.Authenticators;
using System.Net;
using System.Threading.Tasks;

namespace FinboaAPITestAutomation
{
    public class AddNote
    {
        public string customerDisputeId { get; set; }
        public long customerId { get; set; }
        public bool isBackoffice { get; set; }
        public string notes { get; set; }
    }

    class TestSubmissionInfoAPI
    {
        string noteID = string.Empty;
        string noteCreationTime = string.Empty;

        RestClient restClient = null;

        /*[Test]
        public async Task Test_Get_Generate_Report_Task_On_Print_Letter_On_Submission_Info_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/customerdispute/3500/generatereporttask");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }*/

        [Test]
        public async Task Test_Post_Add_Note_On_Submission_Info_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/note");

            request = RequestHelper.AddNotesRequest(request, "3541", 2, true, "Notes for Backoffice only from Test Automation Project");

            var response = await restClient.ExecuteAsync(request);
            //var response = await TestLoginAPI.globalRestClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = HelperFunctions.DeserializeResponseToJson(response);

            noteID = output["id"];
            //noteCreationTime = output["createdOn"];
        }

        [Test]
        public async Task Test_Post_Update_Note_On_Submission_Info_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/customerdispute/3543/updatenotes");

            request.AddParameter("notes", "Notes updated from test automation");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Consumer_Fraud_Reg_E_Consumer_Liability_On_Submission_Info_Page()
        {
            var submissionId = "3544";

            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            await ResetSubmission(submissionId);

            await RegEConsumerLiability(submissionId);
        }

        [Test]
        public async Task Test_Post_Consumer_Fraud_Visa_Zero_Liability_On_Submission_Info_Page()
        {
            var submissionId = "3544";

            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            await ResetSubmission(submissionId);

            var request = HelperFunctions.CreatePostRequest($"api/customerdispute/{submissionId}/runworkflow2/1537");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Consumer_Fraud_No_PC_Affidavit_Not_Signed_On_Submission_Info_Page()
        {
            var submissionId = "3544";

            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            await ResetSubmission(submissionId);

            var request = HelperFunctions.CreatePostRequest($"api/customerdispute/{submissionId}/runworkflow2/1538");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Consumer_Fraud_Issue_Final_Credit_And_Close_On_Submission_Info_Page()
        {
            var submissionId = "3544";

            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            await ResetSubmission(submissionId);

            var request = HelperFunctions.CreatePostRequest($"api/customerdispute/{submissionId}/runworkflow2/1539");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Consumer_Fraud_Issue_PC_On_Submission_Info_Page()
        {
            var submissionId = "3544";

            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            await ResetSubmission(submissionId);

            var request = HelperFunctions.CreatePostRequest($"api/customerdispute/{submissionId}/runworkflow2/1683");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Assign_Case_On_Submission_Info_Page()
        {
            var submissionId = "3622";

            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            await ResetSubmission(submissionId);

            var request = HelperFunctions.CreatePostRequest($"api/customerdispute/{submissionId}/runworkflow2/1711");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Approve_Provisional_Credit_Bank_Loss_Print_Consolidated_Resolution_Notice_On_Submission_Info_Page()
        {
            var submissionId = "3544";

            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            await ResetSubmission(submissionId);

            await RegEConsumerLiability(submissionId);

            var request = HelperFunctions.CreatePostRequest($"api/customerdispute/{submissionId}/runworkflow2/1560");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Approve_Provisional_Credit_Merchant_Loss_Print_Consolidated_Resolution_Notice_On_Submission_Info_Page()
        {
            var submissionId = "3544";

            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            await ResetSubmission(submissionId);

            await RegEConsumerLiability(submissionId);

            var request = HelperFunctions.CreatePostRequest($"api/customerdispute/{submissionId}/runworkflow2/1561");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Decline_Provisional_Credit_for_No_Error_Customer_Loss_Print_Consolidated_Resolution_Notice_On_Submission_Info_Page()
        {
            var submissionId = "3544";

            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            await ResetSubmission(submissionId);

            await RegEConsumerLiability(submissionId);

            var request = HelperFunctions.CreatePostRequest($"api/customerdispute/{submissionId}/runworkflow2/1562");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Decline_Provisional_Credit_for_60_Day_Customer_Loss_Print_Consolidated_Resolution_Notice_On_Submission_Info_Page()
        {
            var submissionId = "3544";

            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            await ResetSubmission(submissionId);

            await RegEConsumerLiability(submissionId);

            var request = HelperFunctions.CreatePostRequest($"api/customerdispute/{submissionId}/runworkflow2/1563");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Update_to_Pre_Arbitration_On_Submission_Info_Page()
        {
            var submissionId = "3544";

            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            await ResetSubmission(submissionId);

            var request = HelperFunctions.CreatePostRequest($"api/customerdispute/{submissionId}/runworkflow2/1699");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Business_Fraud_Issue_PC_On_Submission_Info_Page()
        {
            var submissionId = "3545";

            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            await ResetSubmission(submissionId);

            await BusinessFraudIssuePC(submissionId);
        }

        [Test]
        public async Task Test_Post_Approve_And_Issue_Final_Credit_Bank_Loss_Print_Consolidated_Resolution_Notice_On_Submission_Info_Page()
        {
            var submissionId = "3545";

            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            await ResetSubmission(submissionId);

            await BusinessFraudIssuePC(submissionId);

            var request = HelperFunctions.CreatePostRequest($"api/customerdispute/{submissionId}/runworkflow2/1564");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Approve_And_Issue_Final_Credit_Merchant_Loss_Print_Consolidated_Resolution_Notice_On_Submission_Info_Page()
        {
            var submissionId = "3545";

            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            await ResetSubmission(submissionId);

            await BusinessFraudIssuePC(submissionId);

            var request = HelperFunctions.CreatePostRequest($"api/customerdispute/{submissionId}/runworkflow2/1565");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Decline_For_No_Error_Customer_Loss_Print_Consolidated_Resolution_Notice_On_Submission_Info_Page()
        {
            var submissionId = "3545";

            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            await ResetSubmission(submissionId);

            await BusinessFraudIssuePC(submissionId);

            var request = HelperFunctions.CreatePostRequest($"api/customerdispute/{submissionId}/runworkflow2/1566");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Decline_For_60_Day_Rule_Customer_Loss_Print_Consolidated_Resolution_Notice_On_Submission_Info_Page()
        {
            var submissionId = "3545";

            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            await ResetSubmission(submissionId);

            await BusinessFraudIssuePC(submissionId);

            var request = HelperFunctions.CreatePostRequest($"api/customerdispute/{submissionId}/runworkflow2/1567");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        private async Task BusinessFraudIssuePC(string submissionId)
        {
            await ResetSubmission(submissionId);

            var request = HelperFunctions.CreatePostRequest($"api/customerdispute/{submissionId}/runworkflow2/1544");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Business_Fraud_No_PC_On_Submission_Info_Page()
        {
            var submissionId = "3545";

            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            await ResetSubmission(submissionId);

            var request = HelperFunctions.CreatePostRequest($"api/customerdispute/{submissionId}/runworkflow2/1545");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Business_Fraud_Issue_Final_Credit_And_Close_On_Submission_Info_Page()
        {
            var submissionId = "3545";

            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            await ResetSubmission(submissionId);

            var request = HelperFunctions.CreatePostRequest($"api/customerdispute/{submissionId}/runworkflow2/1546");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Convert_Claim_Total_To_Consumer_Liability_On_Submission_Info_Page()
        {
            var submissionId = "3545";

            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            await ResetSubmission(submissionId);

            var request = HelperFunctions.CreatePostRequest($"api/customerdispute/{submissionId}/runworkflow2/1718");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        private async Task RegEConsumerLiability(string submissionId)
        {
            var request = HelperFunctions.CreatePostRequest($"api/customerdispute/{submissionId}/runworkflow2/1536");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        private async Task ResetSubmission(string submissionId)
        {
            var resetRequest = HelperFunctions.CreatePostRequest($"api/customerdispute/{submissionId}/reversepc");

            resetRequest = HelperFunctions.AddParametersInRequest(resetRequest, "disputeid", submissionId);

            var resetResponse = await restClient.ExecuteAsync(resetRequest);

            Assert.That(resetResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}

