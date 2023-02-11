using NUnit.Framework;
using RestSharp;
using System.Net;
using System.Threading.Tasks;

namespace FinboaAPITestAutomation
{
    class TestDisputesAPI
    {
        RestClient restClient = null;

        [Test]
        public async Task Test_Provisional_Credit_Log_On_Dispute_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/disputelists/pclog.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Auditor_Log_On_Dispute_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/disputelists/auditorlog.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Claim_Research_On_Disputes_Tab_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/dispute/claimresearch");

            request.AddJsonBody(new
            {
                accountType = 2,
                amountPreventedByFDS = 50,
                amountReceived = 0,
                assignedBy = 46,
                assignedOn = "2022-10-08",
                assignedTo = 46,
                batchNumber = 3543,
                camsCaseNumber = "123456789",
                cardPresent = false,
                caseReference = "10001",
                claimResult = 0,
                companyId = 2,
                consumerLiability = 0,
                createdOn = "2022-10-08",
                creditAmount = 5,
                creditDate = "2022-10-07",
                customerDisputeDescription = "deta",
                customerDisputeId = 0,
                customerEmail = "abdul@finboa.com",
                customerID = 0,
                customerName = "Dheeraj Singal",
                ddaCreditAmount = 0,
                ddaDebitAmount = 0,
                debitAmount = 10,
                disputeResolution = 0,
                disputeStatus = 2,
                disputeType = 1,
                foreignTransaction = false,
                id = 3507,
                isFee = false,
                merchantCreditAmount = 0,
                merchantName = "buje",
                pos = false,
                prearbCredit = 200,
                prearbDate = "2022-10-07",
                provisionalCredit = "2022-10-09",
                provisionalCreditAmount = 100,
                reportedOn = "2022-10-08",
                resolutionDeadline = "2022-11-22",
                reversalDate = "2022-10-07",
                source = "Debit Card",
                statementDate = "2022-10-21",
                transactionAmount = 50,
                transactionDate = "2022-10-08",
                transactionId = 4593,
                workflowId = 0,
            });

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Search_Dispute_List_On_Disputes_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/dispute/searchdisputelist");

            request.AddJsonBody(new
            {
                orderBy = "ReportedOn",
                orderDirection = true,
                reportedOnDateEnd = "2022-10-17",
                reportedOnDateStart = "2022-09-16",
                searchField = "ReportedOn"
            });

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
