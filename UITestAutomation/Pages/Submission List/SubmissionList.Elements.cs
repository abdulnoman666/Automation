using OpenQA.Selenium;

namespace UITestAutomation
{
    internal partial class SubmissionList
    {
        By SubmissionList_Dropdown = By.XPath("//a[@href='#/processorcustomerdisputes']");

        //reassign page
        By Processors_Button = By.XPath("//div[@title='Processor Filter']/div[@placeholder='Select Processor or Search in list...']/span[@role='button']/span[.='Select Processor or Search in list...']");
        By Cancel_Button = By.CssSelector(".modal-footer [ng-click='close\\(\\)']");
        By AssignCase_Button = By.CssSelector(".btn.btn-info.reply-button");
        //UI Controls
      //  By Alerts_Button = By.XPath("//button[@ng-click=\"openAlerts()\"]");
        By NewCase_Button = By.XPath("//button[@title=\"New Case\"]");
        By Settings_Button = By.XPath("//button[@title=\"Settings\"]");
        By Search_Button = By.CssSelector(".glyphicon-search");
        By Refresh_Button = By.XPath("//button[@ng-click=\"refreshDisputes()\"]");
        By AllOriginators_Textfield = By.CssSelector("div:nth-of-type(3) > div[title='User Filter'] > .ng-scope.ui-select-match > span[role='button'] > .pull-left.ui-select-match-text");
        By AllAssignee_Textfield = By.CssSelector("div:nth-of-type(2) > div[title='User Filter'] > .ng-scope.ui-select-match > span[role='button'] > .pull-left.ui-select-match-text");
        By EnterPage_Textfield = By.XPath("//input[@placeholder=\"Enter Page\"]");
        By Go_Button = By.CssSelector("li[role='button'] > span");
        By ShowClosedSubmissions_Button = By.CssSelector(".panel-body .pull-left .page-link");
        By ViewSubmission_Button = By.CssSelector("tbody .ng-scope:nth-of-type(2) .glyphicon-edit");
        By ReassignSubmissionn_Button = By.CssSelector("tbody .ng-scope:nth-of-type(2) .glyphicon-tag");
        By DeleteSubmission_Button = By.XPath("//button[@title=\"Delete or Withdraw Submission\"]");

        //Fields
        By Action_Field = By.CssSelector("[width='140']");
        By SubCase_Field = By.CssSelector("[width='90']");
        By SubCase_TextField = By.XPath("//input[@ng-model=\"$.submissionCaseNumber\"]");
        By Customer_Field = By.CssSelector("th:nth-of-type(5) > a");
        By Customer_TextField = By.XPath("//input[@ng-model=\"$.customerName\"]");
        By Workflow_Field = By.CssSelector("th:nth-of-type(6) > a");
        By Workflow_TextField = By.XPath("//input[@ng-model=\"$.source\"]");
        By Reported_Field = By.CssSelector("[ng-click='sorting\\(\\'reportedOn\\'\\)']");
        By Days_Field = By.CssSelector("thead [ng-show='order\\.selectedColumns\\.indexOf\\(\\'Days\\'\\)\\!\\=-1']");
        By ProcessorCaseReference_Field = By.CssSelector("thead [ng-show='order\\.selectedColumns\\.indexOf\\(\\'ProcessorCaseReference\\'\\)\\!\\=-1']");
        By Status_Field = By.CssSelector("th:nth-of-type(10) > a");
        By Status_Textbox = By.XPath("//input[@ng-model=\"$.status\"]");
        By PT_Field = By.CssSelector("th:nth-of-type(11) > a");
        By Total_Field = By.CssSelector("th:nth-of-type(14) > a");
        By Total_TextboxField = By.XPath("//input[@ng-model=\"totalFilter\"]");
        By Orig_Field = By.CssSelector("thead [ng-show='order\\.selectedColumns\\.indexOf\\(\\'Orig\\'\\)\\!\\=-1']");
        By AssignedTo_Field = By.CssSelector("thead [ng-show='order\\.selectedColumns\\.indexOf\\(\\'AssignedTo\\'\\)\\!\\=-1']");

