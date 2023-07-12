using OpenQA.Selenium;

namespace UITestAutomation
{
    internal partial class SubmissionList
    {
        By SubmissionList_Dropdown = By.XPath("//a[@href='#/processorcustomerdisputes']");

        //UI Controls (Submission Page)
        By NewCase_Button = By.XPath("//button[@title=\"New Case\"]");
        By Settings_Button = By.XPath("//button[@title=\"Settings\"]");
        By Search_Button = By.XPath("(//button[@type=\"button\"])[4]");
        By Refresh_Button = By.XPath("//button[@ng-click=\"refreshDisputes()\"]");
        By AllOriginators_Textfield = By.XPath("(//span[@ng-hide=\"$select.isEmpty()\"])[2]");
        By AllAssignee_Textfield = By.XPath("(//span[@ng-hide=\"$select.isEmpty()\"])[1]");
        By EnterPage_Textfield = By.XPath("//input[@placeholder=\"Enter Page\"]");
        By Go_Button = By.XPath("//span[text()=\"Go\"]");
        By ShowClosedSubmissions_Button = By.XPath("//span[@class=\"page-link\"]");
        By ViewSubmission_Button = By.XPath("//span[@class=\"glyphicon glyphicon-edit\"]");
        By ReassignSubmissionn_Button = By.XPath("//span[@class=\"glyphicon glyphicon-tag\"]");
        By DeleteSubmission_Button = By.XPath("//button[@title=\"Delete or Withdraw Submission\"]");

        //Fields (Submission Page)
        By Action_Field = By.XPath("//th[1]");
        By Type_Field = By.XPath("//a[@ng-click=\"sorting('disputeType')\"]");
        By Type_TextField = By.XPath("//select[@ng-model=\"$.disputeType\"]");
        By Customer_Field = By.XPath("//a[@ng-click=\"sorting('customerName')\"]");
        By Customer_TextField = By.XPath("//input[@ng-model=\"$.customerName\"]");
        By Workflow_Field = By.XPath("//a[@ng-click=\"sorting('source')\"]");
        By Workflow_TextField = By.XPath("//input[@ng-model=\"$.source\"]");
        By Reported_Field = By.XPath("//a[@ng-click=\"sorting('reportedOn')\"]");
        By Days_Field = By.XPath("//th[@ng-show=\"order.selectedColumns.indexOf('Days')!=-1\"]");
        By ID_Field = By.XPath("//th[@ng-show=\"order.selectedColumns.indexOf('ID')!=-1\"]");
        By IDText_Field = By.XPath("//input[@ng-model=\"$.id\"]");
        By Status_Field = By.XPath("//a[@ng-click=\"sorting('status')\"]");
        By Status_Textbox = By.XPath("//input[@ng-model=\"$.status\"]");
        By AccountType_Field = By.XPath("//th[@ng-show=\"order.selectedColumns.indexOf('AccountType')!=-1\"]");
        By AcountType_TextField = By.XPath("//select[@ng-model=\"$.accountType\"]");
        By Total_Field = By.XPath("//a[@ng-click=\"sorting('sortTotal')\"]");
        By Total_TextboxField = By.XPath("//input[@ng-model=\"totalFilter\"]");
        By ItemCount_Field = By.XPath("//a[@ng-click=\"sorting('ItemCount')\"]");
        By AssignedTo_Field = By.XPath("//th[@ng-show=\"order.selectedColumns.indexOf('AssignedTo')!=-1\"]");

        //reassign page
        By Processors_Button = By.XPath("(//span[@ng-show=\"$select.isEmpty()\"])[1]");
        By Cancel_Button = By.XPath("(//button[@ng-click=\"close()\"])[2]");
        By AssignCase_Button = By.XPath("//button[@ng-click=\"save(composeForm.$valid)\"]");

