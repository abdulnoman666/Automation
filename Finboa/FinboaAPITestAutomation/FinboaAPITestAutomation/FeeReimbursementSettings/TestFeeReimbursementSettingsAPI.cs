using NUnit.Framework;
using RestSharp;
using System.Net;
using System.Threading.Tasks;

namespace FinboaAPITestAutomation
{
    class TestFeeReimbursementSettingsAPI
    {
        RestClient restClient = null;
        string id = string.Empty;
        string autoFeeGLReference = string.Empty;
        bool autoGenerateGL = false;
        bool createDispute = false;
        string description = string.Empty;
        bool includeInClaimTotal = false;
        string reference = string.Empty;
        bool showOnDisputeForm = false;
        string companyID = string.Empty;
        string createdBy = string.Empty;
        string createdOn = string.Empty;

        [Test]
        public async Task Test_Get_Fee_Reimbursement_On_Fee_Reimbursement_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/settings/feereimbursements.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Fee_Reimbursement_Link_On_Fee_Reimbursement_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/feereimbursementlink");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Add_Fee_Reimbursement_Link_On_Fee_Reimbursement_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/feereimbursementlink");

            autoFeeGLReference = "PCWO";
            autoGenerateGL = true;
            createDispute = true;
            description = "Description";
            includeInClaimTotal= true;
            reference = "Reference";
            showOnDisputeForm= true;

            request.AddParameter("autoFeeGLReference", autoFeeGLReference);
            request.AddParameter("autoGenerateGL", autoGenerateGL);
            request.AddParameter("createDispute", createDispute);
            request.AddParameter("description", description);
            request.AddParameter("includeInClaimTotal", includeInClaimTotal);
            request.AddParameter("reference", reference);
            request.AddParameter("showOnDisputeForm", showOnDisputeForm);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = HelperFunctions.DeserializeResponseToJson(response);

            id = output["id"];
            createdBy= output["createdBy"];
            createdOn = output["createdOn"];
            companyID = output["companyId"];
        }

        [Test]
        public async Task Test_Post_Delete_Fee_Reimbursement_Link_On_Fee_Reimbursement_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/feereimbursementlink/delete");

            request.AddParameter("autoFeeGLReference", autoFeeGLReference);
            request.AddParameter("autoGenerateGL", autoGenerateGL);
            request.AddParameter("companyId",companyID);
            request.AddParameter("createDispute", createDispute);
            request.AddParameter("createdBy", createdBy);
            request.AddParameter("createdOn", createdOn);
            request.AddParameter("description", description);
            request.AddParameter("id", id);
            request.AddParameter("includeInClaimTotal", includeInClaimTotal);
            request.AddParameter("reference", reference);
            request.AddParameter("showOnDisputeForm", showOnDisputeForm);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