        //Dispute Submission
        By TransactionMethod_Dropdown = By.CssSelector("div#customerInformation  select[name='source']");
        By Fraud_RadioButton = By.XPath("//input[@ng-model=\"customerDispute.disputeType\"] [@value=\"1\"]");
        By AdvanceSearch_Button = By.CssSelector("[class='col-lg-10 col-xs-10 mb-5'] .btn-default");
        By CustomerName_TextField = By.CssSelector("form[name='dateFilterForm']  input[name='customerName']");
        By Search_ButtonCustomerSearch = By.CssSelector("form[name='dateFilterForm'] > .btn.btn-info");
        By SelectCustomer_Button = By.XPath("//button[@ng-click=\"selectCust(cust)\"]");
        By Details_TextArea = By.CssSelector("div#customerInformation > textarea[name='disputeReason']");
        By AdditionalTasks_Field = By.CssSelector("div:nth-of-type(11) > h3 > span[role='button']");
        By TaskName_Field = By.XPath("//select[@ng-model=\"task.taskType\"]");
        By SaveTask_Button = By.CssSelector("form[name='addSubmissionTaskForm']  .btn.btn-info");
        By TransactionList_Field = By.CssSelector("[ng-show] h3 [ng-click]");
        By AmountTransaction_Field = By.CssSelector("input[name='transactionAmount']");
        By DisputedAmountTransaction_Field = By.CssSelector("input[name='disputedAmount']");
        By MerchantTransaction_Field = By.CssSelector("input[name='transactionMerchant']");
        By DetailTransaction_Field = By.CssSelector("input[name='detail']");
        By SaveAddTransaction_Button = By.CssSelector("form[name='addTransactionForm']  .btn.btn-info");
        By Next_Button = By.XPath("//div[@class='panel-footer']/button[3]");
        By YesDisputeForm_Button = By.XPath("(//input[@ng-model=\"val\"])[1]");
        By YesStolenCard_Button = By.XPath("(//input[@name=\"policeReport\"])[1]");
        By FiledDate_Field = By.CssSelector(".md-datepicker-input-container > input[name='reportFileDate']");
        By CityReport_Field = By.CssSelector("input#cityReportFiled");
        By DiaputeReason_RadioButton = By.CssSelector("input#disputeOption");
        By NoClose_Button = By.CssSelector("fi-radiobutton:nth-of-type(2) > input#cardClosed");
        By DateCardClosed_Field = By.CssSelector("input#closedDate");
        By CustomerSignatureForm_Button = By.CssSelector(".container .ng-scope:nth-child(3) .panel-heading [type='button']:nth-of-type(6)");
        By Proceed_Button = By.XPath("//button[@ng-click=\"openConsentDialog()\"]");
        By Consent_Checkbox = By.XPath("//input[@ng-model=\"consent\"]");
        By Confirm_Button = By.XPath("(//button[@ng-click=\"close()\"])[2]");
        By Signature_Textarea = By.CssSelector("canvas#tmp_canvas_cardholderSignature");
        By Acknowledge_Checkbox = By.XPath("//input[@ng-model=\"acknowledged\"]");
        By Done_Button = By.XPath("(//button[@ng-click=\"done(acknowledged)\"])[2]");

