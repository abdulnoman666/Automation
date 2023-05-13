namespace UITestAutomation.Pages.LedgerBatches
{
    internal partial class LedgerBatches
    {
        public void ClickLedgerBatchesButton()
        {
            ClickOnWebElement(LedgerBatchesOption);
            WaitForWebElementDisplayed(LedgerBatchesOption);
        }
    }
}
