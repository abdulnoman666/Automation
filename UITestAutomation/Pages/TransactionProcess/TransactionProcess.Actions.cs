namespace UITestAutomation
{
    internal partial class TransactionProcess : Selenium_Methods
    {
        public void ClickTransactionProcesses()
        {
            ClickTheWebElement(TransactionProcess_Dropdown);
            WaitForWebElementDisplayed(EditTransaction_Button);
        }

        public void ClickAddTransactionProcessesButton()
        {
            ClickOnWebElement(AddTransactionProcesses_Button);
            WaitForWebElementDisplayed(Name_Textbox);
        }

        public void ClickSaveButton()
        {
            ClickOnWebElement(Save_Button);
            WaitForWebElementDisplayed(AddTransactionProcesses_Button);
        }
    }
}
