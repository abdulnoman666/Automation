using NUnit.Framework;
using RestSharp;
using System.Net;
using System.Threading.Tasks;

namespace FinboaAPITestAutomation
{
    [TestFixture]
    class TestCycleCodeMapAPI
    {
        RestClient restClient = null;
        string id = string.Empty;

        [Test]
        public async Task Test_Get_Cycle_Code_Map_On_Cycle_Code_Map_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/cyclecodemap");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(1)]
        public async Task Test_Post_Add_Cycle_Code_Map_On_Cycle_Code_Map_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/cyclecodemap");

            request.AddParameter("cycleCode", "EDP");
            request.AddParameter("cycleCodeString", "EOD");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = HelperFunctions.DeserializeResponseToJson(response);

            id = output["id"];
        }

        [Test, Order(2)]
        public async Task Test_Post_Delete_Cycle_Code_Map_On_Cycle_Code_Map_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();
            
            await DeleteCycleCodeMap(id);
        }

        private async Task DeleteCycleCodeMap(string id)
        {
            var request = HelperFunctions.CreatePostRequest($"api/cyclecodemap/{id}/delete");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(3)]
        public async Task Test_Post_Update_Cycle_Code_Map_On_Cycle_Code_Map_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var aRequest = HelperFunctions.CreatePostRequest("api/cyclecodemap");

            aRequest.AddParameter("cycleCode", "EDP");
            aRequest.AddParameter("cycleCodeString", "EOD");

            var aResponse = await restClient.ExecuteAsync(aRequest);

            Assert.That(aResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var aOutput = HelperFunctions.DeserializeResponseToJson(aResponse);

            var aId = aOutput["id"];
            var aCompanyId = aOutput["companyId"];
            var aCreatedOn = aOutput["createdOn"];
            var aCycleCode = aOutput["cycleCode"];
            var aCycleCodeString = aOutput["cycleCodeString"];

            var mRequest = HelperFunctions.CreatePostRequest("api/cyclecodemap");

            mRequest.AddParameter("companyId", aCompanyId);
            mRequest.AddParameter("createdOn", aCreatedOn);
            mRequest.AddParameter("cycleCode", aCycleCode);
            mRequest.AddParameter("cycleCodeString", aCycleCodeString);
            mRequest.AddParameter("id", aId);

            var eResponse = await restClient.ExecuteAsync(mRequest);

            Assert.That(eResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var eOutput = HelperFunctions.DeserializeResponseToJson(eResponse);

            Assert.That(eOutput["cycleCode"], Is.EqualTo(aCycleCode), "Cycle Code does not match");
            Assert.That(eOutput["cycleCodeString"], Is.EqualTo(aCycleCodeString), "Cycle Code String does not match");

            await DeleteCycleCodeMap(aId);
        }


        [Test]
        public async Task Test_Get_Cycle_Code_Map_List_On_Cycle_Code_Map_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/settings/cyclecodemaplist.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
