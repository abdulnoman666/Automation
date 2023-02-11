using NUnit.Framework;
using RestSharp;
using System.Net;
using System.Threading.Tasks;

namespace FinboaAPITestAutomation
{
    class TestDeleteSubmissionAPI
    {
        /*RestClient restClient = null;

        [OneTimeSetUp]
        public void Setup()
        {
            restClient = HelperFunctions.InitializeRestClient();
        }*/

        [Test]
        public async Task Test_Delete_Dispute_On_Delete_Submission_Page()
        {
            var restClient2 = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/settings/deletedispute.html");

            var response = await restClient2.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
