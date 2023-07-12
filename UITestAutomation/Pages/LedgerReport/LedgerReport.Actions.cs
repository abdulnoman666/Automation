namespace UITestAutomation
{
    internal partial class LedgerReport
    {
        public void ClickLedgerReportButton()
        {
            WaitForWebElementDisplayed(LedgerReportOption);
            ClickOnWebElement(LedgerReportOption);
           
        }
        public void ClickLedgerEntriesButton()
        {
            WaitForWebElementDisplayed(LedgerEntries);
            ClickOnWebElement(LedgerEntries);
            WaitForWebElementDisplayed(Close);
        }
        public void ClickCloseButtononLedgerEntries()
        {
            ClickOnWebElement(Close);
            WaitForWebElementDisplayed(Close);
        }
    }
}
