using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class MonthlyReport
    {
        By MonthlyReport_Dropdown = By.XPath("//a[@href='#/submissionreports']");
        By SearchBy_Dropdown = By.XPath("//div[@class='panel-body']/div[1]/div[@class='col-lg-4']/div[@class='fi-field']/select");
        By DateRange_Dropdown = By.XPath("//div[@class='panel-body']/div[2]/div[@class='col-lg-4']/div[@class='fi-field']/select");
        By WorkflowMonthly_Dropdown = By.XPath("//div[@class='panel-body']/div[3]/div[@class='col-lg-4']/div[@class='fi-field']/select");
        By From_Date = By.XPath("//div[@class='col-lg-12']/div[1]/md-datepicker[@type='date']/div[@class='md-datepicker-input-container']/input[@class='md-datepicker-input']");
        By To_Date = By.XPath("//div[@class='col-lg-12']/div[2]/md-datepicker[@type='date']/div[@class='md-datepicker-input-container']/input[@class='md-datepicker-input']");
        By ExportDispute_Button = By.XPath("//button[@ng-click=\"exportDisputes($event)\"]");
    }
}
