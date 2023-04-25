
namespace UITestAutomation.Pages.Dashboard
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

        public void ClickSubmissions()
        {
            WaitForWebElementDisplayed(ProfileIconElement);
            ClickOnWebElement(Submission_Field);
        }
    }
}
