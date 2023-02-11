using NUnit.Framework;
using RestSharp;
using System.Net;
using System.Threading.Tasks;

namespace FinboaAPITestAutomation
{
    [TestFixture]
    class TestBankHolidaysAPI
    {
        RestClient restClient = null;
        string id = string.Empty;
        string companyId = string.Empty;
        string holiday = string.Empty;

        [Test]
        public async Task Test_Get_Bank_Holidays_On_Bank_Holidays_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/bankholiday");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(1)]
        public async Task Test_Post_Bank_Holidays_On_Bank_Holidays_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/bankholiday");

            request.AddParameter("holiday", "Sat Jan 07 2023");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = HelperFunctions.DeserializeResponseToJson(response);

            id = output["id"];
            holiday = output["holiday"];
            companyId = output["companyId"];
        }

        [Test, Order(2)]
        public async Task Test_Post_Delete_Bank_Holidays_On_Bank_Holidays_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest($"api/bankholiday/{id}/delete");

            request.AddParameter("holiday", holiday);
            request.AddParameter("companyId", companyId);
            request.AddParameter("id", id);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Bank_Holidays_Page_On_Bank_Holidays_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/settings/bankholidays.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
