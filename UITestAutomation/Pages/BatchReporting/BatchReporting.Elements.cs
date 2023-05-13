using OpenQA.Selenium;
namespace UITestAutomation.Pages.BatchReporting
{
    internal partial class BatchReporting
    {
        By BatchReportingOption = By.LinkText("Batch Reporting");
        By BatchReference = By.CssSelector("[ng-model] option[label]");
        By DateRange = By.CssSelector("[ng-model='dateRange'] option");
        By CalendarIcon = By.XPath("//button[@ng-click='ctrl.openCalendarPane($event)']");
        By DownArrowIcon = By.CssSelector(".panel-body .fi-field:nth-of-type(1) .md-datepicker-expand-triangle");
        By PrintReport = By.CssSelector(".glyphicon-file");
        By ExportDisputes = By.XPath("//button[@ng-click='exportDisputes($event)']");
    }
}
