using NUnit.Framework;
using RestSharp;
using System.Net;
using System.Threading.Tasks;

namespace FinboaAPITestAutomation
{
    class TestErrorLogAPI
    {
        RestClient restClient = null;

        [Test]
        public async Task Test_Get_Error_Logs_On_Error_Log()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/settings/errorlogs.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Finboa_Error_Logs_On_Error_Logs()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/finboaclienterrorlog/search");

            request.AddParameter("reportedOnDateEnd", "2022-10-31");
            request.AddParameter("reportedOnDateStart", "2022-05-31");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
