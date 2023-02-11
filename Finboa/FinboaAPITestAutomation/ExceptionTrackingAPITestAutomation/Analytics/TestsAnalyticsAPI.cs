using FinboaAPITestAutomation;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using RestSharp.Authenticators;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace ExceptionTrackingAPITestAutomation.Analytics
{
    [TestFixture]
    public class TestsAnalyticsAPI
    {
        [Test]
        public async Task Test001_Get_FinboaDashBoardHTML_On_Login_Page()
        {
            var restClient = HelperFunctions.InitializeFinboaAccountV3Client();
            restClient.Authenticator = new JwtAuthenticator(TestLoginAPI.ETAccessToken);
            var request = HelperFunctions.CreateGetRequest("finboamodules/FINBOADashboard/finboaDashboard.html");
            var response = await restClient.ExecuteAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
        [Test]
        public async Task Test002_Get_BarsLabelJS_On_Analytics_Page()
        {
            var restClient = HelperFunctions.InitializeFinboaAccountV3Client();
            var request = HelperFunctions.CreateGetRequest("finboamodules/FINBOADashboard/js/bars-label.js");
            var response = await restClient.ExecuteAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
        [Test]
        public async Task Test003_Get_TabJS_On_Analytics_Page()
        {
            var restClient = HelperFunctions.InitializeFinboaAccountV3Client();
            var request = HelperFunctions.CreateGetRequest("finboamodules/FINBOADashboard/js/tabs.js");
            var response = await restClient.ExecuteAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test004_Post_FilterExceptions_On_Analytics_Page()
        {

            var restClient = HelperFunctions.InitializeFinboaAccountAPIV3Client();
            restClient.Authenticator = new JwtAuthenticator(TestLoginAPI.ETAccessToken);
            var request = HelperFunctions.CreatePostRequest("api/dashboard/exceptions");
            request.AddParameter("EndDate", "10/01/2022");
            request.AddParameter("StartDate", "07/01/2022");
            var response = await restClient.ExecuteAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            var exceptionData = JsonConvert.DeserializeObject<List<ExceptionTrackingEntities.ExceptionsOnAnalytics>>(response.Content);
        }
    }
}
