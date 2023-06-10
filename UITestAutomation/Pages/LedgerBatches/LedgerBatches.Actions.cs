namespace UITestAutomation
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
