using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class DailyLedger
    {
        By DailyLedgerOption = By.LinkText("Daily Ledger");
        By RefreshLedger = By.CssSelector("button[title='Refresh Ledger']");
        By Date = By.CssSelector("tr > th:nth-of-type(1)");
        By Account = By.CssSelector("tr > th:nth-of-type(2)");
        By Customer = By.CssSelector("tr > th:nth-of-type(3)");
        By Amount = By.CssSelector("tr > th:nth-of-type(4)");
        By Type = By.CssSelector("tr > th:nth-of-type(5)");
        By TranCode = By.CssSelector("tr > th:nth-of-type(6)");
        By Description = By.CssSelector("tr > th:nth-of-type(7)");
    }
}
