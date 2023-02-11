using NUnit.Framework;
using RestSharp;
using RestSharp.Authenticators;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace FinboaAPITestAutomation
{
    [TestFixture]
    public class TestDashboardAPI
    {
        RestClient restClient = null;

        [OneTimeSetUp]
        public void Setup()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();
        }

        [Test]
        public async Task Test_Get_App_User_Bundle_On_Dashboard_Page()
        {
            var request = HelperFunctions.CreateGetRequest("api/bundle/appuserbundle");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

        }

        [Test]
        public async Task Test_Get_Workflow_Setting_On_Dashboard_Page()
        {
            var request = HelperFunctions.CreateGetRequest("api/workflowsetting");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_AnitForgery_Token_On_Dashboard_Page()
        {
            var request = HelperFunctions.CreateGetRequest("antiforgerytoken");

            /*var header = $"Bearer {TestLoginAPI.AccessToken}";

            restClient.Authenticator = new JwtAuthenticator(header);*/

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = HelperFunctions.DeserializeResponseToJson(response);

            Assert.That(output["AntiForgeryToken"].Length, Is.GreaterThanOrEqualTo(92));
        }

        [Test]
        public async Task Test_Get_init_Bundle_On_Dashboard_Page()
        {
            var request = HelperFunctions.CreateGetRequest("api/bundle/initbundle");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Dispute_Status_On_Dashboard_Page()
        {
            var request = HelperFunctions.CreateGetRequest("api/dashboard/disputestatus");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Bank_Loss_Total_By_Year_On_Dashboard_Page()
        {
            var request = HelperFunctions.CreateGetRequest("api/dashboard/banklosstotalbyyear");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Dispute_Resolution_Count_On_Dashboard_Page()
        {
            var request = HelperFunctions.CreateGetRequest("api/dashboard/disputeresolutioncount");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Dispute_Resolution_Total_On_Dashboard_Page()
        {
            var request = HelperFunctions.CreateGetRequest("api/dashboard/disputeresolutiontotal");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Trends_On_Dashboard_Page()
        {
            var request = HelperFunctions.CreateGetRequest("api/dashboard/trends");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Alerts_On_Dashboard_Page()
        {
            var request = HelperFunctions.CreateGetRequest("api/company/alerts");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Company_Settings_On_Dashboard_Page()
        {
            var request = HelperFunctions.CreateGetRequest("api/companysetting");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            //var output = HelperFunctions.DeserializeResponseToJson(response);

            //Assert.That(output.Count, Is.EqualTo(15));
        }

        [Test]
        public async Task Test_Get_Users_On_Dashboard_Page()
        {
            var request = HelperFunctions.CreateGetRequest("api/company/users");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Dispute_Alerts_On_Dashboard_Page()
        {
            var request = HelperFunctions.CreateGetRequest("api/customerdispute/alerts");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Custom_View_On_Dashboard_Page()
        {
            var request = HelperFunctions.CreateGetRequest("api/customview");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}