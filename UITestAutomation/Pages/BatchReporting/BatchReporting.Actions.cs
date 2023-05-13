namespace UITestAutomation
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
