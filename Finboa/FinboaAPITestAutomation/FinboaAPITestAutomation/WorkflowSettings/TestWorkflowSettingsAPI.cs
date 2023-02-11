using Gherkin.CucumberMessages.Types;
using NUnit.Framework;
using RestSharp;
using System.Net;
using System.Threading.Tasks;

namespace FinboaAPITestAutomation
{
    [TestFixture]
    class TestWorkflowSettingsAPI
    {
        RestClient restClient = null;
        string workflowName = "Automated Workflow";
        string triggerName = "Trigger Name";
        string triggerEventType = "Trigger Event Type";
        string automationReference = "CFRECL";
        string emailTemplateReference = "EMAILT1";
        string glReference = "PCWO";
        string templateReference = "PCLPD";
        string emailDistributionList = "noman.software@yahoo.com, abdul@finboa.com";
        string accountTypeRestriction = "1";
        bool trueFlag = true;
        bool falseFlag = false;
        string accountSearchCondition = "DDA, SAV";
        string automationReferenceSubmissionComplete = "CFRECL";
        string confirmationEmailTemplateReference = "PCLPD";
        string customerDescription = "Debit Card";
        string disputeScreenType = "Default";
        int electronicConsentLetterId = 66;
        string feeTransactionCode = "50";
        int letterId = 73;
        string merchantCopySource = "Closed";
        string pcDays = "15";
        string resolutionDays = "10";
        string searchBy = "Card";
        string source = "Automated Workflow";
        string transactionNotAllowedCondition = "tran.payee.indexOf('ISA FEE') == -1 &amp;&amp; tran.payee.indexOf('Out of Network Fee') == -1";
        string transactionSearchCondition = "tran.transactionCode === '58'";
        string transactionType = "Default";
        string verbiageFraud = "Fraud";
        string verbiageNonFraud = "Non Fraud";
        string closedAccountCondition = "Closed";
        string complianceRegulationScreen = "RegE";
        string id = string.Empty;
        string companyID = string.Empty;
        string triggerId = string.Empty;

