using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class TaskReports
    {
        By TaskReport_Dropdown = By.XPath("//a[@href='#/taskreports']");
        By Workflow_Dropdown = By.XPath("//select[@ng-model=\"source\"]");
        By From_Date = By.XPath("(//input[@placeholder=\"Enter date\"])[1]");
        By FromCalender_Button = By.XPath("(//button[@ng-click=\"ctrl.openCalendarPane($event)\"])[1]");
        By FromDownArrow_Button = By.XPath("(//button[@ng-click=\"ctrl.openCalendarPane($event)\"])[2]");
        By To_Date = By.XPath("(//input[@placeholder=\"Enter date\"])[2]");
        By ToCalender_Button = By.XPath("(//button[@ng-click=\"ctrl.openCalendarPane($event)\"])[3]");
        By ToDownArrow_Button = By.XPath("(//button[@ng-click=\"ctrl.openCalendarPane($event)\"])[4]");
        By ExportTasks_Button = By.XPath("//button[@ng-click=\"exportTasks($event)\"]");      
    }
}
