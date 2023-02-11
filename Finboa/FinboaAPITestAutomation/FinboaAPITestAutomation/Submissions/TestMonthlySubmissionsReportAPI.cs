using NUnit.Framework;
using RestSharp;
using System.Net;
using System.Threading.Tasks;

namespace FinboaAPITestAutomation
{
    class TestMonthlySubmissionsReportAPI
    {
        RestClient restClient = null;

        [Test]
        public async Task Test_Monthly_Submission_Report_On_Monthly_Submission_Report_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/reporting/monthlysubmissionreports.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Monthly_Submission_Report_On_Monthly_Submission_Report_Page()
        {
            var restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/company/generateexporttask");

            request = HelperFunctions.AddParametersInRequest(request, "reportedOnDateEnd", "10/31/2022");
            request = HelperFunctions.AddParametersInRequest(request, "reportedOnDateStart", "10/1/2022");
            request = HelperFunctions.AddParametersInRequest(request, "searchField", "ReportedOn");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