        [Test]
        public async Task Test_Get_Worklfow_on_Workflow_Settings_Page()
        {
            var restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/workflow");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Screen_Templates_on_Workflow_Settings_Page()
        {
            var restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/screentemplate");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(2)]
        public async Task Test_Post_Trigger_Type_on_Workflow_Settings_Page()
        {
            var restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/eventtrigger");

            request = RequestHelper.CreateTriggerRequest(request, accountTypeRestriction, trueFlag, trueFlag, automationReference, trueFlag, emailDistributionList, trueFlag, emailTemplateReference, glReference, trueFlag, trueFlag, automationReference, templateReference, trueFlag, triggerEventType, triggerName, workflowName);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = HelperFunctions.DeserializeResponseToJson(response);

            triggerId = output["id"];
        }

        [Test, Order(3)]
        public async Task Test_Delete_Trigger_Type_on_Workflow_Settings_Page()
        {
            var restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateDeleteRequest($"api/eventtrigger/{triggerId}");

            request = RequestHelper.CreateTriggerRequest(request, accountTypeRestriction, trueFlag, trueFlag, automationReference, trueFlag, emailDistributionList, trueFlag, emailTemplateReference, glReference, trueFlag, trueFlag, automationReference, templateReference, trueFlag, triggerEventType, triggerName, workflowName);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Workflow_Name_Trigger_Type_on_Workflow_Settings_Page()
        {
            var restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest($"api/eventtrigger/workflow/{workflowName}");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Workflow_Settings_on_Workflow_Settings_Page()
        {
            var restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/workflowsetting");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Worklfow_Settings_on_Workflow_Settings_Page()
        {
            var restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/settings/workflowsettings.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test, Order(1)]
        public async Task Test_Post_Worklfow_Settings_on_Workflow_Settings_Page()
        {
            var restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("https://disputedevapi.azurewebsites.net/api/workflowsetting");

            request.AddParameter("accountSearchCondition", accountSearchCondition);
            request.AddParameter("addTransactions", trueFlag);
            request.AddParameter("allowManualTransactions", trueFlag);
            request.AddParameter("autoFeeReimbursement", trueFlag);
            request.AddParameter("automationReferenceSubmissionComplete", automationReference);
            request.AddParameter("closedAccountCondition", closedAccountCondition);
            request.AddParameter("complianceRegulationScreen", complianceRegulationScreen);
            request.AddParameter("confirmationAutomationReference", automationReference);
            request.AddParameter("confirmationEmailTemplateReference", emailTemplateReference);
            request.AddParameter("copyTransactions", trueFlag);
            request.AddParameter("customerAccess", trueFlag);
            request.AddParameter("customerDescription", customerDescription);
            request.AddParameter("customerType", trueFlag);
            request.AddParameter("disableCustomerNameEdit", trueFlag);
            request.AddParameter("disputeScreenType", disputeScreenType);
            request.AddParameter("distributionList", emailDistributionList);
            request.AddParameter("electronicConsentLetterId", electronicConsentLetterId);
            request.AddParameter("emailTemplateReference", emailTemplateReference);
            request.AddParameter("enableCloseScreenMessage", trueFlag);
            request.AddParameter("feeGLReference", glReference);
            request.AddParameter("feeTransactionCode", feeTransactionCode);
            request.AddParameter("fraudNonFraud", trueFlag);
            request.AddParameter("hasQuestionnaire", trueFlag);
            request.AddParameter("hideCommentsAndResolutionField", trueFlag);
            request.AddParameter("hideCustomerAcknowledgementForm", trueFlag);
            request.AddParameter("hideSendToCustomer", trueFlag);
            request.AddParameter("interestPostingGLReference", glReference);
            request.AddParameter("letterId", letterId);
            request.AddParameter("merchantCopySource", merchantCopySource);
            request.AddParameter("pcBusinessDays", trueFlag);
            request.AddParameter("pcDays", pcDays);
            request.AddParameter("populateMerchantField", trueFlag);
            request.AddParameter("provisionalCreditCalc", trueFlag);
            request.AddParameter("publish", trueFlag);
            request.AddParameter("readOnlyQuestionnaire", trueFlag);
            request.AddParameter("resolutionBusinessDays", falseFlag);
            request.AddParameter("resolutionDays", resolutionDays);
            request.AddParameter("resolutionLastBusinessDay", trueFlag);
            request.AddParameter("searchBy", searchBy);
            request.AddParameter("sendNotifications", trueFlag);
            request.AddParameter("source", source);
            request.AddParameter("transactionNotAllowedCondition", transactionNotAllowedCondition);
            request.AddParameter("transactionSearchCondition", transactionSearchCondition);
            request.AddParameter("transactionType", transactionType);
            request.AddParameter("verbiageFraud", verbiageFraud);
            request.AddParameter("verbiageNonFraud", verbiageNonFraud);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = HelperFunctions.DeserializeResponseToJson(response);
            id = output["id"];
            companyID = output["companyId"];
        }

        [Test, Order(4)]
        public async Task Test_Post_Delete_Worklfow_Settings_on_Workflow_Settings_Page()
        {
            var restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest($"api/workflowsetting/{id}/delete");

            request.AddParameter("accountSearchCondition", accountSearchCondition);
            request.AddParameter("addTransactions", trueFlag);
            request.AddParameter("allowManualTransactions", trueFlag);
            request.AddParameter("altResolutionDays", 0); // not present in the add workflow setting payload
            request.AddParameter("autoFeeReimbursement", trueFlag);
            request.AddParameter("automationReferenceSubmissionComplete", automationReference);
            request.AddParameter("byTransaction", "false");//not present in the add workflow setting payload
            request.AddParameter("closedAccountCondition", closedAccountCondition);
            request.AddParameter("companyId", companyID);
            request.AddParameter("complianceRegulationScreen", complianceRegulationScreen);
            request.AddParameter("confirmationAutomationReference", automationReference);
            request.AddParameter("confirmationEmailTemplateReference", emailTemplateReference);
            request.AddParameter("copyTransactions", trueFlag);
            request.AddParameter("customerAccess", trueFlag);
            request.AddParameter("customerDescription", customerDescription);
            request.AddParameter("customerType", trueFlag);
            request.AddParameter("disableCustomerNameEdit", trueFlag);
            request.AddParameter("disputeScreenType", disputeScreenType);
            request.AddParameter("distributionList", emailDistributionList);
            request.AddParameter("electronicConsentLetterId", electronicConsentLetterId);
            request.AddParameter("emailTemplateReference", emailTemplateReference);
            request.AddParameter("enableCloseScreenMessage", trueFlag);
            request.AddParameter("eventNotifications", "");// not present in the add workflow setting payload
            request.AddParameter("feeGLReference", glReference);
            request.AddParameter("feeTransactionCode", feeTransactionCode);
            request.AddParameter("fraudNonFraud", trueFlag);
            request.AddParameter("hasQuestionnaire", trueFlag);
            request.AddParameter("hideCommentsAndResolutionField", trueFlag);
            request.AddParameter("hideCustomerAcknowledgementForm", trueFlag);
            request.AddParameter("hideSendToCustomer", trueFlag);
            request.AddParameter("id", id);
            request.AddParameter("interestPostingGLReference", glReference);
            request.AddParameter("letterDataCondition", "");// not present in the add workflow setting payload
            request.AddParameter("letterId", letterId);
            request.AddParameter("merchantCopySource", merchantCopySource);
            request.AddParameter("pcBusinessDays", trueFlag);
            request.AddParameter("pcDays", pcDays);
            request.AddParameter("populateMerchantField", trueFlag);
            request.AddParameter("provisionalCreditCalc", trueFlag);
            request.AddParameter("publish", trueFlag);
            request.AddParameter("readOnlyQuestionnaire", trueFlag);
            request.AddParameter("resolutionBusinessDays", falseFlag);
            request.AddParameter("resolutionDays", resolutionDays);// different header
            request.AddParameter("resolutionLastBusinessDay", trueFlag);
            request.AddParameter("screenTemplateReference", ""); //not present in the add workflow setting payload
            request.AddParameter("searchBy", searchBy);
            request.AddParameter("sendNotifications", trueFlag);
            request.AddParameter("source", source);
            request.AddParameter("statusList", "");
            request.AddParameter("transactionNotAllowedCondition", transactionNotAllowedCondition);
            request.AddParameter("transactionSearchCondition", transactionSearchCondition);
            request.AddParameter("transactionType", transactionType);
            request.AddParameter("useCardHolderNameforBusiness", falseFlag); //not present in the add workflow setting payload
            request.AddParameter("useOnlineContent", falseFlag); //not present in the add workflow setting payload
            request.AddParameter("verbiageFraud", verbiageFraud);
            request.AddParameter("verbiageNonFraud", verbiageNonFraud);

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

    }
}
