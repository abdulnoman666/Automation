using OpenQA.Selenium;
namespace UITestAutomation.Pages.Disputes
{
    internal partial class Disputes
    {
        //UI Controls on Disputes Page
        By DisputesOption = By.CssSelector("li:nth-of-type(5) > .dropdown-menu > li:nth-of-type(1) > a");
        By AlertsButton = By.CssSelector("button[title='Alerts']");
        By SearchSetDateButton = By.CssSelector("button[title='Search and set date range']");
        By SearchUser = By.CssSelector("[aria-label] [aria-hidden='false']");
        By RefreshSubmissions = By.CssSelector("button[title='Refresh Submissions']");
        By ShowClosedDisputesButton = By.CssSelector(".panel-body .pull-left .page-link");
        By One = By.CssSelector("li:nth-of-type(3) > span[role='button']");
        By Two = By.CssSelector("li:nth-of-type(4) > span[role='button']");
        By Three = By.CssSelector("li:nth-of-type(5) > span[role='button']");
        By Four = By.CssSelector("li:nth-of-type(6) > span[role='button']");
        By Five = By.CssSelector("li:nth-of-type(7) > span[role='button']");
        By Six = By.CssSelector("li:nth-of-type(8) > span[role='button']");
        By Seven = By.CssSelector("li:nth-of-type(9) > span[role='button']");
        By LinksField = By.CssSelector("tr > th:nth-of-type(1)");
        By ReportedField = By.CssSelector("th:nth-of-type(2) > a");
        By DaysField = By.CssSelector("tr > th:nth-of-type(3)");
        By StatusField = By.CssSelector("th:nth-of-type(4) > a");
        By DetailField = By.CssSelector("tr > th:nth-of-type(5)");
        By ResolutionField = By.CssSelector("th:nth-of-type(6) > a");
        By AmountField = By.CssSelector("th:nth-of-type(7) > a");
        By RecoveredField = By.CssSelector("th:nth-of-type(8) > a");
        By CustomerField = By.CssSelector("th:nth-of-type(9) > a");
        By AssignedToField = By.CssSelector("tr > th:nth-of-type(10)");
        By DisputeStatusField = By.XPath("//select[@ng-model='$.disputeStatus']");
        By DisputeResolutionField = By.XPath("//select[@ng-model='$.disputeResolution']");
        By DisputeCustomerField = By.XPath("//input[@ng-model='$.customerName']");
        By EditDisputeButton = By.CssSelector("button[title='Edit Dispute']");
        By ViewSubmissionField = By.CssSelector("button[title='View Original Submission']");

        //UI Controls on Alerts Page
        By Customer = By.CssSelector(".modal-content table  tr > th:nth-of-type(2) > a");
        By SubmissionId = By.LinkText("th:nth-of-type(3) > a");
        By Status = By.CssSelector(".modal-content table  tr > th:nth-of-type(4) > a");
        By Source = By.CssSelector("th:nth-of-type(5) > a");
        By Alert = By.CssSelector(".modal-content table  tr > th:nth-of-type(6) > a");
        By Type = By.CssSelector(".modal-content table  tr > th:nth-of-type(7) > a");
        By Deadline = By.CssSelector(".modal-content table  tr > th:nth-of-type(8) > a");
        By CloseButton = By.CssSelector(".modal-ex-lg .modal-footer [ng-click]");

        //UI Controls on Search Page
        By Calendar = By.XPath("//button[@ng-click='ctrl.openCalendarPane($event)']");
        By Search = By.CssSelector("form[name='dateFilterForm']  .btn.btn-info");
        By Reset = By.CssSelector("form[name='dateFilterForm']  .btn.btn-default");
        By Status2 = By.XPath("//select[@ng-model='search.disputeStatus']");
        By CardNumber = By.XPath("//input[@ng-model='search.cardNumber']");
        By AccountNumber = By.XPath("//input[@ng-model='search.account']");
        By Search2 = By.XPath("//button[@ng-click='searchByFields();']");
        By Reset2 = By.XPath("//button[@ng-click='resetFields()']");
        By CloseButton2 = By.XPath("//button[@ng-click='close()']");