        //Dispute Submission
        By TransactionMethod_Dropdown = By.XPath("//select[@ng-model=\"selectedWorkflow\"]");
        By Fraud_RadioButton = By.XPath("(//input[@ng-model=\"customerDispute.disputeType\"])[1]");
        By AdvanceSearch_Button = By.XPath("(//button[@title=\"Advanced Search\"])[1]");
        By CustomerName_TextField = By.XPath("//input[@ng-model=\"searchCustomerModel.customerName\"]");
        By Search_ButtonCustomerSearch = By.XPath("//button[@ng-click=\"searchCustomers()\"]");
        By SelectCustomer_Button = By.XPath("//button[@ng-click=\"selectCust(cust)\"]");
        By Details_TextArea = By.XPath("//textarea[@ng-model=\"customerDispute.disputeReason\"]");
        By AdditionalTasks_Field = By.XPath("(//span[@class=\"pull-right glyphicon glyphicon-plus-sign\"])[1]");
        By TaskName_Field = By.XPath("//select[@ng-model=\"task.taskType\"]");
        By SaveTask_Button = By.XPath("//button[@ng-click=\"ok()\"]");
        By TransactionList_Field = By.XPath("(//span[@class=\"pull-right glyphicon glyphicon-plus-sign\"])[2]");
        By AmountTransaction_Field = By.XPath("//input[@ng-model=\"transaction.amount\"]");
        By DisputedAmountTransaction_Field = By.XPath("//input[@ng-model=\"transaction.disputedAmount\"]");
        By MerchantTransaction_Field = By.XPath("//input[@ng-model=\"transaction.merchant\"]");
        By DetailTransaction_Field = By.XPath("//input[@ng-model=\"transaction.detail\"]");
        By SaveAddTransaction_Button = By.XPath("//button[@ng-click=\"ok()\"]");
        By Next_Button = By.XPath("(//button[@ng-click=\"saveDisputes(infoForm)\"])[2]");
        By YesDisputeForm_Button = By.XPath("(//input[@ng-model=\"val\"])[1]");
        By YesStolenCard_Button = By.XPath("(//input[@name=\"policeReport\"])[1]");
        By FiledDate_Field = By.XPath("(//input[@class=\"md-datepicker-input\"])[2]");
        By DisputeDate_Field = By.XPath("(//input[@ng-required=\"inputRequired\"])[3]");
        By CityReport_Field = By.XPath("//input[@id=\"cityReportFiled\"]");
        By DiaputeReason_RadioButton = By.XPath("//input[@id=\"disputeOption\"]");
        By NoClose_Button = By.XPath("(//input[@id=\"cardClosed\"])[2]");
        By DateCardClosed_Field = By.XPath("//input[@id=\"closedDate\"]");
        By CustomerSignatureForm_Button = By.XPath("(//button[@ng-click=\"openCustomerAckForm()\"])[2]");
        By Proceed_Button = By.XPath("//button[@ng-click=\"openConsentDialog()\"]");
        By Consent_Checkbox = By.XPath("//input[@ng-model=\"consent\"]");
        By Confirm_Button = By.XPath("(//button[@ng-click=\"close()\"])[2]");
        By Signature_Textarea = By.XPath("//canvas[@id=\"customerSignature\"]");
        By Acknowledge_Checkbox = By.XPath("//input[@ng-model=\"acknowledged\"]");
        By Done_Button = By.XPath("(//button[@ng-click=\"done(acknowledged)\"])[2]");

        //Additional
        //editsubmission
        //submission info
        By SelectPCCalculation = By.XPath("//button[@title=\"Calculate Provisional Credit\"]");
        By EditSubmission_Button = By.XPath("//button[@ng-click=\"editNewDispute(customerDispute)\"]");
        By ProcessTransactions_Button = By.XPath("//a[text()=\"Process Transactions\"]");
        By PrintLetter_Button = By.XPath("(//span[@ng-show=\"showLabel\"])[3]");
        By RunAutomation_Button = By.XPath("(//button[@title=\"Select Automation\"])[1]");
        By EditCustomer_Button = By.XPath("//button[@ng-click=\"editCustomer()\"]");
        By AllSubmission_Button = By.XPath("(//button[@title=\"All Submission\"])[6]");
        By ActivityHistory_Button = By.XPath("(//button[@ng-click=\"openHistory()\"])[6]");
        By RefreshSubmissions_Button = By.XPath("(//button[@title=\"Refresh Submissions\"])[6]");
        By Transactions_Button = By.XPath("//button[@class=\"btn btn-info glyphicon glyphicon-th dropdown-toggle\"]");
        By SaveComments_Button = By.XPath("//button[@ng-click=\"updateNotes()\"]");
        By AddNote_Button = By.XPath("//button[@ng-click=\"addNoteDialog()\"]");
        By ViewAll_Button = By.XPath("//button[@data-target=\"#notes\"]");
        By CalculateInterest_Button = By.XPath("//button[@data-target=\"#calculateInterest\"]");

        By CommentsandResolution_Field = By.XPath("//textarea[@ng-model=\"customerDispute.notes\"]");
        By Public_Field = By.XPath("(//th[.='Public'])[1]");
        By Date_Field = By.XPath("(//th[.='Date'])[2]");
        By CreatedBy_Field = By.XPath("(//th[.='Created By'])[1]");
        By Notes_Field = By.XPath("(//th[.='Notes'])[1]");

        By Status_FieldAdditionalTask = By.XPath("(//th[.='Status'])[1]");
        By TaskName_FieldAdditionalTask = By.XPath("//th[.='Task Name']");
        By CreatedOn_FieldAdditionalTask = By.XPath("//th[.='Created On']");
        By AssignedTo_FieldAdditionalTask = By.XPath("//th[.='Assigned To']");
        By AssignedOn_FieldAdditionalTask = By.XPath("//th[.='Assigned On']");
        By ClosedOn_FieldAdditionalTask = By.XPath("//th[.='Closed On']");

