using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class DailyLedger
    {
        By DailyLedgerOption = By.XPath("//a[text='Daily Ledger']");
        By RefreshLedger = By.XPath("//button[@ng-click='refreshLedger()']");
        By Date = By.XPath("//th[1]");
        By Account = By.XPath("//th[2]");
        By Customer = By.XPath("//th[3]");
        By Amount = By.XPath("//th[4]");
        By Type = By.XPath("//th[5]");
        By TranCode = By.XPath("//th[6]");
        By Description = By.XPath("//th[7]");
    }
}
