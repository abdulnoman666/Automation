using OpenQA.Selenium;
namespace UITestAutomation  
{
    internal partial class LedgerReport
    {
        //UI Controls on Ledger Report Page
        By LedgerReportOption = By.LinkText("Ledger Report");
        By DateRange = By.CssSelector("//select[@ng-model='dateRange']");
        By From  = By.CssSelector(".panel-body .fi-field:nth-of-type(1) ._md-datepicker-has-triangle-icon > [type]");
        By To = By.CssSelector(".panel-body .fi-field:nth-of-type(1) [ng-class] [type]");
        By PrintReport = By.CssSelector("button[title='Print Letter']");
        By ExportEntries = By.CssSelector(".col-lg-12 > button:nth-of-type(2)");
        By LedgerEntries = By.CssSelector(".col-lg-12 > button:nth-of-type(1)");

        // Fields on Ledger Entries Page
        By Date = By.CssSelector("tr > th:nth-of-type(1)");
        By Account = By.CssSelector("tr > th:nth-of-type(2)");
        By Customer = By.CssSelector("tr > th:nth-of-type(3)");
        By Amount = By.CssSelector("tr > th:nth-of-type(4)");
        By Type = By.CssSelector("tr > th:nth-of-type(5)");
        By TranCode = By.CssSelector("tr > th:nth-of-type(6)");
        By Description = By.CssSelector("tr > th:nth-of-type(7)");
        By Close = By.CssSelector(".modal-dialog.modal-lg .btn.btn-default");
    }
}