        //UI Controls on Show Closed Disputes Page
        By Eight = By.CssSelector("li:nth-of-type(10) > span[role='button']");
        By Nine = By.CssSelector("li:nth-of-type(11) > span[role='button']");
        By Ten = By.CssSelector("li:nth-of-type(12) > span[role='button']");
        By Eleven = By.CssSelector("li:nth-of-type(3) > span[role='button']");
        By Twelve = By.CssSelector("li:nth-of-type(4) > span[role='button']");
        By DirectGoto1Page = By.CssSelector("li:nth-of-type(1) > span[role='button']");
        By PreviousPage = By.CssSelector("li:nth-of-type(2) > span[role='button']");
        By NextPage = By.CssSelector("");// not found
        By DirectGotoLastPage = By.LinkText("li:nth-of-type(5) > span[role='button']");
        By EnterPageField = By.CssSelector("[ng-hide] span .form-control");
        By GoButton = By.CssSelector("li[role='button'] > span");

        //UI Controls on Edit Dispute Page
        By ResearchStatus = By.LinkText("Research Status");
        By DocumentsButton = By.LinkText("Documents (0)");
        By HistoryButton = By.LinkText("History");
        By Refresh = By.CssSelector("button[title='Refresh']");
        By SubmissionDisputes = By.CssSelector("button[title='Select Dispute']");
        By Save = By.CssSelector(".panel-heading > div > button:nth-of-type(1)");
        By ViewSubmission = By.CssSelector(".panel-heading > div > button:nth-of-type(2)");
        By ResolutionButton = By.CssSelector(".panel-heading > div > button:nth-of-type(3)");
        By PrintLetter = By.CssSelector("button[title='Print Letter']");
        By DisputeDetails = By.LinkText("Dispute Details");
        By POS = By.CssSelector("input[name='pos']");
        By ForeignTransaction = By.CssSelector("input[name='foreignTransaction']");
        By Research = By.CssSelector("label:nth-of-type(5) > input[name='disputeStatus']");
        By Detail = By.XPath("//select[@ng-model='dispute.researchStatus']");
        By Closed = By.CssSelector("label:nth-of-type(6) > input[name='disputeStatus']");
        By CloseDate = By.CssSelector("#disputeStatus .ng-empty:nth-child(17) > [type]");
        By PreArbitration = By.CssSelector("label:nth-of-type(8) > input[name='disputeStatus']");
        By FinalResolutionDate = By.CssSelector("#disputeStatus .ng-empty:nth-child(22) > [type]");
        By Notes = By.CssSelector("#processorDetails .panel-heading");
        By EnterNotes = By.CssSelector("#processorDetails .form-control");
        By CustomerCredit = By.LinkText("Customer Provisional Credit");
        By TransactionAmount = By.CssSelector("input#transactionAmount");
        By CreditAmount = By.CssSelector("input#provisionalCreditAmount");
        By ConsumerLiability = By.CssSelector("input#consumerLiability");
        By DenialReason = By.XPath("//input[@ng-model='dispute.denialReason']");
        By ReversalDate = By.CssSelector(".panel-body.ng-binding ._md-datepicker-has-triangle-icon > [type]");
        By Representment = By.LinkText("Representment");
        By RepresentmentDate = By.CssSelector("[class='col-lg-4 col-sm-4 col-xs-12']:nth-of-type(2) .panel-info:nth-of-type(2) ._md-datepicker-has-triangle-icon > [type]");
        By MerchantChargeback = By.LinkText("Merchant Chargeback");
        By ChargebackDate = By.CssSelector(".panel-info:nth-of-type(3) .ng-empty:nth-child(2) > [type]");
        By MerchantResponseDate = By.CssSelector("[class='col-lg-4 col-sm-4 col-xs-12']:nth-of-type(2) .ng-empty:nth-child(4) > [type]");
        By PreArbitrationDetails = By.CssSelector("div:nth-of-type(4) > .panel-heading");
        By DateRequested = By.CssSelector(".panel-info:nth-of-type(4) ._md-datepicker-has-triangle-icon > [type]");
        By Resolution = By.CssSelector("div#Resolution > .panel-heading");
        By DateResearchEnded = By.CssSelector("#Resolution .ng-empty:nth-child(4) > [type]");
        By ResolutionLetter = By.CssSelector("#Resolution .ng-empty:nth-child(6) > [type]");
        By ProcessorChargeback = By.LinkText("Processor Chargeback");
        By AmountRecovered = By.CssSelector("#Recovery .form-control");
        By ProvisionalDate = By.CssSelector("#Recovery div:nth-child(3) ._md-datepicker-has-triangle-icon > [type]");
        By FinalDate = By.CssSelector("#Recovery div:nth-child(4) ._md-datepicker-has-triangle-icon > [type]");

