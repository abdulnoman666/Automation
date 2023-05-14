
using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class CompanySettings
    {
        By ProvisionalCreditDays_Field = By.CssSelector("input[name='pcDays']");
        By AuditStart_Field = By.CssSelector("md-datepicker[name='auditStart'] > .md-datepicker-input-container > .md-datepicker-input");
        By AuditEnd_Field = By.CssSelector("md-datepicker[name='auditEnd'] > .md-datepicker-input-container > .md-datepicker-input");
            By DailyGLCutOffTime_Field = By.CssSelector("div > div:nth-of-type(4)");
        By PostOnSaturdays_CheckBox = By.CssSelector("label:nth-of-type(1) > .checkmark");
        By Post7DaysaWeek_CheckBox = By.CssSelector("div:nth-of-type(5) > label:nth-of-type(2) > .checkmark");
        By StatementDate_Field = By.CssSelector("div:nth-of-type(6) > .container-ch");
        By UseLastBusinessDate_Field = By.CssSelector("div > div:nth-of-type(6)");
        By UpdateSettings_Field = By.CssSelector("div:nth-of-type(7) > label:nth-of-type(1)");
        By HideAddress2_CheckBox = By.CssSelector("div:nth-of-type(7) > label:nth-of-type(2) > .checkmark");
        By HideAddress3_CheckBox = By.CssSelector("label:nth-of-type(3) > .checkmark");
        By HideAddress4_CheckBox = By.CssSelector("label:nth-of-type(4) > .checkmark");
        By HideCity_CheckBox = By.CssSelector("label:nth-of-type(5) > .checkmark");
        By HideState_CheckBox = By.CssSelector("label:nth-of-type(6) > .checkmark");
        By HideZip_CheckBox = By.CssSelector("label:nth-of-type(7) > .checkmark");
        By EnableTask_Field = By.CssSelector("div:nth-of-type(8) > label:nth-of-type(1)");
        By DisplayTaskConfigurationandSections_CheckBox = By.CssSelector("div:nth-of-type(8) > .container-ch > .checkmark");
        By Save_Button = By.CssSelector("[ng-click='savesettings\\(\\)']");




    }
}
