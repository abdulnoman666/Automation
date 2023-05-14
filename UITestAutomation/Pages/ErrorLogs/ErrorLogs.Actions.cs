namespace UITestAutomation
{
    internal partial class ErrorLogs : Selenium_Methods
    {
        public void ClickErrorLogsButton()
        {
            WaitForWebElementDisplayed(ErrorLogsOption);
            ClickOnWebElement(ErrorLogsOption);
        }
        public void ClickSearchandsetdateRangeButton()
        {
            WaitForWebElementDisplayed(SearchandsetdateRange_Button);
            ClickOnWebElement(SearchandsetdateRange_Button);
        }

    }
}