        //UI Controls on Documents Page
        By DocumentsList = By.LinkText("Document List");

        //UI Controls on History Page
        By Date = By.CssSelector("tr > th:nth-of-type(1)");
        By Description = By.CssSelector("tr > th:nth-of-type(2)");
        By By = By.CssSelector("tr > th:nth-of-type(3)");
        By Type2 = By.CssSelector("tr > th:nth-of-type(4)");

        //UI Controls on Resolution Page
        By Pending = By.CssSelector(".col-md-6.ng-binding > div:nth-of-type(1) > label");
        By ClaimApproved = By.CssSelector(".col-md-6.ng-binding > div:nth-of-type(2) > label");
        By ClaimDeclined = By.CssSelector(".col-md-6.ng-binding > div:nth-of-type(3) > label");
        By MerchantCredit = By.CssSelector(".col-md-6.ng-binding > div:nth-of-type(5) > label");
        By NotSelected = By.CssSelector(".form-group > div:nth-of-type(1) > label");
        By BankLoss = By.CssSelector(".form-group > div:nth-of-type(2) > label");
        By MerchantLoss = By.CssSelector(".form-group > div:nth-of-type(3) > label");
        By ConsumerLoss = By.CssSelector(".form-group > div:nth-of-type(4) > label");
        By AmountRecovered2 = By.XPath("//input[@ng-model='dispute.amountRecoveredCDC']");
        By ProvisionalDate2 = By.CssSelector("[class] div:nth-child(14) ._md-datepicker-has-triangle-icon > [type]");
        By FinalDate2 = By.CssSelector("[class] div:nth-child(15) ._md-datepicker-has-triangle-icon > [type]");
        By CreditAccount = By.XPath("//input[@ng-model='dispute.creditAmount']");
        By DebitAccount = By.XPath("//input[@ng-model='dispute.debitAmount']");
        By MerchantCreditedCustomer = By.XPath("//input[@ng-model='dispute.merchantCreditAmount']");
        By EnterNotes2 = By.CssSelector("[class='col-lg-10'] .form-control");
        By PosttoGL = By.XPath("//button[@ng-click='resolveDispute()']");
        By Save2 = By.XPath("//button[@ng-click='saveDisputes()']");
        By Close = By.XPath("//button[@ng-click='cancelresolve()']");
    }
}
//By DisputesOption = By.LinkText("");
//By Alerts = By.CssSelector("");
//By SearchSetDate = By.CssSelector("");
//By DearchUser = By.CssSelector("");
//By RefreshSubmissions = By.CssSelector("");
//By ShowClosedDisputes = By.CssSelector("");
//By One = By.CssSelector("");
//By Two = By.CssSelector("");
//By Three = By.CssSelector("");
//By Four = By.CssSelector("");
//By Five = By.CssSelector("");
//By Six = By.CssSelector("");
//By Seven = By.CssSelector("");
//By StatusField = By.CssSelector("");
//By ResolutionField = By.CssSelector("");
//By CustomerField = By.CssSelector("");
//By EditDisputeField = By.CssSelector("");
//By ViewSubmissionField = By.CssSelector("");