using OpenQA.Selenium;

namespace UITestAutomation
{
    internal partial class SubmissionsWithAlerts
    {
        By SubmissionsWithAlerts_Dropdown = By.XPath("//a[text()=\"Submissions with Alerts\"]");
        //UI Control
        By Settings_Button = By.XPath("//button[@title=\"Settings\"]");
        By RefreshAlerts_Button = By.XPath("//button[@ng-click=\"refresh()\"]");
        By EnterPage_TextField = By.XPath("//input[@ng-model=\"pageNo\"]");
        By Go_Button = By.XPath("//span[text()=\"Go\"]");
        By EditSubmission_Button = By.XPath("//button[@title=\"Edit Submission\"]");

        //Fields
        By Action_Field = By.XPath("(//th[1])[1]");
        By ID_Field = By.XPath("//a[@ng-click=\"sorting('customId')\"]");
        By ID_TextField = By.XPath("//input[@ng-model=\"$.customerDispute.id\"]");
        By Customer_Field = By.XPath("//th[@ng-show=\"order.selectedColumns.indexOf('Customer')!=-1\"]");
        By Customer_TextField = By.XPath("//input[@ng-model=\"$.customerName\"]");
        By Status_Field = By.XPath("//a[@ng-click=\"sorting('customerDispute.status')\"]");
        By Status_TextField = By.XPath("//input[@ng-model=\"$.customerDispute.status\"]");
        By Source_Field = By.XPath("//a[@ng-click=\"sorting('source')\"]");
        By Source_TextField = By.XPath("//input[@ng-model=\"$.source\"]");
        By Alert_Field = By.XPath("//a[@ng-click=\"sorting('alertName')\"]");
        By Alert_TextField = By.XPath("//input[@ng-model=\"$.alertName\"]");
        By AlertType_Field = By.XPath("//a[@ng-click=\"sorting('alertTypeString')\"]");
        By AlertType_TextField = By.XPath("//input[@ng-model=\"$.alertTypeString\"]");
        By Deadline_Field = By.XPath("//a[@ng-click=\"sorting('deadline')\"]");
        By AssignedTo_Field = By.XPath("//a[@ng-click=\"sorting('assignedTo')\"]");

        ////editsubmission
        ////submission info
        //By Next_Button = By.XPath("//button[@ng-click=\"next()\"]");
        //By PrintLetter_Button = By.CssSelector("[ng-show='tab\\=\\=1'] [ng-show='showLabel']");
        //By RunAutomation_Button = By.XPath("//div[@class='panel-heading row']/div[1]/div[@class='dropdown']/button[@title='Select Automation']");
        //By EditCustomer_Button = By.XPath("//button[@ng-click=\"editCustomer()\"]");
        //By AllSubmission_Button = By.CssSelector("div:nth-of-type(8) button[title='All Submission']");
        //By ActivityHistory_Button = By.CssSelector("div:nth-of-type(8) button[title='Activity History']");
        //By RefreshSubmissions_Button = By.CssSelector("div:nth-of-type(8) button[title='Refresh Submissions']");
        //By Transactions_Button = By.CssSelector("div[title='Transactions'] > .btn.btn-info.dropdown-toggle.glyphicon.glyphicon-th");
        //By SaveComments_Button = By.XPath("//button[@ng-click=\"updateNotes()\"]");
        //By AddNote_Button = By.XPath("//button[@ng-click=\"addNoteDialog()\"]");
        //By ViewAll_Button = By.CssSelector(".ng-binding [class] [data-toggle='modal']:nth-child(3)");
        //By CalculateInterest_Button = By.XPath("//button[@data-target=\"#calculateInterest\"]");

        //By AlertSubmission_Field = By.CssSelector("th:nth-of-type(1) > a");
        //By Type_Field = By.CssSelector("th:nth-of-type(2) > a");
        //By DeadlineSubmission_Field = By.CssSelector("th:nth-of-type(3) > a");

        //By CommentsandResolution_Field = By.CssSelector(".col-lg-4 > textarea[name='notes']");
        //By Public_Field = By.CssSelector("[width='55']");
        //By Date_Field = By.CssSelector(".ng-binding [width='120']");
        //By CreatedBy_Field = By.CssSelector("[width='150']");
        //By Notes_Field = By.XPath("//div[@class='col-lg-8']/div/table//th[.='Notes']");

