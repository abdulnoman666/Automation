namespace UITestAutomation.Pages.LedgerReport
{
    internal partial class LedgerReport
    {
        public void ClickLedgerReportButton()
        {
            ClickOnWebElement(LedgerReportOption);
            WaitForWebElementDisplayed(LedgerReportOption);
        }
        public void ClickLedgerEntriesButton()
        {
            ClickOnWebElement(LedgerEntries);
            WaitForWebElementDisplayed(LedgerEntries);
        }
    }
}
