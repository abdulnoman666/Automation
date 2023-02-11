using NUnit.Framework;
using RestSharp;
using System.Net;
using System.Threading.Tasks;

namespace FinboaAPITestAutomation
{
    [TestFixture]
    class TestQuestionnaireDependencySetupAPI
    {
        RestClient restClient = null;
        string id = string.Empty;

        [Test]
        public async Task Test_Get_Form_Dependency_List_On_Questionnaire_Dependency_Setup_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/formdependencylist");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Form_Dependency_List_By_ID_On_Questionnaire_Dependency_Setup_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/formdependencylist/1");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Finboa_Form_List_On_Questionnaire_Dependency_Setup_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("finboamodules/FINBOAForms/finboaformlist.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Upload_Form_Popup_On_Questionnaire_Dependency_Setup_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("finboamodules/FINBOASolutionLibrary/uploadFormPopup.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(1)]
        public async Task Test_Post_Add_Form_Dependency_List_On_Questionnaire_Dependency_Setup_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/formdependencylist");

            request.AddParameter("workFlowName", "Test Questionnaire Dependency Setup");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = HelperFunctions.DeserializeResponseToJson(response);

            id = output["id"];
        }

        [Test, Order(2)]
        public async Task Test_Post_Save_Step_Form_Dependency_List_On_Questionnaire_Dependency_Setup_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest($"api/formdependencylist/{id}/savestep");

            request.AddParameter("formDataCondition", "Step Name");
            request.AddParameter("parentTemplateId", "Parent Template Id");
            request.AddParameter("templateId", "Template Id");
            request.AddParameter("templateName", "TemplateName");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(3)]
        public async Task Test_Post_Delete_Form_Dependency_List_On_Questionnaire_Dependency_Setup_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateDeleteRequest($"api/formdependencylist/{id}");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

    }
}
