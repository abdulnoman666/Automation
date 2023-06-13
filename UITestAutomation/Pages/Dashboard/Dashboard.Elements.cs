using OpenQA.Selenium;

namespace UITestAutomation
{
    internal partial class Dashboard
    {
        By ProfileIconElement = By.XPath("(//i[@class=\"fa fa-user\"])[1]");
        By TransactionProcessesElement = By.XPath("//a[contains(@href,\"processsubmissionsetup\")]");
        By NewDispute = By.XPath("//a[@ng-click='startNewDispute()']");
        By Customer_Field = By.XPath("//a[@href='#/customers']");
        By Dashboard_Button = By.XPath("//div[@class=\"navbar-header\"]");
        By DisputeIcon = By.CssSelector("li:nth-of-type(5) > .dropdown-toggle");
        By LedgerIcon = By.CssSelector("li:nth-of-type(7) > .dropdown-toggle");
        By FraudAlertsButton = By.LinkText("Fraud Alerts");
        By Submission_Icon = By.XPath("(//a[@class=\"dropdown-toggle\"])[1]");
        By Navigation_Bar = By.XPath("//div[@id='myNavbar']");

    }
}