        By PreAuth_Field = By.XPath("(//th[1])[6]");
        By DateTransactions_Field = By.XPath("(//th[2])[6]");
        By DeadlineTransaction_Field = By.XPath("(//th[3])[6]");
        By POS_Field = By.XPath("(//th[.='POS'])[1]");
        By FT_Field = By.XPath("(//th[.='FT'])[1]");
        By Amount_Field = By.XPath("(//th[.='Amount'])[2]");
        By DisputedAmount_Field = By.XPath("//th[.='Disputed Amount']");
        By Merchant_Field = By.XPath("(//th[.='Merchant'])[1]");
        By DoNotSend_Field = By.XPath("//th[.='Do Not Send']");
       
        //questionaire
        By Questionaire_Button = By.XPath("//a[@ng-click=\"changeTab(7)\"]");
        By Questionaire_Field = By.XPath("//div[@class=\"finboa-template ng-scope\"]");
        By SaveQuestionnairetoPDF_Button = By.XPath("//button[@ng-click=\"saveQuestionnairetoPDF();\"]");
        By PrintQuestionaire_Button = By.XPath("//button[@ng-click=\"printLetterQuestionnaire();\"]");
        By EmailQuestionaire_Button = By.XPath("//button[@ng-click=\"emailQuestionnaire()\"]");

        //forms
        By Forms_Button = By.XPath("//a[@ng-click=\"changeTab(9)\"]");
        By SelectFormtoView_Button = By.XPath("(//span[@ng-show=\"showLabel\"])[1]");
        By SaveFormData_Button = By.XPath("//button[@ng-click='saveFormInput()']");
        By SavePDF_Button = By.XPath("//button[@ng-click='printForm()']");
        By ESignature_Button = By.XPath("//button[@ng-click='openConsentDialog()']");

        //disputes
        By Disputes_Button = By.XPath("//a[@ng-click=\"changeTab(3)\"]");
        By SelectAutomation_Button = By.XPath("(//button[@title=\"Select Automation\"])[2]");
        By RunSelectedWorkflowAutomation_Button = By.XPath("//button[@title=\"Run Selected Workflow Automation\"]");
        By Settingsdisputes_Button = By.XPath("//button[@title=\"Settings\"]");
        By HideClosedDisputes_Button = By.XPath("//span[@class=\"page-link\"]");
        By SubmissionInfo_Button = By.XPath("//button[@ng-click=\"submissionHeaderAccordionExpanded = !submissionHeaderAccordionExpanded\"]");
        By Actiondisputes_Field = By.XPath("(//th[.='Action'])[2]");
        By IDdisputes_Field = By.XPath("(//th[.=' Id'])");
        By TransactionDate_Field = By.XPath("(//th[.=' Transaction Date'])");
        By Amountdisputes_Field = By.XPath("(//th[.=' Amount'])");
        By Merchantdisputes_Field = By.XPath("(//th[.=' Merchant'])");
        By PC_Field = By.XPath("(//th[.=' PC'])");
        By Statusdisputes_Field = By.XPath("(//th[.='Status'])[2]");
        By ResearchDetail_Field = By.XPath("//th[.='Research Detail']");
        By Notesdisputes_Field = By.XPath("(//th[.='Notes'])[2]");