        //By PreAuth_Field = By.XPath("//th[.='Pre-Auth']");
        //By DateTransactions_Field = By.XPath("//div[@class='panel-body row']/div[4]/div[@class='panel panel-default']/div[@class='panel-body']/table//th[.='Date']");
        //By DeadlineTransaction_Field = By.XPath("//th[.='Deadline']");
        //By POS_Field = By.XPath("//div[@class='panel-body row']/div[4]/div[@class='panel panel-default']/div[@class='panel-body']/table//th[.='POS']");
        //By FT_Field = By.XPath("//th[.='FT']");
        //By Amount_Field = By.XPath("//div[@class='panel-body row']/div[4]/div[@class='panel panel-default']/div[@class='panel-body']/table//th[.='Amount']");
        //By DisputedAmount_Field = By.XPath("//th[.='Disputed Amount']");
        //By Merchant_Field = By.CssSelector("[width='250px']");
        //     By DoNotSend_Field = By.XPath("//th[.='Do Not Send']");
        //     By ConsumerLiability_Field = By.XPath("//th[.='Consumer Liability']");
        //     By ProvisionalCredit_Field = By.XPath("//th[.='Provisional Credit']");
        //     By Reason_Field = By.XPath("//th[.='Reason']");

        ////questionaire
        //By Questionaire_Button = By.CssSelector(".nav.nav-tabs > li:nth-of-type(2) > a");
        //By Signature_Field = By.CssSelector(".col-lg-12.col-md-12.col-sm-12.col-xs-12");
        //By Acknowledged_Checkbox = By.CssSelector("[ng-if='customerDispute\\.letterWorkflowId \\=\\=\\= 0'] .ng-scope");

        ////forms
        //By Forms_Button = By.CssSelector(".nav.nav-tabs > li:nth-of-type(3) > a");
        //By SelectFormtoView_Button = By.CssSelector("finboa-input-form-dropdown [ng-show='showLabel']");
        //By SaveFormData_Button = By.XPath("//button[@ng-click='saveFormInput()']");
        //By SavePDF_Button = By.XPath("//button[@ng-click='printForm()']");
        //By ESignature_Button = By.XPath("//button[@ng-click='openConsentDialog()']");

        ////disputes
        //By Disputes_Button = By.CssSelector("[ng-click='changeTab\\(3\\)']");
        //By SelectAutomation_Button = By.CssSelector(".btn-group.dropdown > button[title='Select Automation']");
        //By RunSelectedWorkflowAutomation_Button = By.CssSelector("button[title='Run Selected Workflow Automation']");
        //By Settingsdisputes_Button = By.CssSelector("button[title='Settings']");
        //By HideClosedDisputes_Button = By.CssSelector(".page-link");
        //By SubmissionInfo_Button = By.CssSelector(".collapsed");
        //By Actiondisputes_Field = By.CssSelector("[ng-init] [width='170px']");
        //By IDdisputes_Field = By.CssSelector("[ng-click='sortTable\\=sortTable\\=\\=\\'id\\'\\?\\'-id\\'\\:\\'id\\'']");
        //By TransactionDate_Field = By.CssSelector("[ng-click='sortTable\\=sortTable\\=\\=\\'transactionDate\\'\\?\\'-transactionDate\\'\\:\\'transactionDate\\'']");
        //By Amountdisputes_Field = By.CssSelector("[ng-click='sortTable\\=sortTable\\=\\=\\'transactionAmount\\'\\?\\'-transactionAmount\\'\\:\\'transactionAmount\\'']");
        //By Merchantdisputes_Field = By.CssSelector("[ng-click='sortTable\\=sortTable\\=\\=\\'merchantName\\'\\?\\'-merchantName\\'\\:\\'merchantName\\'']");
        //By PC_Field = By.CssSelector("[ng-click='sortTable\\=sortTable\\=\\=\\'provisionalCreditAmount\\'\\?\\'-provisionalCreditAmount\\'\\:\\'provisionalCreditAmount\\'']");
        //By Statusdisputes_Field = By.CssSelector("[ng-init] [ng-show='order\\.selectedColumns\\.indexOf\\(\\'Status\\'\\)\\!\\=-1']");
        //By ResearchDetail_Field = By.CssSelector("[ng-init] [ng-show='order\\.selectedColumns\\.indexOf\\(\\'Research Detail\\'\\)\\!\\=-1']");
        //By ResearchDetail_Textbox = By.XPath("//select[@ng-model=\"dispute.researchStatus\"]");
        //By Notesdisputes_Field = By.CssSelector("[ng-init] [ng-show='order\\.selectedColumns\\.indexOf\\(\\'Notes\\'\\)\\!\\=-1']");
        //By Notes_Textbox = By.XPath("//input[@ng-model=\"dispute.comments\"]");

