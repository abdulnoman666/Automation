

namespace UITestAutomation
{
    internal partial class MonthlyReport : Selenium_Methods
    {
        public void ClickMonthlyReports()
        {
            ClickTheWebElement(MonthlyReport_Dropdown);
            WaitForWebElementDisplayed(ExportDispute_Button);
        }
    }
}
