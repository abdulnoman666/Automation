namespace UITestAutomation
{
    internal partial class SubmissionsWithAlerts
    {
        public void ClickSubmissionsWithAlerts()
        {
            ClickTheWebElement(SubmissionsWithAlerts_Dropdown);
            WaitForWebElementDisplayed(Deadline_Field);
        }

        //public void ClickEditSubmission()
        //{
        //    ClickTheWebElement(EditSubmission_Button);
        //    WaitForWebElementDisplayed(Public_Field);
        //}

        //public void ClickQuestionaireButton()
        //{
        //    ClickTheWebElement(Questionaire_Button);
        //    WaitForWebElementDisplayed(Signature_Field);
        //}

        //public void ClickFormsButton()
        //{
        //    ClickTheWebElement(Forms_Button);
        //    WaitForWebElementDisplayed(ESignature_Button);
        //}

        //public void ClickDisputesButton()
        //{
        //    ClickTheWebElement(Disputes_Button);
        //    WaitForWebElementDisplayed(PC_Field);
        //}

        //public void ClickResearchButton()
        //{
        //    ClickTheWebElement(Research_Dropdown);
        //    WaitForWebElementDisplayed(Nwk_Field);
        //}

        //public void ClickCustomerStatusButton()
        //{
        //    ClickTheWebElement(CustomerStatus_Button);
        //    WaitForWebElementDisplayed(Save_Button);
        //}

        //public void ClickContactsButton()
        //{
        //    ClickTheWebElement(Contacts_Button);
        //    WaitForWebElementDisplayed(Email_Field);
        //}

        //public void ClickGLLedgerButton()
        //{
        //    ClickTheWebElement(GLLedger_Dropdown);
        //    WaitForWebElementDisplayed(AddGLTransaction_Button);
        //}

        //public void ClickDocumentButton()
        //{
        //    ClickTheWebElement(Document_Dropdown);
        //    WaitForWebElementDisplayed(EditDocumentDescription_Button);
        //}
    }
}
