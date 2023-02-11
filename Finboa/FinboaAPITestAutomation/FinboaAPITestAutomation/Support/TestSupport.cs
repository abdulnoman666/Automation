using NUnit.Framework;
using RestSharp;
using RestSharp.Authenticators;
using System.Net;
using System.Threading.Tasks;

namespace FinboaAPITestAutomation
{
    [TestFixture]
    class TestSupport
    {
        private RestClient restClient;

        [OneTimeSetUp]
        public void Setup()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();
        }

        [Test]
        public async Task Test_Get_Support_On_Support_Page()
        {
            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/support.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Support_Tickets_On_Support_Page()
        {
            var request = HelperFunctions.CreateGetRequest("finboamodules/FINBOASupport/supportTickets.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Customer_Tickets_On_Support_Page()
        {
            var restClient = new RestClient("https://finboasupportapi.azurewebsites.net");

            restClient.Authenticator = new JwtAuthenticator(TestLoginAPI.AccessToken);

            var request = HelperFunctions.CreatePostRequest("api/case/2/customertickets");

            request.AddParameter("emailFrom", "abdul@finboa.com");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Submit_Support_Ticket_Popup_On_Support_Page()
        {
            var restClient = new RestClient("https://disputedev.azurewebsites.net");

            restClient.Authenticator = new JwtAuthenticator(TestLoginAPI.AccessToken);

            var request = HelperFunctions.CreateGetRequest("finboamodules/FINBOASupport/submitSupportTicketPopup.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
