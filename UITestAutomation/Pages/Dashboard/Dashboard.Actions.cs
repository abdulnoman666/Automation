
namespace UITestAutomation
{
    internal partial class Dashboard : Selenium_Methods
    {
        public void DashboardVisibilityAfterClickingAuthenicateButtonOnLoginVerificationDialog()
        {
            FluentWaitForWebElement(Dashboard_Container);
        }

        public void ClickProfileIconOnDashboardPage()
        {
            WaitForWebElementDisplayed(ProfileIconElement);
            ClickOnWebElement(ProfileIconElement);
        }
        public void ClickTransactionProcessesFieldOnProfileIconDropDown()
        {
            WaitForWebElementDisplayed(TransactionProcessesElement);
            ClickOnWebElement(TransactionProcessesElement);
        }

        public void ClickCustomers()
        {
            WaitForWebElementDisplayed(ProfileIconElement);
            ClickOnWebElement(Customer_Field);
        }

        public void ClickDashboard()
        {
            ClickOnWebElement(Dashboard_Button);
            WaitForWebElementDisplayed(Dashboard_Container);
        }
        public void ClickDisputeIcon()
        {
            ClickOnWebElement(DisputeIcon);
            WaitForWebElementDisplayed(DisputeIcon);
        }
        public void ClickLedgerIcon()
        {
            ClickOnWebElement(LedgerIcon);
            WaitForWebElementDisplayed(LedgerIcon);
        }
        public void ClickFraudAlertsIcon()
        {
            ClickOnWebElement(FraudAlertsButton);
            WaitForWebElementDisplayed(FraudAlertsButton);
        }

        public void ClickSubmissions()
        {
            ClickOnWebElement(Submission_Icon);
        }

    }
}
