namespace UITestAutomation.Pages.ProvisionalCreditLog
{
    internal partial class ProvisionalCreditLog
    {
        public void ClickProvisionalCreditLogButton()
        {
            WaitForWebElementDisplayed(ProvisionalCreditLogBtn);
            ClickOnWebElement(ProvisionalCreditLogBtn);
        }
    }
}
