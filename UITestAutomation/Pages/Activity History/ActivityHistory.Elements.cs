using OpenQA.Selenium;


namespace UITestAutomation.Pages.Activity_History
{
    internal partial class ActivityHistory
    {
        By ActivityHistory_Dropdown = By.CssSelector("li:nth-of-type(4) > .dropdown-menu > li:nth-of-type(2) > a");
        By DownloadHistory_Button = By.XPath("//button[@title=\"Download History\"]");
        By Refresh_Button = By.XPath("//button[@title=\"Refresh\"]");
        By StartDate_TextField = By.CssSelector("div > div:nth-of-type(1) > md-datepicker[name='startDate'] > .md-datepicker-input-container > .md-datepicker-input");
        By EndDate_TextField = By.CssSelector("div > div:nth-of-type(2) > md-datepicker[name='endDate'] > .md-datepicker-input-container > .md-datepicker-input");
        By EventType_Dropdown = By.CssSelector("div:nth-of-type(3) > .select2.select2-container.select2-container--default  span[role='combobox'] > .select2-selection__rendered  input[role='searchbox']");
        By Users_Dropdown = By.CssSelector("div:nth-of-type(4) > .select2.select2-container.select2-container--default  span[role='combobox'] > .select2-selection__rendered  input[role='searchbox']");
        By Reset_Button = By.CssSelector(".container.ng-scope .btn.btn-default");
        By Search_Button = By.CssSelector(".panel-body [data-dismiss]");
        By Action_Field = By.CssSelector("[width='20']");
        By ID_Field = By.CssSelector("tr [width='30']:nth-of-type(2)");
        By SubCase_Field = By.CssSelector("tr [width='30']:nth-of-type(3)");
        By Workflow_Field = By.CssSelector("tr [width='70']:nth-of-type(4)");
        By UserName_Field = By.CssSelector("tr [width='70']:nth-of-type(5)");
        By Type_Field = By.CssSelector("tr [width='70']:nth-of-type(6)");
        By Automation_Field = By.CssSelector("[width='150']");
        By Created_Field = By.CssSelector("tr [width='70']:nth-of-type(8)");
    }
}
