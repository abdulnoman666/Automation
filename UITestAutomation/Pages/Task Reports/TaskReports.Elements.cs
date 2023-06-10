using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class TaskReports
    {
        By TaskReport_Dropdown = By.XPath("//a[@href='#/taskreports']");
        By Workflow_Dropdown = By.XPath("//select[@ng-model=\"source\"]");
        By From_Date = By.XPath("//div[@class='col-lg-12']/div[1]/md-datepicker[@type='date']/div[@class='md-datepicker-input-container']/input[@class='md-datepicker-input']");
        By To_Date = By.XPath("//div[@class='col-lg-12']/div[2]/md-datepicker[@type='date']/div[@class='md-datepicker-input-container']/input[@class='md-datepicker-input']");
        By ExportTasks_Button = By.XPath("//button[@ng-click=\"exportTasks($event)\"]");      
    }
}
