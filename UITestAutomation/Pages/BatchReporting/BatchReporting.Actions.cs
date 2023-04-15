namespace UITestAutomation.Pages.BatchReporting
{
    internal partial class BatchReporting : Selenium_Methods
    {
        public void ClickBatchReportingOption()
        {
            WaitForWebElementDisplayed(BatchReportingOption);
            ClickOnWebElement(BatchReportingOption);
        }
    }
}