        //Additional
        //editsubmission
        //submission info
        By SelectPCCalculation = By.CssSelector("div:nth-of-type(1) > button[title='Calculate Provisional Credit']");
        By EditSubmission_Button = By.XPath("//button[@ng-click=\"editNewDispute(customerDispute)\"]");
        By ProcessTransactions_Button = By.CssSelector(".panel-heading.row > div:nth-of-type(1) > a");
        By PrintLetter_Button = By.CssSelector("[ng-show='tab\\=\\=1'] [ng-show='showLabel']");
        By RunAutomation_Button = By.XPath("//div[@class='panel-heading row']/div[1]/div[@class='dropdown']/button[@title='Select Automation']");
        By EditCustomer_Button = By.XPath("//button[@ng-click=\"editCustomer()\"]");
        By AllSubmission_Button = By.CssSelector("div:nth-of-type(8) button[title='All Submission']");
        By ActivityHistory_Button = By.CssSelector("div:nth-of-type(8) button[title='Activity History']");
        By RefreshSubmissions_Button = By.CssSelector("div:nth-of-type(8) button[title='Refresh Submissions']");
        By Transactions_Button = By.CssSelector("div[title='Transactions'] > .btn.btn-info.dropdown-toggle.glyphicon.glyphicon-th");
        By SaveComments_Button = By.XPath("//button[@ng-click=\"updateNotes()\"]");
        By AddNote_Button = By.XPath("//button[@ng-click=\"addNoteDialog()\"]");
        By ViewAll_Button = By.CssSelector(".ng-binding [class] [data-toggle='modal']:nth-child(3)");
        By CalculateInterest_Button = By.XPath("//button[@data-target=\"#calculateInterest\"]");

        By CommentsandResolution_Field = By.CssSelector(".col-lg-4 > textarea[name='notes']");
        By Public_Field = By.CssSelector("[width='55']");
        By Date_Field = By.CssSelector(".ng-binding [width='120']");
        By CreatedBy_Field = By.CssSelector("[width='150']");
        By Notes_Field = By.XPath("//div[@class='col-lg-8']/div/table//th[.='Notes']");

        By Status_FieldAdditionalTask = By.XPath("//div[@class='panel-body row']/div[4]//table//th[.='Status']");
        By TaskName_FieldAdditionalTask = By.XPath("//div[@class='panel-body row']/div[4]//table//th[.='Task Name']");
        By CreatedOn_FieldAdditionalTask = By.XPath("//div[@class='panel-body row']/div[4]//table//th[.='Created On']");
        By AssignedTo_FieldAdditionalTask = By.XPath("//div[@class='panel-body row']/div[4]//table//th[.='Assigned To']");
        By AssignedOn_FieldAdditionalTask = By.XPath("//div[@class='panel-body row']/div[4]//table//th[.='Assigned On']");
        By ClosedOn_FieldAdditionalTask = By.XPath("//div[@class='panel-body row']/div[4]//table//th[.='Closed On']");

        By PreAuth_Field = By.XPath("//th[.='Pre-Auth']");
        By DateTransactions_Field = By.XPath("//div[@class='panel-body row']/div[5]/div[@class='panel panel-default']/div[@class='panel-body']/table//th[.='Date']");
        By DeadlineTransaction_Field = By.XPath("//th[.='Deadline']");
        By POS_Field = By.XPath("(//th[.='POS'])[1]");
        By FT_Field = By.XPath("(//th[.='FT'])[1]");
        By Amount_Field = By.XPath("(//th[.='Amount'])[2]");
        By DisputedAmount_Field = By.XPath("//th[.='Disputed Amount']");
        By Merchant_Field = By.XPath("(//th[.='Merchant'])[1]");
        By DoNotSend_Field = By.XPath("//th[.='Do Not Send']");
       
        //questionaire
        By Questionaire_Button = By.CssSelector(".nav.nav-tabs > li:nth-of-type(2) > a");
        By Questionaire_Field = By.CssSelector(".finboa-template.ng-scope > div > div");
        By SaveQuestionnairetoPDF_Button = By.XPath("//button[@ng-click=\"saveQuestionnairetoPDF();\"]");
        By PrintQuestionaire_Button = By.XPath("//button[@ng-click=\"printLetterQuestionnaire();\"]");
        By EmailQuestionaire_Button = By.XPath("//button[@ng-click=\"emailQuestionnaire()\"]");

        //forms
        By Forms_Button = By.CssSelector(".nav.nav-tabs > li:nth-of-type(3) > a");
        By SelectFormtoView_Button = By.CssSelector("finboa-input-form-dropdown [ng-show='showLabel']");
        By SaveFormData_Button = By.XPath("//button[@ng-click='saveFormInput()']");
        By SavePDF_Button = By.XPath("//button[@ng-click='printForm()']");
        By ESignature_Button = By.XPath("//button[@ng-click='openConsentDialog()']");