        ////Customer status
        //By CustomerStatus_Button = By.CssSelector("[ng-click='changeTab\\(6\\)']");
        //By CaseNumber_Field = By.XPath("//input[@ng-model=\"customerDispute.caseReference\"]");
        //By ThirdPartyBreachSource_Dropdown = By.XPath("//select[@ng-model=\"customerDispute.thirdPartyBreach\"]");
        //By CAMSCaseNumber_Field = By.XPath("//input[@ng-model=\"customerDispute.camsCaseNumber\"]");
        //By AmountPrevented_Field = By.XPath("//input[@ng-model=\"customerDispute.amountPreventedByFDS\"]");
        //By SubmissionStatus_Dropdown = By.XPath("//select[@ng-model=\"customerDispute.disputeCustomerStatus\"]");
        //By ProvisionalCreditReversed_Field = By.XPath("//input[@ng-model=\"customerDispute.provisionalCreditReverseAmount\"]");
        //By ResolutionNoticeSent_Dropdown = By.CssSelector("[ng-show] .row:nth-child(6) [aria-haspopup]");
        //By MerchantCredit_Field = By.XPath("//input[@ng-model=\"customerDispute.merchantCredit\"]");
        //By MerchantCreditDate_Dropdown = By.CssSelector("[ng-show] .row:nth-child(10) [aria-haspopup]");
        //By FinalCredit_Field = By.XPath("//input[@ng-model=\"customerDispute.finalCredit\"]");
        //By FinalCreditDate_Dropdown = By.CssSelector("[ng-show] .row:nth-child(14) [aria-haspopup]");
        //By InsuranceAmount_Field = By.XPath("//input[@ng-model=\"customerDispute.insuranceAmount\"]");
        //By ChargebackAmount_Field = By.XPath("//input[@ng-model=\"customerDispute.chargebackAmount\"]");
        //By OtherFees_Field = By.XPath("//input[@ng-model=\"customerDispute.otherFees\"]");
        //By FeeReversalAmount_Field = By.XPath("//input[@ng-model=\"customerDispute.feeReversalAmount\"]");
        //By InterestCreditAmount_Field = By.XPath("//input[@ng-model=\"customerDispute.interestCreditAmount\"]");
        //By ProcessorResolutionDate_Dropdown = By.CssSelector("[ng-show] .row:nth-child(26) [aria-haspopup]");
        //By ProcessorCaseDate_Dropdown = By.CssSelector("[ng-show] .row:nth-child(28) [aria-haspopup]");
        //By Save_Button = By.XPath("//button[@ng-click=\"saveStatus(true)\"]");

        ////contacts
        //By Contacts_Button = By.CssSelector(".nav.nav-tabs > li:nth-of-type(7) > a");
        //By ContactName_Field = By.XPath("//th[.='Contact Name']");
        //By ContactName_TextField = By.CssSelector("td:nth-of-type(1) > input[name='contactName']");
        //By Reference_Field = By.XPath("//th[.='Reference']");
        //By Reference_TextField = By.XPath("//select[@ng-model=\"newContact.reference\"]");
        //By Phone_Field = By.XPath("//th[.='Phone']");
        //By Phone_TextField = By.XPath("//input[@ng-model=\"newContact.phone\"]");
        //By Email_Field = By.XPath("//th[.='Email']");
        //By Email_TextField = By.XPath("//input[@ng-model=\"newContact.email\"]");
        //By ActionContact_Field = By.XPath("//contact-list//table//th[.='Action']");
        //By Download_Button = By.XPath("//button[@ng-click=\"saveContact()\"]");

        ////GL Ledger
        //By GLLedger_Dropdown = By.CssSelector("[ng-click='changeTab\\(8\\)']");
        //By DateLedger_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[5]//table//th[.='Date']");
        //By Description_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[5]//table//th[.='Description']");
        //By GLAccount_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[5]//table//th[.='GL Account']");
        //By Account_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[5]//table//th[.='Account']");
        //By TransactionCode_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[5]//table//th[.='Transaction Code']");
        //By AmountLedger_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/div[5]//table//th[.='Amount']");
        //By DeleteLedgerEntry_Button = By.CssSelector(".glyphicon-trash");
        //By AddGLTransaction_Button = By.CssSelector("div:nth-of-type(5) .btn.btn-default");

        ////Documents
        //By Document_Dropdown = By.CssSelector("[ng-class='\\[\\{\\'active\\' \\: tab\\=\\=\\=4\\}\\]'] .ng-binding");
        //By DeleteDocument_Button = By.CssSelector("document-view .ng-scope:nth-of-type(1) .btn-danger");
        //By DownloadDocument_Button = By.CssSelector("document-view .ng-scope:nth-of-type(1) .fa-download");
        //By EditDocumentDescription_Button = By.CssSelector("document-view .ng-scope:nth-of-type(1) .fa-edit");

        ////Research
        //By Research_Dropdown = By.CssSelector("[ng-click='changeTab\\(11\\)']");
        //By SubmitCases_Button = By.CssSelector("button[title='Submit Cases']");
        //By LinkMultiple_Button = By.CssSelector("button[title='Link Multiple']");
        //By ActivityHistoryResearch_Button = By.CssSelector("div:nth-of-type(11) button[title='Activity History']");
        //By Refresh_Button = By.CssSelector("button[title='Refresh']");
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
