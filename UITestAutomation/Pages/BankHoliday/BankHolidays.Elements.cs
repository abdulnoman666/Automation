using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class BankHolidays
    {
        //UI Controls on Bank Holidays Page
        By Bankholiday_Button = By.XPath("//a[@href=\"#/bankholidays\"]");
        By AddNewBankHolidays = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//button[@title='Add Holiday']");
        By DeleteBankHolidays = By.XPath("//button[@ng-click=\"deleteBankHoliday($event, h)\"]");
        By EditBankHolidays = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//table/tbody/tr[1]//button[@title='Edit Holiday']");
        By Action= By.XPath("/html//div[@id='main']/div[@class='container']/div[@class='ng-scope']//table//th[.='Action']");   
        By RefreshIcon = By.XPath("/html//div[@id='main']/div[@class='container']/div[@class='ng-scope']//button[@title='Refresh']");

        //Add Brand Page (Field)
        By AddHoliday = By.XPath("//div[@id='addHoliday']//md-datepicker[@type='date']/div[@class='md-datepicker-input-container']/input[@class='md-datepicker-input']");
        By SaveButton = By.XPath("/html//div[@id='addHoliday']//div[@class='modal-footer']/button[2]/span[.='Save']");
        By CloseButton = By.XPath("/html//div[@id='addHoliday']//div[@class='modal-footer']/button[1]");
    }

}
