using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class LedgerBatches
    {
        //UI Controls on Ledger Batches Page
        By LedgerBatchesOption = By.XPath("//a[text='Ledger Batches']");
        By DateRange = By.XPath("//select[@ng-model='dateRange']");
        By From = By.XPath("//button[@ng-click='ctrl.openCalendarPane($event)'][1]");
        By To = By.XPath("//button[@ng-click='ctrl.openCalendarPane($event)'][2]");
        By Action = By.XPath("//th[1][2]");
        By Id = By.XPath("//th[2][2]");
        By Process = By.XPath("//th[3][2]");
        By Created = By.XPath("//th[4][2]");
        By PrintReport = By.XPath("//span[@ng-show='showLabel']");
        By ExportEntries = By.XPath("//button[@ng-click='exportReport()']");
        By LedgerEntries = By.XPath("//button[@ng-click='showReport()']");      
    }
}
