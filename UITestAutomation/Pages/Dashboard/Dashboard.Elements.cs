using OpenQA.Selenium;

namespace UITestAutomation.Pages.Dashboard
{
    internal partial class Dashboard
    {
        By ProfileIconElement = By.CssSelector("a.dropdown-toggle i.fa.fa-user");
        By TransactionProcessesElement = By.XPath("//a[contains(@href,\"processsubmissionsetup\")]");
        By Dashboard_Container = By.XPath("//div[@class='container']");
        By Customer_Field = By.XPath("//a[@href='#/customers']");
        By Dashboard_Button = By.CssSelector("[ng-show] [href='\\#\\/dashboard']");

    }
}