        //disputes
        By Disputes_Button = By.CssSelector("[ng-click='changeTab\\(3\\)']");
        By SelectAutomation_Button = By.CssSelector(".btn-group.dropdown > button[title='Select Automation']");
        By RunSelectedWorkflowAutomation_Button = By.CssSelector("button[title='Run Selected Workflow Automation']");
        By Settingsdisputes_Button = By.CssSelector("button[title='Settings']");
        By HideClosedDisputes_Button = By.CssSelector(".page-link");
        By SubmissionInfo_Button = By.CssSelector(".collapsed");
        By Actiondisputes_Field = By.CssSelector("[ng-init] [width='170px']");
        By IDdisputes_Field = By.CssSelector("[ng-click='sortTable\\=sortTable\\=\\=\\'id\\'\\?\\'-id\\'\\:\\'id\\'']");
        By TransactionDate_Field = By.CssSelector("[ng-click='sortTable\\=sortTable\\=\\=\\'transactionDate\\'\\?\\'-transactionDate\\'\\:\\'transactionDate\\'']");
        By Amountdisputes_Field = By.CssSelector("[ng-click='sortTable\\=sortTable\\=\\=\\'transactionAmount\\'\\?\\'-transactionAmount\\'\\:\\'transactionAmount\\'']");
        By Merchantdisputes_Field = By.CssSelector("[ng-click='sortTable\\=sortTable\\=\\=\\'merchantName\\'\\?\\'-merchantName\\'\\:\\'merchantName\\'']");
        By PC_Field = By.CssSelector("[ng-click='sortTable\\=sortTable\\=\\=\\'provisionalCreditAmount\\'\\?\\'-provisionalCreditAmount\\'\\:\\'provisionalCreditAmount\\'']");
        By Statusdisputes_Field = By.CssSelector("[ng-init] [ng-show='order\\.selectedColumns\\.indexOf\\(\\'Status\\'\\)\\!\\=-1']");
        By ResearchDetail_Field = By.CssSelector("[ng-init] [ng-show='order\\.selectedColumns\\.indexOf\\(\\'Research Detail\\'\\)\\!\\=-1']");
        By Notesdisputes_Field = By.CssSelector("[ng-init] [ng-show='order\\.selectedColumns\\.indexOf\\(\\'Notes\\'\\)\\!\\=-1']");

        //Customer status
        By CustomerStatus_Button = By.CssSelector("[ng-click='changeTab\\(6\\)']");
        By CaseNumber_Field = By.XPath("//input[@ng-model=\"customerDispute.caseReference\"]");
        By ThirdPartyBreachSource_Dropdown = By.XPath("//select[@ng-model=\"customerDispute.thirdPartyBreach\"]");
        By CAMSCaseNumber_Field = By.XPath("//input[@ng-model=\"customerDispute.camsCaseNumber\"]");
        By AmountPrevented_Field = By.XPath("//input[@ng-model=\"customerDispute.amountPreventedByFDS\"]");
        By SubmissionStatus_Dropdown = By.XPath("//select[@ng-model=\"customerDispute.disputeCustomerStatus\"]");
        By ProvisionalCreditReversed_Field = By.XPath("//input[@ng-model=\"customerDispute.provisionalCreditReverseAmount\"]");
        By ResolutionNoticeSent_Dropdown = By.CssSelector("[ng-show] .row:nth-child(6) [aria-haspopup]");
        By MerchantCredit_Field = By.XPath("//input[@ng-model=\"customerDispute.merchantCredit\"]");
        By MerchantCreditDate_Dropdown = By.CssSelector("[ng-show] .row:nth-child(10) [aria-haspopup]");
        By FinalCredit_Field = By.XPath("//input[@ng-model=\"customerDispute.finalCredit\"]");
        By FinalCreditDate_Dropdown = By.CssSelector("[ng-show] .row:nth-child(14) [aria-haspopup]");
        By InsuranceAmount_Field = By.XPath("//input[@ng-model=\"customerDispute.insuranceAmount\"]");
        By ChargebackAmount_Field = By.XPath("//input[@ng-model=\"customerDispute.chargebackAmount\"]");
        By OtherFees_Field = By.XPath("//input[@ng-model=\"customerDispute.otherFees\"]");
        By FeeReversalAmount_Field = By.XPath("//input[@ng-model=\"customerDispute.feeReversalAmount\"]");
        By InterestCreditAmount_Field = By.XPath("//input[@ng-model=\"customerDispute.interestCreditAmount\"]");
        By ProcessorResolutionDate_Dropdown = By.CssSelector("[ng-show] .row:nth-child(26) [aria-haspopup]");
        By ProcessorCaseDate_Dropdown = By.CssSelector("[ng-show] .row:nth-child(28) [aria-haspopup]");
        By Save_Button = By.XPath("//button[@ng-click=\"saveStatus(true)\"]");

