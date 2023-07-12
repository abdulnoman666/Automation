using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class BatchReporting
    {
        By BatchReportingOption = By.XPath("//a[@href=\"#/batchreporting\"]");
        By BatchReference = By.XPath("//select[@ng-model='searchField']");
        By DateRange = By.XPath("//select[@ng-model='dateRange']");
        By From = By.XPath("//button[@ng-click='ctrl.openCalendarPane($event)'][1]");
        By To = By.XPath("//button[@ng-click='ctrl.openCalendarPane($event)'][2]");
        By PrintReport = By.XPath("//span[@ng-show='showLabel']");
        By ExportDisputes = By.XPath("//button[@ng-click='exportDisputes($event)']");
    }
}
