using NUnit.Framework;
using RestSharp;
using System.Net;
using System.Threading.Tasks;

namespace FinboaAPITestAutomation
{
    [TestFixture]
    class TestCompanySettings
    {
        RestClient restClient = null;

        [Test]
        public async Task Test_Get_Company_Settings_On_Company_Settings_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/companysetting");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Company_Settings_On_Company_Settings_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/companysetting");

            request.AddParameter("auditEnd", "2022-12-31T21:00:00");
            request.AddParameter("auditStart", "2022-01-01T17:00:00");
            request.AddParameter("companyId", "2");
            request.AddParameter("dailyGLCutOff", "4:00 PM");
            request.AddParameter("hideAddress2", true);
            request.AddParameter("hideAddress3", true);
            request.AddParameter("hideAddress4", true);
            request.AddParameter("hideCity", true);
            request.AddParameter("hideState", true);
            request.AddParameter("hideZip", true);
            request.AddParameter("id", "2");
            request.AddParameter("pcDays", "15");
            request.AddParameter("post7Days", true);
            request.AddParameter("postOnSaturdays", true);
            request.AddParameter("useLastBusinessDay", true);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Company_Settings_Page_on_Company_Settings_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/settings/companysettings.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
