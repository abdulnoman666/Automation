using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class LedgerReport
    {
        //UI Controls on Ledger Report Page
        By LedgerReportOption = By.XPath("//a[text='Ledger Report']");
        By DateRange = By.XPath("//select[@ng-model='dateRange']");
        By From  = By.XPath("//button[@ng-click='ctrl.openCalendarPane($event)'][1]");
        By To = By.XPath("//button[@ng-click='ctrl.openCalendarPane($event)'][2]");
        By PrintReport = By.XPath("//button[@ng-disabled='disableButton']");
        By ExportEntries = By.XPath("//button[@ng-click='exportReport()']");
        By LedgerEntries = By.XPath("//button[@ng-click='showReport()']");

        // Fields on Ledger Entries Page
        By Date = By.XPath("//th[1]");
        By Account = By.XPath("//th[2]");
        By Customer = By.XPath("//th[3]");
        By Amount = By.XPath("//th[4]");
        By Type = By.XPath("//th[5]");
        By TranCode = By.XPath("//th[6]");
        By Description = By.XPath("//th[7]");
        By Close = By.XPath("btn btn-default");
    }
}
