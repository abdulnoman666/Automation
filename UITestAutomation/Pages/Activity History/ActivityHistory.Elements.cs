using OpenQA.Selenium;


namespace UITestAutomation
{
    internal partial class ActivityHistory
    {
        By ActivityHistory_Dropdown = By.XPath("//li[@class='ng-scope'][2]");
        By DownloadHistory_Button = By.XPath("//button[@title=\"Download History\"]");
        By Refresh_Button = By.XPath("//button[@title=\"Refresh\"]");
        By StartDate_TextField = By.XPath("(//input[@class=\"md-datepicker-input\"])[1]");
        By StartCalender_Button = By.XPath("(//button[@ng-click=\"ctrl.openCalendarPane($event)\"])[1]");
        By StartCalenderDown_Button = By.XPath("(//button[@ng-click=\"ctrl.openCalendarPane($event)\"])[2]");
        By EndCalender_Button = By.XPath("(//button[@ng-click=\"ctrl.openCalendarPane($event)\"])[3]");
        By EndCalenderDown_Button = By.XPath("(//button[@ng-click=\"ctrl.openCalendarPane($event)\"])[4]");
        By EndDate_TextField = By.XPath("(//input[@class=\"md-datepicker-input\"])[2]");
        By EventType_Dropdown = By.XPath("(//input[@class=\"select2-search__field\"])[1]");
        By Users_Dropdown = By.XPath("(//input[@class=\"select2-search__field\"])[2]");
        By Reset_Button = By.XPath("(//button[@ng-click=\"reset()\"])[1]");
        By Search_Button = By.XPath("(//button[@ng-click=\"searchByFilter()\"])[1]");
        By Action_Field = By.XPath("//th[1]");
        By ID_Field = By.XPath("//th[2]");
        By SubCase_Field = By.XPath("//th[3]");
        By Workflow_Field = By.XPath("//th[4]");
        By UserName_Field = By.XPath("//th[5]");
        By Type_Field = By.XPath("//th[6]");
        By Automation_Field = By.XPath("//th[7]");
        By Created_Field = By.XPath("//th[8]");
    }
}
