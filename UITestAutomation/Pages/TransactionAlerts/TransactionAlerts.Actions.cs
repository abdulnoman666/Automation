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
            ClickOnWebElement(AddNewTransactionAlert);
            WaitForWebElementDisplayed(AddNewTransactionAlert);
        }
    }
}
