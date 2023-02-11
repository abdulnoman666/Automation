using NUnit.Framework;
using RestSharp;
using System.Net;
using System.Threading.Tasks;

namespace FinboaAPITestAutomation
{
    [TestFixture]
    class TestLedgerAPI
    {
        RestClient restClient = null;

        [Test]
        public async Task Test_Get_Ledger_On_Daily_Ledger_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/ledger");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Ledger_Page_On_Daily_Ledger_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/glledger/ledger.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Monthly_Ledger_Report_On_Ledger_Report_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/glledger/monthlyledgerreports.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Update_Date_On_GL_Ledger_Tab_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/ledger/updatedate");

            request.AddJsonBody(new
            {
                accountDefinitionId = 1,
                amount = 100,
                baseAccountId = 2,
                companyId = 2,
                createdBy = 46,
                createdOn = "2022-10-08",
                customerDisputeId = 3543,
                customerId = 2,
                disputeId = 0,
                id = 2508,
                posted = false,
                transactionCode = "4040",
                transactionDate = "2022-10-11",
                transactionType = "Credit"
            });

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Save_GL_Entry_On_GL_Ledger_Tab_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/customerdispute/3543/saveglentry");

            request.AddJsonBody(new
            {
                accountDefinitionId = 7,
                amount = 250,
                transactionType = "Debit"
            });

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Print_Ledger_Report_Detail_On_Ledger_Report_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/ledger/101/viewletterbyid");

            request.AddJsonBody(new
            {
                end = "2022-10-30",
                start = "2022-09-30",
            });

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]  
        public async Task Test_Post_Print_Ledger_Report_On_Ledger_Report_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/ledger/67/viewletterbyid");

            request.AddJsonBody(new
            {
                end = "2022-10-30",
                start = "2022-09-30",
            });

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Delete_GL_Entry_On_GL_Ledger_Tab_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/customerdispute/3543/saveglentry");

            var accountDefinitionId = 7;
            var amount = 250;
            var transactionType = "Debit";

            request.AddJsonBody(new
            {
                accountDefinitionId,
                amount,
                transactionType
            });

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = HelperFunctions.DeserializeResponseToJson(response);

            var id = output["id"];
            var baseAccountId = output["baseAccountId"];
            var companyId = output["companyId"];
            var createdBy = output["createdBy"];
            var createdOn = output["createdOn"];
            var customerDisputeId = output["customerDisputeId"];
            var customerId = output["customerId"];
            var disputeId = output["customerId"];
            var posted = output["posted"];
            var transactionCode = output["transactionCode"];
            var transactionDate = output["transactionDate"];

            var request2 = HelperFunctions.CreatePostRequest("api/ledger/deleteentry");

            request2.AddJsonBody(new
            {
                accountDefinitionId,
                amount,
                baseAccountId,
                companyId,
                createdBy,
                createdOn,
                customerDisputeId,
                customerId,
                disputeId,
                id,
                posted,
                transactionCode,
                transactionDate,
                transactionType
            });

            var response2 = await restClient.ExecuteAsync(request2);

            Assert.That(response2.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
