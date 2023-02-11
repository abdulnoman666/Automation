using NUnit.Framework;
using RestSharp;
using System.Net;
using System.Threading.Tasks;

namespace FinboaAPITestAutomation
{
    class TestProvisionalCreditAPI
    {
        RestClient restClient = null;

        [Test]
        public async Task Test_Get_Customer_Dispute_On_Provisional_Credit_Calculation_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/customerdispute/3496");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Provisional_Credit_On_Provisional_Credit_Calculation_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/provisionalcredit.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
