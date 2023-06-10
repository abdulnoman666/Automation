using OpenQA.Selenium;

namespace UITestAutomation
{
    internal partial class LedgerBatches
    {
        //UI Controls on Ledger Batches Page
        By LedgerBatchesOption = By.LinkText("Ledger Batches");
        By DateRange = By.CssSelector("//select[@ng-model='dateRange']");
        By CalendarButton = By.CssSelector(".panel-body .fi-field:nth-of-type(1) ._md-datepicker-has-triangle-icon > [type]");
        By TriangleButton = By.CssSelector(".panel-body .fi-field:nth-of-type(1) .md-datepicker-expand-triangle");
        By Action = By.CssSelector("[width='100']");
        By Id = By.CssSelector("[width='30']");
        By Process = By.CssSelector(".panel-body tr th:nth-of-type(3)");
        By Created = By.CssSelector(".panel-body tr th:nth-of-type(4)");
        By PrintReport = By.CssSelector("button[title='Print Letter']");
        By ExportEntries = By.CssSelector(".col-lg-12 > button:nth-of-type(2)");
        By LedgerEntries = By.CssSelector(".col-lg-12 > button:nth-of-type(1)");      
    }
}
