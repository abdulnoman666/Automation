using FinboaAPITestAutomation;
using NUnit.Framework;
using RestSharp;
using RestSharp.Authenticators;
using System.Net;
using System.Threading.Tasks;

namespace ExceptionTrackingAPITestAutomation
{
    [TestFixture]
    class TestAlertAPI
    {
        RestClient restClient = null;

        [OneTimeSetUp]
        public void Setup()
        {
            restClient = HelperFunctions.InitializeFinboaAccountAPIV3Client();

            restClient.Authenticator = new JwtAuthenticator(TestLoginAPI.ETAccessToken);
        }

        [Test]
        public async Task Test_Get_Setting_On_Open_Items_Page()
        {
            var request = HelperFunctions.CreatePostRequest("api/finboaalert/alerts");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
