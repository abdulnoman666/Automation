namespace UITestAutomation
{
    internal partial class TransactionAlerts : Selenium_Methods
    {
        public void ClickTransactionAlertsButton()
        {
            WaitForWebElementDisplayed(TransactionAlertsButton);
            ClickOnWebElement(TransactionAlertsButton);
        }
        public void ClickAddNewTransactionAlertButton()
        {
            WaitForWebElementDisplayed(AddNewTransactionAlert);
            ClickOnWebElement(AddNewTransactionAlert);
        }

        public void ClickCloseButtononAddNewTransactionAlert()
        {
            WaitForWebElementDisplayed(CloseButton);
            ClickOnWebElement(CloseButton);
           
        }
    }
}
