using NUnit.Framework;
using RestSharp;
using System.Net;
using System.Threading.Tasks;

namespace FinboaAPITestAutomation
{
    class TestResetSubmissionAPI
    {

        [Test]
        public async Task Test_Reverse_PC_On_Reset_Submission_Page()
        {
            var restClient2 = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/settings/reversepc.html");

            var response = await restClient2.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Reset_Submission_On_Reset_Submission_Page()
        {
            var restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/customerdispute/3539/reversepc");

            request = HelperFunctions.AddParametersInRequest(request, "disputeid", "3539");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