        //Customer status
        By CustomerStatus_Button = By.XPath("//a[@ng-click=\"changeTab(6)\"]");
        By CaseNumber_Field = By.XPath("//input[@ng-model=\"customerDispute.caseReference\"]");
        By ThirdPartyBreachSource_Dropdown = By.XPath("//select[@ng-model=\"customerDispute.thirdPartyBreach\"]");
        By CAMSCaseNumber_Field = By.XPath("//input[@ng-model=\"customerDispute.camsCaseNumber\"]");
        By AmountPrevented_Field = By.XPath("//input[@ng-model=\"customerDispute.amountPreventedByFDS\"]");
        By SubmissionStatus_Dropdown = By.XPath("//select[@ng-model=\"customerDispute.disputeCustomerStatus\"]");
        By ProvisionalCreditReversed_Field = By.XPath("//input[@ng-model=\"customerDispute.provisionalCreditReverseAmount\"]");
        By ResolutionNoticeSent_Dropdown = By.XPath("(//input[@class=\"md-datepicker-input\"])[1]");
        By MerchantCredit_Field = By.XPath("//input[@ng-model=\"customerDispute.merchantCredit\"]");
        By MerchantCreditDate_Dropdown = By.XPath("(//input[@class=\"md-datepicker-input\"])[2]");
        By FinalCredit_Field = By.XPath("//input[@ng-model=\"customerDispute.finalCredit\"]");
        By FinalCreditDate_Dropdown = By.XPath("(//input[@class=\"md-datepicker-input\"])[3]");
        By InsuranceAmount_Field = By.XPath("//input[@ng-model=\"customerDispute.insuranceAmount\"]");
        By ChargebackAmount_Field = By.XPath("//input[@ng-model=\"customerDispute.chargebackAmount\"]");
        By OtherFees_Field = By.XPath("//input[@ng-model=\"customerDispute.otherFees\"]");
        By FeeReversalAmount_Field = By.XPath("//input[@ng-model=\"customerDispute.feeReversalAmount\"]");
        By InterestCreditAmount_Field = By.XPath("//input[@ng-model=\"customerDispute.interestCreditAmount\"]");
        By ProcessorResolutionDate_Dropdown = By.XPath("(//input[@class=\"md-datepicker-input\"])[4]");
        By ProcessorCaseDate_Dropdown = By.XPath("(//input[@class=\"md-datepicker-input\"])[5]");
        By Save_Button = By.XPath("//button[@ng-click=\"saveStatus(true)\"]");

        //contacts
        By Contacts_Button = By.XPath("//a[@ng-click=\"changeTab(10)\"]");
        By ContactName_Field = By.XPath("//th[.='Contact Name']");
        By ContactName_TextField = By.XPath("//input[@ng-model=\"newContact.contactName\"]");
        By Reference_Field = By.XPath("//th[.='Reference']");
        By Reference_TextField = By.XPath("//select[@ng-model=\"newContact.reference\"]");
        By Phone_Field = By.XPath("//th[.='Phone']");
        By Phone_TextField = By.XPath("//input[@ng-model=\"newContact.phone\"]");
        By Email_Field = By.XPath("//th[.='Email']");
        By Email_TextField = By.XPath("//input[@ng-model=\"newContact.email\"]");
        By ActionContact_Field = By.XPath("//contact-list//table//th[.='Action']");
        By Download_Button = By.XPath("//button[@ng-click=\"saveContact()\"]");

        //GL Ledger
        By GLLedger_Dropdown = By.XPath("//a[@ng-click=\"changeTab(8)\"]");
        By DateLedger_Field = By.XPath("(//th[.='Date'])[1]");
        By Description_Field = By.XPath("(//th[.='Description'])[1]");
        By GLAccount_Field = By.XPath("(//th[.='GL Account'])[1]");
        By Account_Field = By.XPath("(//th[.='Account'])[1]");
        By TransactionCode_Field = By.XPath("(//th[.='Transaction Code'])[1]");
        By AmountLedger_Field = By.XPath("(//th[.='Amount'])[1]");
        By AddGLTransaction_Button = By.XPath("//button[@data-target=\"#addGLEntry\"]");

        //Documents
        By Document_Dropdown = By.XPath("//a[@ng-click=\"changeTab(4)\"]");
        By DeleteDocument_Button = By.XPath("//button[@ng-click=\"confirmDelete($event, doc.id)\"]");
        By DownloadDocument_Button = By.XPath("//button[@ng-click=\"downloadDocument(doc)\"]");
        By EditDocumentDescription_Button = By.XPath("//button[@ng-click=\"editDocument(doc)\"]");

        //Research
        //By Research_Dropdown = By.XPath("//a[@ng-click=\"changeTab(11)\"]");
        //By SubmitCases_Button = By.XPath("//button[@ng-click=\"submitCases()\"]");
        //By LinkMultiple_Button = By.XPath("//button[@ng-click=\"multipleSelect()\"]");
        //By ActivityHistoryResearch_Button = By.CssSelector("div:nth-of-type(11) button[title='Activity History']");
        //By RefreshReasearch_Button = By.CssSelector("button[title='Refresh']");
        //By Actions_Field = By.XPath("//th[.='Actions']");
        //By Id_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[2]");
        //By MasterCase_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[3]");
        //By FraudReport_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[4]");
        //By VisaCaseNumber_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[5]");
        //By POSResearch_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[6]");
        //By PIN_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[7]");
        //By ThreeDS_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[8]");
        //By Fallback_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[9]");
        //By MCC_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[10]");
        //By Country_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[11]");
        //By Nwk_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[12]");
        //By PI_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[13]");
        //By RDR_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[14]");
        //By TransactionDateResearch_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[15]");
        //By AmountResearch_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[16]");
        //By MerchantResearch_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[17]");
        //By VisaStatus_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[11]//table/thead/tr/th[18]");
        //By Link_Button = By.CssSelector("button[title='Link'] > .fa.fa-link");
    }
}
