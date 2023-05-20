using OpenQA.Selenium;

namespace UITestAutomation
{
    internal partial class Dashboard
    {
        By ProfileIconElement = By.CssSelector("a.dropdown-toggle i.fa.fa-user");
        By TransactionProcessesElement = By.XPath("//a[contains(@href,\"processsubmissionsetup\")]");
        By NewDispute = By.XPath("//a[@ng-click='startNewDispute()']");
        By Customer_Field = By.XPath("//a[@href='#/customers']");
        By Dashboard_Button = By.XPath("//div[@class=\"navbar-header\"]");
        By DisputeIcon = By.CssSelector("li:nth-of-type(5) > .dropdown-toggle");
        By LedgerIcon = By.CssSelector("li:nth-of-type(7) > .dropdown-toggle");
        By FraudAlertsButton = By.LinkText("Fraud Alerts");
        By Submission_Icon = By.CssSelector("li:nth-of-type(4) > .dropdown-toggle");
        By Navigation_Bar = By.XPath("//div[@id='myNavbar']");

    }
}
