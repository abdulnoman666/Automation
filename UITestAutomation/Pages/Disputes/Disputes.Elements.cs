using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class Disputes
    {
        //UI Controls on Disputes Page
        By DisputesOption = By.XPath("//a[text='Disputes']");
        By SettingsButton = By.XPath("//button[@ng-click='setTempOrder()']");
        By SearchSetDateButton = By.XPath("//button[class='btn btn-info  btn-sm glyphicon glyphicon-search']");
        By SearchUser = By.XPath("//span[@ng-show='$select.isEmpty()']");
        By RefreshSubmissions = By.XPath("//button[@ng-click='refreshDisputes()']");
        By ShowClosedDisputesButton = By.XPath("//input[@ng-model='showClosed']");
        By One = By.XPath("//span[@ng-click='setpage(p)'][1]");
        By Two = By.XPath("//span[@ng-click='setpage(p)'][2]");
        By Three = By.XPath("//span[@ng-click='setpage(p)'][3]");
        By Four = By.XPath("//span[@ng-click='setpage(p)'][4]");
        By Five = By.XPath("//span[@ng-click='setpage(p)'][5]");
        By LinksField = By.XPath("//th[1]");
        By ReportedField = By.XPath("//th[2]");
        By DaysField = By.XPath("//th[3]");
        By StatusField = By.XPath("//th[4]");
        By DetailField = By.XPath("//th[5]");
        By ResolutionField = By.XPath("//th[6]");
        By AmountField = By.XPath("//th[7]");
        By RecoveredField = By.XPath("//th[8]");
        By CustomerField = By.XPath("//th[9]");
        By AssignedToField = By.XPath("//th[10]");
        By DisputeStatusField = By.XPath("//select[@ng-model='$.disputeStatus']");
        By DisputeResolutionField = By.XPath("//select[@ng-model='$.disputeResolution']");
        By DisputeCustomerField = By.XPath("//input[@ng-model='$.customerName']");
        By EditDisputeButton = By.XPath("//button[@ng-click='disputeDocs($event, dispute.id)']");
        By ViewSubmissionField = By.XPath("//button[@ng-click='customerDispute($event, dispute.batchNumber);']");

        //UI Controls on Settings Page
        By Reported = By.XPath("//span[@ng-click='$selectMultiple.activeMatchIndex = $index;'][1]");
        By Days = By.XPath("//span[@ng-click='$selectMultiple.activeMatchIndex = $index;'][2]");
        By Status = By.XPath("//span[@ng-click='$selectMultiple.activeMatchIndex = $index;'][3]");
        By Detail = By.XPath("//span[@ng-click='$selectMultiple.activeMatchIndex = $index;'][4]");
        By Resolution = By.XPath("//span[@ng-click='$selectMultiple.activeMatchIndex = $index;'][5]");
        By Amount = By.XPath("//span[@ng-click='$selectMultiple.activeMatchIndex = $index;'][6]");
        By Recovered = By.XPath("//span[@ng-click='$selectMultiple.activeMatchIndex = $index;'][7]");
        By Customer = By.XPath("//span[@ng-click='$selectMultiple.activeMatchIndex = $index;'][8]");
        By AssignedTo = By.XPath("//span[@ng-click='$selectMultiple.activeMatchIndex = $index;'][9]");
        By SaveButton = By.XPath("//button[@ng-click='saveOrder()']");
        By CloseButton = By.XPath("//button[class='btn btn-default'][3]");
        By CrossButton = By.XPath("//button[class='close'][3]");

        //UI Controls on Search Page
        By StartDate = By.XPath("//button[@ng-click='ctrl.openCalendarPane($event)'][1]");
        By EndDate = By.XPath("//button[@ng-click='ctrl.openCalendarPane($event)'][2]");
        By Search = By.XPath("//button[@ng-click='searchByDate(); close()']");
        By Reset = By.XPath("//button[@ng-click='resetDates();']");
        By Status2 = By.XPath("//select[@ng-model='search.disputeStatus']");
        By CardNumber = By.XPath("//input[@ng-model='search.cardNumber']");
        By AccountNumber = By.XPath("//input[@ng-model='search.account']");
        By Search2 = By.XPath("//button[@ng-click='searchByFields();']");
        By Reset2 = By.XPath("//button[@ng-click='resetFields()']");
        By CloseButton2 = By.XPath("//button[@ng-click='close()']");

        //UI Controls on Edit Dispute Page
        By ResearchStatus = By.XPath("//a[@ng-click='tab=1']");
        By DocumentsButton = By.XPath("//a[@ng-click='tab=2']");
        By HistoryButton = By.XPath("//a[@ng-click='tab=3']");
        By Refresh = By.XPath("//button[@ng-click='refresh()']");
        By Save = By.XPath("//button[@ng-click='saveDisputes()']");
        By ViewSubmission = By.XPath("//button[@ng-click='viewSubmission()']");
        By ResolutionButton = By.XPath("//button[@ng-click='copydispute()']");
        By PrintLetter = By.XPath("//span[@ng-show='showLabel']");
        By POS = By.XPath("//input[@ng-model='dispute.pos']");
        By ForeignTransaction = By.XPath("//input[@ng-model='dispute.foreignTransaction']");
        By Research = By.XPath("//input[@ng-model='dispute.disputeStatus'][1]");
        By Detail2 = By.XPath("//select[@ng-model='dispute.researchStatus']");
        By Closed = By.XPath("//input[@ng-model='dispute.disputeStatus'][2]");
        By CloseDate = By.XPath("//button[@ng-click='ctrl.openCalendarPane($event)'][9]");
        By PreArbitration = By.XPath("//input[@ng-model='dispute.disputeStatus'][3]");
        By FinalResolutionDate = By.XPath("//button[@ng-click='ctrl.openCalendarPane($event)'][1]");
        By EnterNotes = By.XPath("//textarea[@ng-model='dispute.comments'][1]");
        By TransactionAmount = By.XPath("//input[@ng-model='dispute.transactionAmount']");
        By CreditAmount = By.XPath("//input[@ng-model='dispute.provisionalCreditAmount']");
        By ConsumerLiability = By.XPath("//input[@ng-model='dispute.consumerLiability']");
        By DenialReason = By.XPath("//input[@ng-model='dispute.denialReason']");
        By ReversalDate = By.XPath("//button[@ng-click='ctrl.openCalendarPane($event)'][2]");
        By DocumentReceived = By.XPath("//button[@ng-click='ctrl.openCalendarPane($event)'][3]");
        By DocumentSent = By.XPath("//button[@ng-click='ctrl.openCalendarPane($event)'][4]");
        By ProvisionalCreditReceived = By.XPath("//input[@ng-model='dispute.provisionalChargebackRecieved']");
        By ProvisionalDate = By.XPath("//button[@ng-click='ctrl.openCalendarPane($event)'][12]");
        By ProvisionalCreditRemoved = By.XPath("//input[@ng-model='dispute.provisionalChargebackRemoved']");
        By RemovalDate = By.XPath("//button[@ng-click='ctrl.openCalendarPane($event)'][13]");
        By FinalCredit = By.XPath("//input[@ng-model='dispute.finalChargeback']");
        By FinalDate = By.XPath("//button[@ng-click='ctrl.openCalendarPane($event)'][14]");
        By DocumentReceivedFromProcessor = By.XPath("//button[@ng-click='ctrl.openCalendarPane($event)'][15]");
        By DocumentsSenttoCardholder = By.XPath("//button[@ng-click='ctrl.openCalendarPane($event)'][16]");
        By DateResearch = By.XPath("//button[@ng-click='ctrl.openCalendarPane($event)'][18]");
        By ResolutionLetter = By.XPath("//button[@ng-click='ctrl.openCalendarPane($event)'][19]");

        //UI Controls on Show Closed Disputes Page
        By Six = By.XPath("//span[@ng-click='setpage(p)'][6]");
        By Seven = By.XPath("//span[@ng-click='setpage(p)'][7]");
        By Eight = By.XPath("//span[@ng-click='setpage(p)'][8]");
        By Nine = By.XPath("//span[@ng-click='setpage(p)'][9]");


        //UI Controls on Documents Page
        By DocumentsList = By.XPath("//div[class='panel-body']");

        //UI Controls on History Page
        By Date = By.XPath("//th[1]");
        By Description = By.XPath("//th[2]");
        By By = By.XPath("//th[3]");
        By Type2 = By.XPath("//th[4]");

        //UI Controls on Resolution Page
        By Pending = By.XPath("//input[@ng-model='dispute.claimResult'][1]");
        By ClaimApproved = By.XPath("//input[@ng-model='dispute.claimResult'][2]");
        By ClaimDeclined = By.XPath("//input[@ng-model='dispute.claimResult'][3]");
        By MerchantCredit = By.XPath("//input[@ng-model='dispute.claimResult'][4]");
        By NotSelected = By.XPath("//input[@ng-model='dispute.disputeResolution'][1]");
        By BankLoss = By.XPath("//input[@ng-model='dispute.disputeResolution'][6]");
        By MerchantLoss = By.XPath("//input[@ng-model='dispute.disputeResolution'][7]");
        By ConsumerLoss = By.XPath("//input[@ng-model='dispute.disputeResolution'][8]");
        By AmountRecovered2 = By.XPath("//input[@ng-model='dispute.amountRecoveredCDC']");
        By ProvisionalDate2 = By.XPath("//button[@ng-click='ctrl.openCalendarPane($event)'][20]");
        By FinalDate2 = By.XPath("//button[@ng-click='ctrl.openCalendarPane($event)'][21]");
        By CreditAccount = By.XPath("//input[@ng-model='dispute.creditAmount']");
        By DebitAccount = By.XPath("//input[@ng-model='dispute.debitAmount']");
        By MerchantCreditedCustomer = By.XPath("//input[@ng-model='dispute.merchantCreditAmount']");
        By EnterNotes2 = By.XPath("//textarea[@ng-model='dispute.comments'][2]");
        By PosttoGL = By.XPath("//button[@ng-click='resolveDispute()']");
        By Save2 = By.XPath("//button[@ng-click='saveDisputes()']");
        By Close = By.XPath("//button[@ng-click='cancelresolve()']");
    }
}