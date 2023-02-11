using FinboaAPITestAutomation.AlertDefinitions;
using FinboaAPITestAutomation.FieldUpdateScripts;
using Newtonsoft.Json;
using NUnit.Framework;
using Octopus.Server.MessageContracts.Base;
using RestSharp;
using System;
using System.Net;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FinboaAPITestAutomation
{
    [TestFixture]
    class TestFieldUpdateScriptsAPI
    {
        RestClient restClient = null;
        int id = 0;
        string automationName = string.Empty;
        int companyId = 0;
        string automationReference = string.Empty;
        int stepId = 0;

        [Test]
        public async Task Test_Get_Automation_Scripts_on_Field_Update_Scripts_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/automationscript");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Automation_Scripts_By_ID_on_Field_Update_Scripts_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/automationscript/1");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Script_List_on_Field_Update_Scripts_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/settings/scriptlist.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(1)]
        public async Task Test_Post_Add_Automation_Script_on_Field_Update_Scripts_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            RestResponse response = await CreateFieldUpdateScript("Test Script", "TS1");

            var output = HelperFunctions.DeserializeResponseToJson(response);

            id = Int32.Parse(output["id"]);
            automationName = output["automationName"];
            companyId = Int32.Parse(output["companyId"]);
            automationReference = output["reference"];
        }

        

        [Test, Order(2)]
        public async Task Test_Post_Delete_Automation_Script_on_Field_Update_Scripts_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            await DeleteFieldUpdateScript(automationName, companyId, id, automationReference);
        }
        

        [Test, Order(3)]
        public async Task Test_Post_Save_Field_Update_Step_on_Field_Update_Scripts_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            RestResponse response1 = await CreateFieldUpdateScript("Test Script", "TS1");

            var output1 = HelperFunctions.DeserializeResponseToJson(response1);

            id = Int32.Parse(output1["id"]);
            automationName = output1["automationName"];
            companyId = Int32.Parse(output1["companyId"]);
            automationReference = output1["reference"];

            var request = HelperFunctions.CreatePostRequest($"api/automationscript/{id}/savefieldupdate");

            request = RequestHelper.CreateSaveFieldUpdateScriptRequest(request, "Converted", "=", "CustomerDisputes", "15");

            var response2 = await restClient.ExecuteAsync(request);

            Assert.That(response2.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output2 = HelperFunctions.DeserializeResponseToJson(response2);

            var automationScriptId = output2["automationScriptId"];
            var field = output2["field"];
            stepId = Int32.Parse(output2["id"]);
            var operatorAction = output2["operatorAction"];
            var tableName = output2["tableName"];
            var value = output2["value"];
        }

        [Test, Order(4)]
        public async Task Test_Post_Delete_Field_Update_Step_on_Field_Update_Scripts_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest($"api/automationscript/{id}/deletefieldupdate/{stepId}");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(5)]
        public async Task Test_Post_Copy_Field_Update_Step_on_Field_Update_Scripts_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest($"api/automationscript/{id}/copyscript");

            request.AddParameter("automationName", automationName);
            request.AddParameter("companyId", companyId);
            request.AddParameter("id", id);
            request.AddParameter("reference", automationReference);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var item = JsonConvert.DeserializeObject<FieldUpdate>(response.Content);

            //delete original field update script
            await DeleteFieldUpdateScript(automationName, companyId, id, automationReference);

            //delete copied field update script
            await DeleteFieldUpdateScript(item.AutomationName, item.CompanyId, item.Id, item.Reference);
        }

        private async Task<RestResponse> CreateFieldUpdateScript(string scriptName, string scriptRefernce)
        {
            var request = HelperFunctions.CreatePostRequest("api/automationscript");

            request = RequestHelper.CreateFieldUpdateSciptRequest(request, scriptName, scriptRefernce);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            return response;
        }
        private async Task DeleteFieldUpdateScript(string automationName, int companyId, int id, string automationReference)
        {
            var request = HelperFunctions.CreatePostRequest($"api/automationscript/{id}/deletescript");

            request = RequestHelper.DeleteFieldUpdateScriptRequest(request, automationName, companyId, id, automationReference);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
