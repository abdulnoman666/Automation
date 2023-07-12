
using System.Xml.Linq;

namespace UITestAutomation
{
    internal partial class SubmissionList
    {
        public void ClickSubmissionList()
        {
            ClickTheWebElement(SubmissionList_Dropdown);
            WaitForWebElementDisplayed(ViewSubmission_Button);
        }
        public void ClickReassignSubmissionnButton()
        {
            ClickTheWebElement(ReassignSubmissionn_Button);
            WaitForWebElementDisplayed(AssignCase_Button);
        }

       public void ClickCancelButtononReassignSubmissionnDialog()
       {
                ClickTheWebElement(Cancel_Button);
                WaitForWebElementDisplayed(DeleteSubmission_Button);
       }

        //NewCase
        public void ClickNewCaseButton()
        {
            ClickTheWebElement(NewCase_Button);
            WaitForWebElementDisplayed(TransactionMethod_Dropdown);
        }

        public void EnterValueinTransactionMethodField(string name)
        {
            ClickTheWebElement(TransactionMethod_Dropdown);
            Thread.Sleep(5000);
            ElementToBeSelectedFromDropdown(TransactionMethod_Dropdown, name);
           // EnterValueinWebElement(TransactionMethod_Dropdown, name);
        }

        public void ClickFruadRadioButton()
        {
            WaitForWebElementDisplayed(Fraud_RadioButton);
            ClickTheWebElement(Fraud_RadioButton);
        }

        public void ClickAdvanceSearchButton()
        {
            ClickTheWebElement(AdvanceSearch_Button);
            WaitForWebElementDisplayed(Search_ButtonCustomerSearch);
        }

        public void EnterValueinCustomerFieldonCustomerSearchPage(string name)
        {
            //ClickTheWebElement(CustomerName_TextField);
            //Thread.Sleep(5000);
            //ElementToBeSelectedFromDropdown(CustomerName_TextField, name);
            WaitForWebElementDisplayed(CustomerName_TextField);
            EnterValueinWebElement(CustomerName_TextField, name);
        }

        public void ClickCustomerSearchButton()
        {
            ClickTheWebElement(Search_ButtonCustomerSearch);
            WaitForWebElementDisplayed(SelectCustomer_Button);
        }

        public void ClickSelectCustomerButton()
        {
            ClickTheWebElement(SelectCustomer_Button);
            WaitForWebElementDisplayed(Details_TextArea);
        }

        public void EnterValueinDetailsTextareaonDisputeSubmissionPage(string name)
        {
            EnterValueinWebElement(Details_TextArea, name);
        }

        public void ClickAdditionalTasksField()
        {
            ClickTheWebElement(AdditionalTasks_Field);
            WaitForWebElementDisplayed(TaskName_Field);
        }

        public void EnterValueonAddTaskPage(string value)
        {
            ClickTheWebElement(TaskName_Field);
            Thread.Sleep(5000);
            ElementToBeSelectedFromDropdown(TaskName_Field,value);
            //EnterValueinWebElement(TaskName_Field, value);
        }

        public void ClickSaveButtononAdditionalTasksField()
        {
            ClickTheWebElement(SaveTask_Button);
            WaitForWebElementDisplayed(TransactionList_Field);
        }

        public void ClickTransactionListField()
        {
            ClickTheWebElement(TransactionList_Field);
            WaitForWebElementDisplayed(AmountTransaction_Field);
        }

        public void ClickSaveButtononAddTransactionField()
        {
            ClickTheWebElement(SaveAddTransaction_Button);
            WaitForWebElementDisplayed(Details_TextArea);
        }

        public void ClickNextButton()
        {
            ClickTheWebElement(Next_Button);
            WaitForWebElementDisplayed(YesDisputeForm_Button);
        }

        public void ClickYesButtononDisputeForm()
        {
            ClickTheWebElement(YesDisputeForm_Button);
        }

        public void EnterValueinFiledDateField(string value)
        {
            EnterValueinWebElement(FiledDate_Field, value);
        }

        public void EnterValueinDisputeReasonDateField(string value)
        {
            EnterValueinWebElement(DisputeDate_Field, value);
        }

        public void EnterValueinCityReportField(string value)
        {
            EnterValueinWebElement(CityReport_Field, value);
        }

        public void ClickYesButtonStolenCard()
        {
            ClickTheWebElement(YesStolenCard_Button);
        }

        public void ClickDisputeReasonButton()
        {
            ClickTheWebElement(DiaputeReason_RadioButton);
        }

        public void EnterValueinDateCardClosedField(string value)
        {
            EnterValueinWebElement(DateCardClosed_Field, value);
        }

        public void ClickNoButtononDisputeForm()
        {
            Thread.Sleep(3000);
            ClickTheWebElement(NoClose_Button);
        }

        public void ClickCustomerSignatureForm()
        {
            ClickTheWebElement(CustomerSignatureForm_Button);
            WaitForWebElementDisplayed(Proceed_Button);
        }

        public void ClickElectronicSignatureConsentButton()
        {
            Thread.Sleep(10000);
            ClickTheWebElement(Proceed_Button);
            WaitForWebElementDisplayed(Consent_Checkbox);
        }

        public void ClickConsentCheckbox()
        {
            ClickTheWebElement(Consent_Checkbox);
        }

        public void ClickConfirmButton()
        {
            ClickTheWebElement(Confirm_Button);
            WaitForWebElementDisplayed(Signature_Textarea);
        }

        public void ClickSignatureTextarea()
        {
            ClickTheWebElement(Signature_Textarea);
        }

        public void ClickAcknowldegeCheckbox()
        {
            ClickTheWebElement(Acknowledge_Checkbox);
        }

        public void ClickDoneButton()
        {
            ClickTheWebElement(Done_Button);
        }

        //additional
       
        public void ClickQuestionaireButton()
        {
            ClickTheWebElement(Questionaire_Button);
            WaitForWebElementDisplayed(Questionaire_Field);
        }

        public void ClickFormsButton()
        {
            ClickTheWebElement(Forms_Button);
            WaitForWebElementDisplayed(ESignature_Button);
        }

        public void ClickDisputesButton()
        {
            ClickTheWebElement(Disputes_Button);
            WaitForWebElementDisplayed(PC_Field);
        }

        //public void ClickResearchButton()
        //{
        //    ClickTheWebElement(Research_Dropdown);
        //    WaitForWebElementDisplayed(Nwk_Field);
        //}

        public void ClickCustomerStatusButton()
        {
            ClickTheWebElement(CustomerStatus_Button);
            WaitForWebElementDisplayed(Save_Button);
        }

        public void ClickContactsButton()
        {
            ClickTheWebElement(Contacts_Button);
            WaitForWebElementDisplayed(Email_Field);
        }

        public void ClickGLLedgerButton()
        {
            ClickTheWebElement(GLLedger_Dropdown);
            WaitForWebElementDisplayed(AddGLTransaction_Button);
        }

        public void ClickDocumentButton()
        {
            ClickTheWebElement(Document_Dropdown);
            WaitForWebElementDisplayed(EditDocumentDescription_Button);
        }

    }
}
