using NUnit.Framework;
using RestSharp;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace FinboaAPITestAutomation
{
    class TestCustomerSubmissionAPI
    {
        RestClient restClient = null;

        [Test]
        public async Task Test_Get_NavInstance_List_On_Customer_Submission_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("finboamodules/finboainstances/navinstanceslist.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_View_Customer_Dispute_On_Customer_Submission_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/viewcustomerdispute.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Contact_List_On_Customer_Submission_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("appmodules/casecontact/contactlist.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Finboa_Input_Form_Dropdown_On_Customer_Submission_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("finboamodules/FINBOAForms/finboainputformdropdown.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Finboa_Form_html_On_Customer_Submission_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("finboamodules/FINBOAForms/finboaformhtml.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Letter_List_On_Customer_Submission_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/directivehtml/letterlist.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Compliance_RegE_On_Customer_Submission_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/directivehtml/complianceRegE.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Compliance_RegZ_On_Customer_Submission_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/directivehtml/complianceRegZ.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Compliance_None_On_Customer_Submission_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/directivehtml/complianceNone.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Compliance_Nacha_On_Customer_Submission_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/directivehtml/complianceNacha.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Documents_On_Customer_Submission_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/document/documents.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_GL_Account_Definition_On_Customer_Submission_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/directivehtml/glAccountDefinition.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Dispute_Alert_On_Customer_Submission_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/workflow/dispute-alert.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Account_Definition_On_Customer_Submission_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/accountdefinition");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Finboa_Form_Button_On_Customer_Submission_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("finboamodules/FINBOAForms/finboaformbuttons.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Dispute_Docs_On_Customer_Submission_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/customerdispute/3496/disputedocs");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Bundle_Customer_Dispute_On_Customer_Submission_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/bundle/customerdispute/3496");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Alerts_On_Customer_Submission_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/company/alerts");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_PDF_Viewer_On_Customer_Submission_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/directivehtml/pdfviewer.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Dispute_List_On_Customer_Submission_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/customerdispute/3496/disputelist");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Case_Contact_On_Customer_Submission_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/casecontact/3496");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_GL_Entries_On_GL_Ledger_Tab_On_Customer_Submission_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/customerdispute/3500/glentries");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_GL_Transaction_Date_On_GL_Ledger_Tab_On_Customer_Submission_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/directivehtml/gltransactiondate.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_GL_History_Dialog_On_GL_Ledger_Tab_On_Customer_Submission_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevClient();

            var request = HelperFunctions.CreateGetRequest("backoffice/app/views/partials/history-dialog.html");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_History_On_Customer_Submission_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/customerdispute/3300/history");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Add_Case_Contact_On_Contacts_Tab_Page_On_Customer_Submission_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/casecontact");

            request.AddParameter("caseId", "3551");
            request.AddParameter("contactName", "API Test Automation");
            request.AddParameter("email", "noman.software@yahoo.com");
            request.AddParameter("phone", "0345166674");
            request.AddParameter("reference", "CL");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Update_Closed_On_Date_On_Submission_Info_Tab_Page_On_Customer_Submission_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/customerdispute/4027/updateclosedondate");

            request.AddBody("2023-01-26T19:00:00.000Z");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Update_Reported_On_Date_On_Submission_Info_Tab_Page_On_Customer_Submission_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/customerdispute/4027/updatereportedondate");

            request.AddBody("2023-01-26T19:00:00.000Z");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Update_Case_Status_On_Customer_Status_Tab_On_Customer_Submission_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/customerdispute/4027/updatecasestatus");

            request.AddParameter("account", "11223344");
            request.AddParameter("accountApplication", "");
            request.AddParameter("accountType", 2);
            request.AddParameter("accountTypeDescription", "");
            request.AddParameter("accountTypeString", "Personal");
            request.AddParameter("achOtherReason", "");
            request.AddParameter("acknowledged", false);
            request.AddParameter("acknowledgedDate", "2023-01-30T18:43:24.503Z");
            request.AddParameter("additionalComments", "");
            request.AddParameter("address", "202 Test Street # 302");
            request.AddParameter("address2", "");
            request.AddParameter("address3", "");
            request.AddParameter("address4", "Consumer");
            request.AddParameter("amountPreventedByFDS", "15");
            request.AddParameter("approvedProvisionalCredit", 0);
            request.AddParameter("assignedBy", 0);
            request.AddParameter("assignedByName", "");
            request.AddParameter("assignedOn", "");
            request.AddParameter("assignedTo", 0);
            request.AddParameter("assignedToName", "");
            request.AddParameter("accountForCreditingId", 0);
            request.AddParameter("accountTransactionId", 372);
            request.AddParameter("amount", 50);
            request.AddParameter("amountReceived", 0);
            request.AddParameter("category", "");
            request.AddParameter("checkDate", "");
            request.AddParameter("checkNo", "");
            request.AddParameter("completedOn", "");
            request.AddParameter("consumerLiablity", 0);
            request.AddParameter("coreTransactionRef", "28333020003134");
            request.AddParameter("customerDisputeId", 4027);
            request.AddParameter("deadline", "2023-02-09T18:42:55.617");
            request.AddParameter("denialReason", "");
            request.AddParameter("description", "Customer Charge");
            request.AddParameter("detail", "Test Transaction 24/01 - Nine");
            request.AddParameter("disputedAmount", 1);
            request.AddParameter("doNotSend", false);
            request.AddParameter("feeReference", "");
            request.AddParameter("finalCredit", 0);
            request.AddParameter("finalCreditDate", "");
            request.AddParameter("foreignTransaction", false);
            request.AddParameter("id", 5309);
            request.AddParameter("interestRate", 0);
            request.AddParameter("isDeleted", false);
            request.AddParameter("isFee", false);
            request.AddParameter("linkedFeeAccountTransactionId", 0);
            request.AddParameter("location", "");
            request.AddParameter("merchant", "Test Transaction 24/01 - Nine");
            request.AddParameter("merchantCredit", 0);
            request.AddParameter("parentAccountTransactionId", 0);
            request.AddParameter("payee", "");
            request.AddParameter("pos", false);
            request.AddParameter("posted", true);
            request.AddParameter("provisionalCredit", 0);
            request.AddParameter("statementDate", "2023-01-31T06:00:00");
            request.AddParameter("transactionDate", "2023-01-23T10:00:00");
            request.AddParameter("transactionType", 1);
            request.AddParameter("workflowId", 0);
            request.AddParameter("workflowName", "");
            request.AddParameter("awareRefundPolicy", "");
            request.AddParameter("baseAccountId", 190);
            request.AddParameter("baseCustomerId", 67);
            request.AddParameter("branch", "Test Branch");
            request.AddParameter("camsCaseNumber", "654");
            request.AddParameter("camsId", 0);
            request.AddParameter("camsReportDate", "");
            request.AddParameter("cancelNumberGiven", "");
            request.AddParameter("cardId", 0);
            request.AddParameter("cardInPossession", false);
            request.AddParameter("cardNumber", "1122334455667788");
            request.AddParameter("caseReference", "321");
            request.AddParameter("certifyLostStolenPrior", "");
            request.AddParameter("chargebackAmount", 25);
            request.AddParameter("chipCard", "");
            request.AddParameter("city", "PORT ST JOE");
            request.AddParameter("closedOn", "");
            request.AddParameter("companyId", 2);
            request.AddParameter("consumerLiability", 0);
            request.AddParameter("converted", false);
            request.AddParameter("convertedOn", "");
            request.AddParameter("coreCaseDate", "2023-01-31T01:48:00.000Z");
            request.AddParameter("coreCustomerID", "1122333");
            request.AddParameter("coreResolutionDate", "2023-01-31T01:48:00.000Z");
            request.AddParameter("countofDeniedDisputes", 0);
            request.AddParameter("countofDisputesWithMerchantCredit", 0);
            request.AddParameter("countofDisputeswithFinalDenialReason", 0);
            request.AddParameter("countofDisputeswithFinalDenialReasonandNoPC", 0);
            request.AddParameter("countofFinalCredit", 0);
            request.AddParameter("countofNoProvisionalCredit", 0);
            request.AddParameter("countofNoProvisionalCreditConvertedtoFinalCredit", 0);
            request.AddParameter("countofProvisionalCreditDeniedorMerchantCreditorConsumerLiability", 0);
            request.AddParameter("countofProvisionalCreditIssuedConvertedtoFinalCredit", 0);
            request.AddParameter("createdBy", 0);
            request.AddParameter("createdByName", "");
            request.AddParameter("createdOn", "2023-01-26T18:42:55.617");
            request.AddParameter("customerAccountType", "02");
            request.AddParameter("customerID", 250);
            request.AddParameter("customerName", "Amina Customer");
            request.AddParameter("dateAcknowledged", "");
            request.AddParameter("dateCreditExpected", "");
            request.AddParameter("dateDelivered", "");
            request.AddParameter("dateMerchandiseReceived", "");
            request.AddParameter("dateMerchandiseReturned", "");
            request.AddParameter("dateStolen", "");
            request.AddParameter("declineAmount", 0);
            request.AddParameter("declinedProvisionalCredit", 0);
            request.AddParameter("deliveryMethod", "");
            request.AddParameter("disputeCustomerStatus", 366);
            request.AddParameter("disputeDetail", "");
            request.AddParameter("disputeOption", 0);
            request.AddParameter("disputeOptionMerchantAuthorizedTransactionAmount", 0);
            request.AddParameter("disputeOptionMerchantAuthorizedTransactionDate", "");
            request.AddParameter("disputeReason", "test");
            request.AddParameter("disputeType", 2);
            request.AddParameter("disputeTypeString", "Non-Fraud");
            request.AddParameter("camsId", 0);
            request.AddParameter("companyId", 2);
            request.AddParameter("createdBy", 0);
            request.AddParameter("createdOn", "2023-01-26T18:43:27.86");
            request.AddParameter("customerDisputeId", 4027);
            request.AddParameter("customerId", 250);
            request.AddParameter("deleted", false);
            request.AddParameter("deletedOn", "");
            request.AddParameter("description", "Debit Card Dispute Form - EAD - 01-26-2023");
            request.AddParameter("disputeId", 0);
            request.AddParameter("documentName", "Debit Card Dispute Form");
            request.AddParameter("fullyQualifiedURL", "");
            request.AddParameter("id", 5265);
            request.AddParameter("letterId", 778);
            request.AddParameter("printDate", "2023-01-26T18:43:26.707");
            request.AddParameter("reference", "DCDFEAD");
            request.AddParameter("storagePath", "443a78a05cf94f3b92d384de855af257\\Debit Card Dispute Form");
            request.AddParameter("duplicateTransactionDate", "");
            request.AddParameter("duplicateTransactions", "");
            request.AddParameter("electronicConsent", true);
            request.AddParameter("electronicConsentDate", "2023-01-26T18:43:13.207");
            request.AddParameter("email", "benjamin@finboa.com");
            request.AddParameter("feeRefundDOCredited", "");
            request.AddParameter("feeRefundedAmount", 0);
            request.AddParameter("feeRefundingDODeadline", "");
            request.AddParameter("feeReversalAmount", 50);
            request.AddParameter("feeSelectionReference", "");
            request.AddParameter("finalCredit", 0);
            request.AddParameter("finalCreditDate", "2023-01-31T01:47:00.000Z");
            request.AddParameter("firstAmountReceived", 0);
            request.AddParameter("firstCheckDate", "");
            request.AddParameter("firstCheckNumber", "");
            request.AddParameter("firstDisputedAmount", 1);
            request.AddParameter("firstName", "Amina");
            request.AddParameter("firstPayee", "");
            request.AddParameter("accountForCreditingId", 0);
            request.AddParameter("accountTransactionId", 372);
            request.AddParameter("amount", 50);
            request.AddParameter("amountReceived", 0);
            request.AddParameter("category", "");
            request.AddParameter("checkDate", "");
            request.AddParameter("checkNo", "");
            request.AddParameter("completedOn", "");
            request.AddParameter("consumerLiablity", 0);
            request.AddParameter("coreTransactionRef", "28333020003134");
            request.AddParameter("customerDisputeId", 4027);
            request.AddParameter("deadline", "2023-02-09T18:42:55.617");
            request.AddParameter("denialReason", "");
            request.AddParameter("description", "Customer Charge");
            request.AddParameter("detail", "Test Transaction 24/01 - Nine");
            request.AddParameter("disputedAmount", 1);
            request.AddParameter("doNotSend", false);
            request.AddParameter("feeReference", "");
            request.AddParameter("finalCredit", 0);
            request.AddParameter("finalCreditDate", "");
            request.AddParameter("foreignTransaction", false);
            request.AddParameter("id", 5309);
            request.AddParameter("interestRate", 0);
            request.AddParameter("isDeleted", false);
            request.AddParameter("isFee", false);
            request.AddParameter("linkedFeeAccountTransactionId", 0);
            request.AddParameter("location", "");
            request.AddParameter("merchant", "Test Transaction 24/01 - Nine");
            request.AddParameter("merchantCredit", 0);
            request.AddParameter("parentAccountTransactionId", 0);
            request.AddParameter("payee", "");
            request.AddParameter("pos", false);
            request.AddParameter("posted", true);
            request.AddParameter("provisionalCredit", 0);
            request.AddParameter("statementDate", "2023-01-31T06:00:00");
            request.AddParameter("transactionDate", "2023-01-23T10:00:00");
            request.AddParameter("transactionType", 1);
            request.AddParameter("workflowId", 0);
            request.AddParameter("workflowName", "");
            request.AddParameter("firstTransactionAmount", 50);
            request.AddParameter("firstTransactionDate", "2023-01-23T10:00:00");
            request.AddParameter("firstTransactionLocation", "");
            request.AddParameter("firstTransactionMerchantName", "Test Transaction 24/01 - Nine");
            request.AddParameter("formattedAddress", "202 Test Street # 302<br>PORT ST JOE, FL 32456");
            request.AddParameter("formattedAddress2", "202 Test Street # 302<br>Consumer");
            request.AddParameter("formattedAddress3", "202 Test Street # 302<br>Consumer");
            request.AddParameter("formattedAddressInternational", "202 Test Street # 302<br>Consumer");
            request.AddParameter("fullAccountNumber", "11223344");
            request.AddParameter("fullCardNumber", "1122334455667788");
            request.AddParameter("id", 4027);
            request.AddParameter("insuranceAmount", 20);
            request.AddParameter("interestCreditAmount", 40);
            request.AddParameter("interestRate", 0);
            request.AddParameter("isEncrypted", false);
            request.AddParameter("isInterestBearingAccount", false);
            request.AddParameter("itemPurchasedDescription", "");
            request.AddParameter("lastActivityDate", "");
            request.AddParameter("lastName", "Customer");
            request.AddParameter("lastTransactionAmount", 0);
            request.AddParameter("lastTransactionDate", "");
            request.AddParameter("lastViewDate", "2023-01-29T01:47:18.467Z");
            request.AddParameter("letterWorkflowId", 50);
            request.AddParameter("maxResolutionDeadline", "2023-02-09T18:42:55.617");
            request.AddParameter("merchandiseIncluded", "");
            request.AddParameter("merchantAttempt", "");
            request.AddParameter("merchantContactMethod", 0);
            request.AddParameter("merchantCredit", 0);
            request.AddParameter("merchantCreditDate", "2023-01-31T01:47:00.000Z");
            request.AddParameter("merchantOtherContact", "");
            request.AddParameter("minResolutionDeadline", "2023-02-09T18:42:55.617");
            request.AddParameter("name", "Amina Customer");
            request.AddParameter("netFinalCreditAndConsumerLiability", 0);
            request.AddParameter("netProvisionalCreditAndDeclinedCredit", 0);
            request.AddParameter("netProvisionalCreditAndReverseProvisionalCredit", 0);
            request.AddParameter("newAccount", false);
            request.AddParameter("nfDisputeOption", 0);
            request.AddParameter("nfDisputeOptionCancel", 0);
            request.AddParameter("nfDisputeOptionCancel1Detail", 0);
            request.AddParameter("nfDisputeOptionCancel2Detail", 0);
            request.AddParameter("nfDisputeOptionCancel3Detail", 0);
            request.AddParameter("nfDisputeOptionCancel3Shipping", "");
            request.AddParameter("nfDisputeOptionCancel3Tracking", "");
            request.AddParameter("nfDisputeOptionCancel4PromiseDate", "");
            request.AddParameter("nfDisputeOptionCancelItem", 0);
            request.AddParameter("nfDisputeOptionCancelItemDate", "");
            request.AddParameter("nfDisputeOptionCancelItemDescription", "");
            request.AddParameter("nfDisputeOptionCancelReturnDate", "");
            request.AddParameter("nfDisputeOptionMerchantRep", "");
            request.AddParameter("nfDisputeOptionMerchantResolveDate", "");
            request.AddParameter("nfDisputeOptionMerchantResponse", "");
            request.AddParameter("nfDisputeOptionProcessing", 0);
            request.AddParameter("nfDisputeOptionProcessingCorrectAmount", 0);
            request.AddParameter("nfDisputeOptionProcessingCorrectAmountNotes", "");
            request.AddParameter("nfDisputeOptionProcessingPostedNumber", 0);
            request.AddParameter("nfDisputeOptionTravel", 0);
            request.AddParameter("nfDisputeOptionTravelCancelCancelDate", "");
            request.AddParameter("nfDisputeOptionTravelCancelConfNumber", "");
            request.AddParameter("nfDisputeOptionTravelCancelReservationDate", "");
            request.AddParameter("nfDisputeOptionTravelReturnDate", "");
            request.AddParameter("noMerchantContactReason", "");
            request.AddParameter("notes", "");
            request.AddParameter("numberOfPastDisputes", 95);
            request.AddParameter("numberOfTransactions", 1);
            request.AddParameter("odpLinkedAccounts", "");
            request.AddParameter("originalTransactionDate", "");
            request.AddParameter("otherCancelMethodDescription", "");
            request.AddParameter("otherDisputeReason", "");
            request.AddParameter("otherFees", 25);
            request.AddParameter("otherPaymentMethod", "");
            request.AddParameter("otherPaymentMethodDetail", "");
            request.AddParameter("parentCaseId", 0);
            request.AddParameter("parentDispute", "");
            request.AddParameter("pcDeadline", "2023-02-09T18:42:55.617Z");
            request.AddParameter("phone", "1111111111111 (Home)");
            request.AddParameter("providedReceipt", "");
            request.AddParameter("provisionalCredit", 0);
            request.AddParameter("provisionalCreditConvertedtoFinalCredit", 0);
            request.AddParameter("provisionalCreditDate", "");
            request.AddParameter("provisionalCreditReverseAmount", "");
            request.AddParameter("provisionalCreditReversed", 0);
            request.AddParameter("qualityDetail", "");
            request.AddParameter("redactedAccount", "3344");
            request.AddParameter("redactedCardNumber", "7788");
            request.AddParameter("refundPolicyDetail", "");
            request.AddParameter("remoteCaseId", "");
            request.AddParameter("reportedOn", "2023-01-26T18:42:55.617Z");
            request.AddParameter("resolutionDeadline", "");
            request.AddParameter("resolutionNoticeSent", "2023-01-31T01:47:00.000Z");
            request.AddParameter("returnAuthorization", "");
            request.AddParameter("salesDraftReason", "");
            request.AddParameter("selectedAmountReceived", 0);
            request.AddParameter("selectedCheckDate", "");
            request.AddParameter("selectedCheckNumber", "");
            request.AddParameter("selectedDisputedAmount", 0);
            request.AddParameter("selectedPayee", "");
            request.AddParameter("selectedTransaction", "");
            request.AddParameter("selectedTransactionAmount", 0);
            request.AddParameter("selectedTransactionDate", "");
            request.AddParameter("selectedTransactionId", 0);
            request.AddParameter("selectedTransactionMerchantName", "");
            request.AddParameter("serviceChargeFee", 0);
            request.AddParameter("shippingAddress", "");
            request.AddParameter("shippingCompany", "");
            request.AddParameter("shippingTracking", "");
            request.AddParameter("signatureImage", "");
            request.AddParameter("signatureImageURL", "");
            request.AddParameter("signedBy", "");
            request.AddParameter("source", "Debit Card");
            request.AddParameter("state", "FL");
            request.AddParameter("statementDate", "2023-01-31T01:00:00.000Z");
            request.AddParameter("status", "Customer Acknowledged");
            request.AddParameter("submissionCAMSCaseNumber", "");
            request.AddParameter("submissionCaseNumber", "4027");
            request.AddParameter("sumofConsumberLiabilityWithFinalCredit", 0);
            request.AddParameter("sumofNoFinalCredit", 0);
            request.AddParameter("sumofNoProvisionalCreditConvertedtoFinalCredit", 0);
            request.AddParameter("sumofProvisionalCredit", 0);
            request.AddParameter("sumofProvisionalCreditIssuedConvertedtoFinalCredit", 0);
            request.AddParameter("thirdPartyBreach", "Source");
            request.AddParameter("total", 50);
            request.AddParameter("accountForCreditingId", 0);
            request.AddParameter("accountTransactionId", 372);
            request.AddParameter("amount", 50);
            request.AddParameter("amountReceived", 0);
            request.AddParameter("category", "");
            request.AddParameter("checkDate", "");
            request.AddParameter("checkNo", "");
            request.AddParameter("completedOn", "");
            request.AddParameter("consumerLiablity", 0);
            request.AddParameter("coreTransactionRef", "28333020003134");
            request.AddParameter("customerDisputeId", 4027);
            request.AddParameter("deadline", "2023-02-09T18:42:55.617Z");
            request.AddParameter("denialReason", "");
            request.AddParameter("description", "Customer Charge");
            request.AddParameter("detail", "Test Transaction 24/01 - Nine");
            request.AddParameter("disputedAmount", 1);
            request.AddParameter("doNotSend", false);
            request.AddParameter("feeReference", "");
            request.AddParameter("finalCredit", 0);
            request.AddParameter("finalCreditDate", "");
            request.AddParameter("foreignTransaction", false);
            request.AddParameter("id", 5309);
            request.AddParameter("interestRate", 0);
            request.AddParameter("isDeleted", false);
            request.AddParameter("isFee", false);
            request.AddParameter("linkedFeeAccountTransactionId", 0);
            request.AddParameter("location", "");
            request.AddParameter("merchant", "Test Transaction 24/01 - Nine");
            request.AddParameter("merchantCredit", 0);
            request.AddParameter("parentAccountTransactionId", 0);
            request.AddParameter("payee", "");
            request.AddParameter("pos", false);
            request.AddParameter("posted", true);
            request.AddParameter("provisionalCredit", 0);
            request.AddParameter("statementDate", "2023-01-31T06:00:00");
            request.AddParameter("transactionDate", "2023-01-23T10:00:00.000Z");
            request.AddParameter("transactionType", 1);
            request.AddParameter("workflowId", 0);
            request.AddParameter("workflowName", "");
            request.AddParameter("travelDetail", "");
            request.AddParameter("verbalElectronicConsent", false);
            request.AddParameter("verbalElectronicConsentDate", "");
            request.AddParameter("withdrawalReason", "");
            request.AddParameter("workflowName", "");
            request.AddParameter("writtenStatement", "");
            request.AddParameter("zip", "32456");

            /*request.AddParameter("account", "NcNCalRcZq/AwPKjGJ/Hyg==");
            request.AddParameter("accountApplication", "");
            request.AddParameter("accountType", "2");
            request.AddParameter("accountTypeDescription", "");
            request.AddParameter("accountTypeString", "Personal");
            request.AddParameter("achOtherReason", "");
            request.AddParameter("acknowledged", false);
            request.AddParameter("acknowledgedDate", "");
            request.AddParameter("additionalComments", "");
            request.AddParameter("address", "House");
            request.AddParameter("address2", "");
            request.AddParameter("address3", "");
            request.AddParameter("address4", "");
            request.AddParameter("amountPreventedByFDS", "150");
            request.AddParameter("approvedDisputes", "");
            request.AddParameter("approvedProvisionalCredit", "0");
            request.AddParameter("assignedBy", "0");
            request.AddParameter("assignedByName", "");
            request.AddParameter("assignedOn", "");
            request.AddParameter("assignedTo", "0");
            request.AddParameter("assignedToName", "");
            request.AddParameter("atmDisputeResolutions", "");
            request.AddParameter("atmDisputeResolutionswithDenials", "");
            request.AddParameter("atmDisputes", "");
            request.AddParameter("awareRefundPolicy", "");
            request.AddParameter("baseAccountId", "2");
            request.AddParameter("baseCustomerId", "3");
            request.AddParameter("branch", "Branch 1");
            request.AddParameter("camsCaseNumber", "123456789");
            request.AddParameter("camsId", "0");
            request.AddParameter("camsReportDate", "");
            request.AddParameter("cancelNumberGiven", "");
            request.AddParameter("cardId", "0");
            request.AddParameter("cardInPossession", false);
            request.AddParameter("cardNumber", "AvqQD/6PhLfdGRN9Fi7vk6peakuC72DpXQWoe3j9PCQ=");
            request.AddParameter("caseReference", "123456");
            request.AddParameter("certifyLostStolenPrior", "");
            request.AddParameter("chargebackAmount", "1500");
            request.AddParameter("chipCard", "");
            request.AddParameter("city", "Houston");
            request.AddParameter("closedOn", "");
            request.AddParameter("companyId", "2");
            request.AddParameter("consumerLiability", "0");
            request.AddParameter("contacts", "");
            request.AddParameter("converted", false);
            request.AddParameter("convertedOn", "");
            request.AddParameter("coreCaseDate", "2023-01-21T13:19:00.000Z");
            request.AddParameter("coreCustomerID", "12345");
            request.AddParameter("coreResolutionDate", "2023-01-21T13:19:00.000Z");
            request.AddParameter("countofDeniedDisputes", "0");
            request.AddParameter("countofDisputesWithMerchantCredit", "0");
            request.AddParameter("countofDisputeswithFinalDenialReason", "0");
            request.AddParameter("countofProvisionalCreditIssuedConvertedtoFinalCredit", "0");
            request.AddParameter("createdBy", "46");
            request.AddParameter("createdByName", "");
            request.AddParameter("createdOn", "");
            request.AddParameter("customerAccountType", "SAV");
            request.AddParameter("customerID", "2");
            request.AddParameter("customerName", "Dheeraj Singal");
            request.AddParameter("dateAcknowledged", "");
            request.AddParameter("dateCreditExpected", "");
            request.AddParameter("dateDelivered", "");
            request.AddParameter("dateMerchandiseReceived", "");
            request.AddParameter("dateMerchandiseReturned", "");
            request.AddParameter("dateStolen", "2023-01-08T01:00:00.000Z");
            request.AddParameter("declineAmount", "0");*/

            /*request.AddParameter("camsCaseNumber", "858585");
            request.AddParameter("caseReference", "8585");
            request.AddParameter("id", "3985");
            request.AddParameter("insuranceAmount", "2500");
            request.AddParameter("interestCreditAmount", "100");
            request.AddParameter("amount", "1500");
            request.AddParameter("otherFees", "1500");
            request.AddParameter("total", "1500");
            request.AddParameter("amountPreventedByFDS", "150");
            request.AddParameter("resolutionNoticeSent", "2023-01-21T13:19:00.000Z");
            request.AddParameter("minResolutionDeadline", "2023-01-23T06:11:06.52");
            request.AddParameter("merchantCreditDate", "2023-01-21T13:19:00.000Z");
            request.AddParameter("coreResolutionDate", "2023-01-20T13:46:00.000Z");
            request.AddParameter("coreCaseDate", "2023-01-21T13:19:00.000Z");*/


            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Get_Update_Case_Reference_On_Customer_Status_Tab_On_Customer_Submission_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreateGetRequest("api/customerdispute/3553/updatecaseref?casereference=456&thirdparty=Source");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Upload_File_On_Customer_Submission_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();
            var fileName = DateTime.Now.ToString();
            var request = HelperFunctions.CreatePostRequest($"api/customerdispute/3985/upload");

            request.AddParameter("description", $"{fileName}.pdf");
            
            var directory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory));
          
            request.AddFile(fileName, $"{directory}\\TestFile\\QAEngineerJD.pdf", "multipart/form-data");

            var response = await restClient.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task Test_Post_Delete_Case_Contact_On_Contacts_Tab_Page_On_Customer_Submission_Page()
        {
            restClient = HelperFunctions.InitializeDisputeDevAPIClient();

            var request = HelperFunctions.CreatePostRequest("api/casecontact");

            var caseId = "3551";
            var contactName = "API Test Automator";
            var email = "abdulnoman666@gmail.com";
            var phone = "03455166674";
            var reference = "CL";

            request.AddParameter("caseId", caseId);
            request.AddParameter("contactName", contactName);
            request.AddParameter("email", email);
            request.AddParameter("phone", phone);
            request.AddParameter("reference", reference);

            var response1 = await restClient.ExecuteAsync(request);

            Assert.That(response1.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var output = HelperFunctions.DeserializeResponseToJson(response1);

            var id = output["id"];
            var companyId = output["companyId"];
            var createdBy = output["createdBy"];
            var createdOn = output["createdOn"];


            var deleteCaseContactRequest = HelperFunctions.CreatePostRequest($"api/casecontact/{id}/delete");

            deleteCaseContactRequest.AddParameter("caseId", caseId);
            deleteCaseContactRequest.AddParameter("companyId", companyId);
            deleteCaseContactRequest.AddParameter("contactName", contactName);
            deleteCaseContactRequest.AddParameter("createdBy", createdBy);
            deleteCaseContactRequest.AddParameter("createdOn", createdOn);
            deleteCaseContactRequest.AddParameter("email", email);
            deleteCaseContactRequest.AddParameter("id", id);
            deleteCaseContactRequest.AddParameter("phone", phone);
            deleteCaseContactRequest.AddParameter("reference", reference);

            var response2 = await restClient.ExecuteAsync(deleteCaseContactRequest);

            Assert.That(response2.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
