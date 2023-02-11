using NUnit.Framework;
using RestSharp;
using System.Net;
using System.Threading.Tasks;

namespace FinboaAPITestAutomation
{
    [TestFixture]
    class TestWorkflowSetupAPI
    {
        RestClient restClient = null;

        [OneTimeSetUp]
        public void Setup()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();
        }

        [Test]
        public async Task Test_Get_Worklfow_on_Workflow_Setup_Page()
        {
            var request = HelperFunctions.CreateGetRequest("api/workflow");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
