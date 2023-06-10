namespace UITestAutomation
{
    internal partial class DailyLedger
    {
        public void ClickDailyLedgerButton()
        {
            ClickOnWebElement(DailyLedgerOption);
            WaitForWebElementDisplayed(DailyLedgerOption);
        }
    }
}
