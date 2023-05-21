
using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class CompanySettings
    {
        By CompanySettingsOption = By.XPath("//div[@id='myNavbar']/ul[@class='nav navbar-nav navbar-right']/li[12]/ul[@class='dropdown-menu']//a[@href='#/companysettings']");
        By ProvisionalCreditDays_Field = By.XPath("/html//div[@id='main']/div[@class='container']/div[@class='ng-scope']//input[@name='pcDays']");
        By AuditStart_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//md-datepicker[@name='auditStart']/div[@class='md-datepicker-input-container']/input[@class='md-datepicker-input']");
        By AuditEnd_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//md-datepicker[@name='auditEnd']/div[@class='md-datepicker-input-container']/input[@class='md-datepicker-input']");
        By DailyGLCutOffTime_Field = By.XPath("/html//div[@id='main']/div[@class='container']/div[@class='ng-scope']//div[@class='panel-body']/div/div[4]//label[.='Daily GL Cut-Off Time']");
        By PostOnSaturdays_CheckBox = By.XPath("/html//div[@id='main']/div[@class='container']/div[@class='ng-scope']//div[@class='panel-body']/div/div[5]/label[1]/span[@class='checkmark']");
        By Post7DaysaWeek_CheckBox = By.XPath("/html//div[@id='main']/div[@class='container']/div[@class='ng-scope']//div[@class='panel-body']/div/div[5]/label[2]/span[@class='checkmark']");
        By StatementDate_Field = By.XPath("/html//div[@id='main']/div[@class='container']/div[@class='ng-scope']//label[.='Statement Date']");
        By UseLastBusinessDate_Field = By.XPath("/html//div[@id='main']/div[@class='container']/div[@class='ng-scope']//div[@class='panel-body']/div/div[6]/label[@class='container-ch']/span[@class='checkmark']");
        By UpdateSettings_Field = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//div[@class='panel-body']/div/div[7]/label[.='Customer Create/Update Settings']");
        By HideAddress2_CheckBox = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//div[@class='panel-body']/div/div[7]/label[2]/span[@class='checkmark']");
        By HideAddress3_CheckBox = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//div[@class='panel-body']/div/div[7]/label[3]/span[@class='checkmark']");
        By HideAddress4_CheckBox = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//div[@class='panel-body']/div/div[7]/label[4]/span[@class='checkmark']");
        By HideCity_CheckBox = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//div[@class='panel-body']/div/div[7]/label[5]/span[@class='checkmark']");
        By HideState_CheckBox = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//div[@class='panel-body']/div/div[7]/label[6]/span[@class='checkmark']");
        By HideZip_CheckBox = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//div[@class='panel-body']/div/div[7]/label[7]/span[@class='checkmark']");
        By EnableTask_Field = By.XPath("/html//div[@id='main']/div[@class='container']/div[@class='ng-scope']//label[.='Enable Tasks']");
        By DisplayTaskConfigurationandSections_CheckBox = By.XPath("/html//div[@id='main']/div[@class='container']/div[@class='ng-scope']//div[@class='panel-body']/div/div[8]/label[@class='container-ch']/span[@class='checkmark']");
        By Save_Button = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//button[@class='btn btn-default']");
    }
}
