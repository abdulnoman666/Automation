using NUnit.Framework;
using RestSharp;
using System.Net;
using System.Threading.Tasks;

namespace FinboaAPITestAutomation
{
    [TestFixture]
    internal class TestLedgerBatches
    {
        RestClient restClient = null;

        [Test]
        public async Task Test_Get_Monthly_Ledger_Batches_On_Ledger_Batches_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/glledger/monthlyledgerbatches.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Print_Report_On_Ledger_Batches_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/directivehtml/printreport.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Ledger_Entry_Batches_On_Ledger_Batches_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/ledgerentrybatch");

            request.AddParameter("end", "2023-01-30T19:00:00.000Z");
            request.AddParameter("id", 0);
            request.AddParameter("start", "2022-01-31T19:00:00.000Z");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Generate_Export_Task_On_Ledger_Batches_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/ledger/generateexporttask");

            request.AddParameter("end", "2023-01-30T19:00:00.000Z");
            request.AddParameter("id", 0);
            request.AddParameter("start", "2022-01-31T19:00:00.000Z");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
