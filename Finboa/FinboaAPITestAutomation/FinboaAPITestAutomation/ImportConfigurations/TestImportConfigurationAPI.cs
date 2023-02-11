using NUnit.Framework;
using RestSharp;
using System.Net;
using System.Threading.Tasks;

namespace FinboaAPITestAutomation
{
    [TestFixture]
    class TestImportConfigurationAPI
    {
        RestClient restClient = null;
        private string confId = string.Empty;
        private string mapId = string.Empty;

        [Test]
        public async Task Test_Get_Import_Configuration_on_Import_Configuration_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/importconfiguration");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Import_Configuration_By_ID_on_Import_Configuration_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/importconfiguration/1");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Import_Configuration_List_on_Import_Configuration_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/settings/configlist.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(1)]
        public async Task Test_Post_Add_Import_Configuration_on_Import_Configuration_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/importconfiguration");

            request.AddParameter("delimiter", "1");
            request.AddParameter("description", "Test Configuration");
            request.AddParameter("fieldListName", "Account");
            request.AddParameter("hasHeaderRow", true);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = HelperFunctions.DeserializeResponseToJson(response);

            confId = output["id"];
        }

        [Test, Order(2)]
        public async Task Test_Post_Add_Field_Mapping_on_Import_Configuration_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest($"api/importconfiguration/{confId}/savefieldmapping");

            request.AddParameter("column", "1");
            request.AddParameter("linkedField", "CardNumber");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = HelperFunctions.DeserializeResponseToJson(response);

            mapId = output["id"];
        }

        [Test, Order(3)]
        public async Task Test_Get_Delete_Field_Mapping_on_Import_Configuration_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest($"api/importconfiguration/{confId}/deletefieldmapping/{mapId}");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
