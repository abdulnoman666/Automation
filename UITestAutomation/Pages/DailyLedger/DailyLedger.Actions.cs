namespace UITestAutomation
{
    internal partial class DailyLedger
    {
        public void ClickDailyLedgerButton()
        {
            WaitForWebElementDisplayed(DailyLedgerOption);
            ClickOnWebElement(DailyLedgerOption);
           
        }
    }
}