        //contacts
        By Contacts_Button = By.CssSelector(".nav.nav-tabs > li:nth-of-type(7) > a");
        By ContactName_Field = By.XPath("//th[.='Contact Name']");
        By ContactName_TextField = By.CssSelector("td:nth-of-type(1) > input[name='contactName']");
        By Reference_Field = By.XPath("//th[.='Reference']");
        By Reference_TextField = By.XPath("//select[@ng-model=\"newContact.reference\"]");
        By Phone_Field = By.XPath("//th[.='Phone']");
        By Phone_TextField = By.XPath("//input[@ng-model=\"newContact.phone\"]");
        By Email_Field = By.XPath("//th[.='Email']");
        By Email_TextField = By.XPath("//input[@ng-model=\"newContact.email\"]");
        By ActionContact_Field = By.XPath("//contact-list//table//th[.='Action']");
        By Download_Button = By.XPath("//button[@ng-click=\"saveContact()\"]");

        //GL Ledger
        By GLLedger_Dropdown = By.CssSelector("[ng-click='changeTab\\(8\\)']");
        By DateLedger_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[5]//table//th[.='Date']");
        By Description_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[5]//table//th[.='Description']");
        By GLAccount_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[5]//table//th[.='GL Account']");
        By Account_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[5]//table//th[.='Account']");
        By TransactionCode_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[5]//table//th[.='Transaction Code']");
        By AmountLedger_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[5]//table//th[.='Amount']");
        By AddGLTransaction_Button = By.CssSelector("div:nth-of-type(5) .btn.btn-default");

        //Documents
        By Document_Dropdown = By.CssSelector("[ng-class='\\[\\{\\'active\\' \\: tab\\=\\=\\=4\\}\\]'] .ng-binding");
        By DeleteDocument_Button = By.CssSelector("document-view .ng-scope:nth-of-type(1) .btn-danger");
        By DownloadDocument_Button = By.CssSelector("document-view .ng-scope:nth-of-type(1) .fa-download");
        By EditDocumentDescription_Button = By.CssSelector("document-view .ng-scope:nth-of-type(1) .fa-edit");

        //Research
        By Research_Dropdown = By.CssSelector("[ng-click='changeTab\\(11\\)']");
        By SubmitCases_Button = By.CssSelector("button[title='Submit Cases']");
        By LinkMultiple_Button = By.CssSelector("button[title='Link Multiple']");
        By ActivityHistoryResearch_Button = By.CssSelector("div:nth-of-type(11) button[title='Activity History']");
        By RefreshReasearch_Button = By.CssSelector("button[title='Refresh']");
        By Actions_Field = By.XPath("//th[.='Actions']");
        By Id_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[2]");
        By MasterCase_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[3]");
        By FraudReport_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[4]");
        By VisaCaseNumber_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[5]");
        By POSResearch_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[6]");
        By PIN_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[7]");
        By ThreeDS_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[8]");
        By Fallback_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[9]");
        By MCC_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[10]");
        By Country_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[11]");
        By Nwk_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[12]");
        By PI_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[13]");
        By RDR_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[14]");
        By TransactionDateResearch_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[15]");
        By AmountResearch_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[16]");
        By MerchantResearch_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[17]");
        By VisaStatus_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[18]");
        By Link_Button = By.CssSelector("button[title='Link'] > .fa.fa-link");
    }
}
