using NUnit.Framework;
using RestSharp;
using System.Net;
using System.Threading.Tasks;

namespace FinboaAPITestAutomation
{
    [TestFixture]
    class TestGLDefinitionAPI
    {
        RestClient restClient = null;
        string account = string.Empty;
        string accountOwnershipType = string.Empty;
        string accountType = string.Empty;
        string baseAccountId = string.Empty;
        string branchCode = string.Empty;
        string companyId = string.Empty;
        string description = string.Empty;
        string glBranchCode = string.Empty;
        string glCode = string.Empty;
        string glCostCenter = string.Empty;
        string id = string.Empty;
        string isDeleted = string.Empty;
        string offsetDescription = string.Empty;
        string offsetTransactionCode = string.Empty;
        string reference = string.Empty;
        string source = string.Empty;
        string transactionCode = string.Empty;
        string transactionType = string.Empty;

        [Test, Order (1)]
        public async Task Test_Get_Account_Definition_On_GL_Definition_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/accountdefinition");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(1)]
        public async Task Test_Post_Add_Customer_Account_Definition_On_GL_Definition_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/accountdefinition");

            account = "2020";
            accountOwnershipType = "Business";
            accountType = "Customer";
            branchCode = "Branch 1";
            description = "Desc";
            glBranchCode = "5050";
            glCode = "3030";
            glCostCenter = "6060";
            offsetDescription = "desc";
            offsetTransactionCode = "4040";
            reference = "REF";
            source = "Debit Card";
            transactionCode = "1010";
            transactionType = "Credit";

            request.AddParameter("account", account);
            request.AddParameter("accountOwnershipType", accountOwnershipType);
            request.AddParameter("accountType", accountType);
            request.AddParameter("branchCode", branchCode);
            request.AddParameter("description", description);
            request.AddParameter("glBranchCode", glBranchCode);
            request.AddParameter("glCode", glCode);
            request.AddParameter("glCostCenter", glCostCenter);
            request.AddParameter("offsetDescription", offsetDescription);
            request.AddParameter("offsetTransactionCode", offsetTransactionCode);
            request.AddParameter("reference", reference);
            request.AddParameter("source", source);
            request.AddParameter("transactionCode", transactionCode);
            request.AddParameter("transactionType", transactionType);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = HelperFunctions.DeserializeResponseToJson(response);

            account = output["account"];
            accountOwnershipType = output["accountOwnershipType"];
            accountType = output["accountType"];
            baseAccountId = output["baseAccountId"];
            branchCode = output["branchCode"];
            companyId = output["companyId"];
            description = output["description"];
            glBranchCode = output["glBranchCode"];
            glCode = output["glCode"];
            glCostCenter = output["glCostCenter"];
            id = output["id"];
            isDeleted = output["isDeleted"];
            offsetDescription = output["offsetDescription"];
            offsetTransactionCode = output["offsetTransactionCode"];
            reference = output["reference"];
            source = output["source"];
            transactionCode = output["transactionCode"];
            transactionType = output["transactionType"];
        }

        [Test, Order(2)]
        public async Task Test_Post_Delete_Customer_Account_Definition_On_GL_Definition_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/accountdefinition");

            request.AddParameter("account", account);
            request.AddParameter("accountOwnershipType", accountOwnershipType);
            request.AddParameter("accountType", accountType);
            request.AddParameter("baseAccountId", baseAccountId);
            request.AddParameter("branchCode", branchCode);
            request.AddParameter("companyId", companyId);
            request.AddParameter("description", description);
            request.AddParameter("glBranchCode", glBranchCode);
            request.AddParameter("glCode", glCode);
            request.AddParameter("glCostCenter", glCostCenter);
            request.AddParameter("id", id);
            request.AddParameter("isDeleted", true);
            request.AddParameter("offsetDescription", offsetDescription);
            request.AddParameter("offsetTransactionCode", offsetTransactionCode);
            request.AddParameter("reference", reference);
            request.AddParameter("source", source);
            request.AddParameter("transactionCode", transactionCode);
            request.AddParameter("transactionType", transactionType);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            }

        [Test]
        public async Task Test_Get_GL_Accounts_On_GL_Definition_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/settings/glaccounts.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_GL_Account_Definition_On_GL_Definition_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/directivehtml/glAccountDefinition.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Upload_GL_Definition_Popup_On_GL_Definition_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("finboamodules/FINBOASolutionLibrary/uploadGlDefinitionPopup.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
