using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace FinboaAPITestAutomation
{
    [TestFixture]
    class TestTransactionProcessesAPI
    {
        RestClient restClient = null;
        int lastID = 0;

        [Test, Order(2)]
        public async Task Test_Get_Transaction_Processes_on_Transaction_Processes_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/transactionprocess");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var transactionProcessesData = JsonConvert.DeserializeObject<List<TransactionProcesses.TransactionProcess>>(response.Content);
            var tCount = transactionProcessesData.Count;
            lastID = transactionProcessesData[tCount - 1].Id;
        }

        [Test, Order(1)]
        public async Task Test_Post_Create_Transaction_Processes_On_Transaction_Processes_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/transactionprocess");

            request.AddParameter("description", "Transaction Processes");
            request.AddParameter("glReference", "PCWO");
            request.AddParameter("processType", "Provisional Credit");
            request.AddParameter("workflowIds", 8);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(3)]
        public async Task Test_Delete_Transaction_Processes_On_Transaction_Processes_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateDeleteRequest($"api/transactionprocess/{lastID}");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
