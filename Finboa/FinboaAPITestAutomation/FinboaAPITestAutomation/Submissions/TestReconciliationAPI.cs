using NUnit.Framework;
using RestSharp;
using RestSharp.Authenticators;
using System.Net;
using System.Threading.Tasks;

namespace FinboaAPITestAutomation
{
    [TestFixture]
    class TestReconciliationAPI
    {
        RestClient restClient = null;

        [OneTimeSetUp]
        public void Setup()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();
        }


        [Test]
        public async Task Test_Reconcilliation_On_Activity_History_Page()
        {
            var request = HelperFunctions.CreateGetRequest("api/recon");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Reconcilliation_List_On_Reconcilliation_Page()
        {
            var restClient2 = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/recon/reconlist.html");

            var response = await restClient2.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Recon_On_Reconcilliation_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/recon");

            request = RequestHelper.CreateReconRequest(request, 50, 2, "Dheeraj Singal", 2409, 1, 0, 100, 100, 100, 0 , "2020-03-03",
                "Debit Card", "Customer Acknowledged", 500);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
