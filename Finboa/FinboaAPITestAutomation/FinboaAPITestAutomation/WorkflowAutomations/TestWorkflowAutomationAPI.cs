using FinboaAPITestAutomation.AlertDefinitions;
using FinboaAPITestAutomation.WorkflowAutomations;
using Newtonsoft.Json;
using NUnit.Framework;
using Octopus.Server.MessageContracts.Base;
using RestSharp;
using System.Net;
using System.Threading.Tasks;

namespace FinboaAPITestAutomation
{
    [TestFixture]
    class TestWorkflowAutomationAPI
    {
        RestClient restClient = null;
        int id = 0;

        [Test]
        public async Task Test_Get_Workflow_Automation_on_Workflow_Automation_Page()
        {
            restClient = HelperFunctions.InitializeFinboaTemplateTestAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/workflowautomation");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }



        [Test]
        public async Task Test_Get_Workflow_Automation_By_ID_on_Workflow_Automation_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/workflow/1536");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Workflow_Automation_List_on_Workflow_Automation_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("finboamodules/FINBOAWorkflowAutomations/workflowautomationlist.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Workflow_Automation_Edit_on_Workflow_Automation_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("finboamodules/FINBOAWorkflowAutomations/workflowedit.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Workflow_Automation_Library_Popup_on_Workflow_Automation_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("finboamodules/FINBOASolutionLibrary/workflowAutomationLibraryPopup.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(1)]
        public async Task Test_Post_Copy_Workflow_Automation_on_Workflow_Automation_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var nId = "1537";
            var request = HelperFunctions.CreatePostRequest($"api/workflow/{nId}/copyworkflow");

            request.AddParameter("companyId", "2");
            request.AddParameter("conditions", "customerDispute.disputeType === 1 && customerDispute.accountType === 2 && customerDispute.source === 'Debit Card' && !customerDispute.convertedOn");
            request.AddParameter("id", nId);
            request.AddParameter("name", "Consumer Fraud - Visa Zero Liability");
            request.AddParameter("reference", "CFVZL");
            request.AddParameter("scope", "CustomerDisputes");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var item = JsonConvert.DeserializeObject<WorkflowAutomation>(response.Content);

            id = item.Id;
        }

        [Test, Order(2)]
        public async Task Test_Post_Delete_Workflow_Automation_on_Workflow_Automation_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            await DeleteWorkflowAutomation();
        }

        private async Task DeleteWorkflowAutomation()
        {
            var request = HelperFunctions.CreateDeleteRequest($"api/workflow/{id}");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(3)]
        public async Task Test_Post_Create_Workflow_Automation_on_Workflow_Automation_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest($"api/workflow");

            request.AddParameter("conditions", "customerDispute.disputeType === 1 && customerDispute.accountType === 2 && customerDispute.source === 'Debit Card' && !customerDispute.convertedOn");
            request.AddParameter("name", "New Workflow");
            request.AddParameter("reference", "WN");
            request.AddParameter("scope", "CustomerDisputes");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var item = JsonConvert.DeserializeObject<WorkflowAutomation>(response.Content);

            id = item.Id;
        }

        [Test, Order(4)]
        public async Task Test_Post_Save_Workflow_Automation_Step_on_Workflow_Automation_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest($"api/workflow/{id}/savestep");

            request.AddParameter("name", "Calculation");
            request.AddParameter("order", "1");
            request.AddParameter("parentStepId", "0");
            request.AddParameter("value", "RegE");
            request.AddParameter("value2", "PC");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            await DeleteWorkflowAutomation();   
        }
    }
}
