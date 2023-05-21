using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class MonthlyReport
    {
        By MonthlyReport_Dropdown = By.XPath("//a[@href='#/submissionreports']");
        By SearchBy_Dropdown = By.XPath("//select[@ng-model=\"searchField\"]");
        By DateRange_Dropdown = By.XPath("//select[@ng-change=\"setDates()\"]");
        By WorkflowMonthly_Dropdown = By.XPath("//select[@ng-model=\"source\"]");
        By From_Date = By.XPath("(//input[@class=\"md-datepicker-input\"])[1]");
        By FromMRCalender_Button = By.XPath("(//button[@ng-click=\"ctrl.openCalendarPane($event)\"])[1]");
        By FromMRDownArrow_Button = By.XPath("(//button[@ng-click=\"ctrl.openCalendarPane($event)\"])[2]");
        By To_Date = By.XPath("(//input[@class=\"md-datepicker-input\"])[2]");
        By ToMRCalender_Button = By.XPath("(//button[@ng-click=\"ctrl.openCalendarPane($event)\"])[3]");
        By ToMRDownArrow_Button = By.XPath("(//button[@ng-click=\"ctrl.openCalendarPane($event)\"])[4]");
        By ExportDispute_Button = By.XPath("//button[@ng-click=\"exportDisputes($event)\"]");
    }
}
