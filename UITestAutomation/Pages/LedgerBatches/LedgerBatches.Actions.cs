namespace UITestAutomation
{
    internal partial class LedgerBatches
    {
        public void ClickLedgerBatchesButton()
        {
            WaitForWebElementDisplayed(LedgerBatchesOption);
            ClickOnWebElement(LedgerBatchesOption);
        }
    }
}
