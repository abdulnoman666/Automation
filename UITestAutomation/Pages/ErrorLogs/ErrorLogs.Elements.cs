using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class ErrorLogs
    {
        By ErrorLogsOption = By.XPath("//div[@id='myNavbar']/ul[@class='nav navbar-nav navbar-right']/li[12]/ul[@class='dropdown-menu']//a[@href='#/errorlogs']");
        By SearchandsetdateRange_Button = By.XPath("/html//div[@id='main']/div[@class='container']/div[@class='ng-scope']//button[@title='Search and set date range']");
        By CreatedOn_Field = By.XPath("/html//div[@id='main']/div[@class='container']/div[@class='ng-scope']//table//th[.='Created On']");
        By ErrorMessage_Field = By.XPath("/html//div[@id='main']/div[@class='container']/div[@class='ng-scope']//table//th[.='Error Message']");
        By URL_Field = By.XPath("/html//div[@id='main']/div[@class='container']/div[@class='ng-scope']//table//th[.='URL']");
        By StartDate_Button = By.XPath("/html//div[@id='dateSearch']//form[@name='dateFilterForm']/md-datepicker[@name='startDate']/div[@class='md-datepicker-input-container']/input[@class='md-datepicker-input']");
        By EndDate_Button = By.XPath("/html//div[@id='dateSearch']//form[@name='dateFilterForm']/md-datepicker[@name='endDate']/div[@class='md-datepicker-input-container']/input[@class='md-datepicker-input']");
        By Close_Button = By.XPath("/html//div[@id='dateSearch']//div[@class='modal-footer']/button[@type='button']");
    }
}