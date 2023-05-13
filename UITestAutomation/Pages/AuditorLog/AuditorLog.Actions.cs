namespace UITestAutomation.Pages.AuditorLog
{
    internal partial class AuditorLog
    {
        public void ClickAuditorLogButton()
        {
            WaitForWebElementDisplayed(AuditorLogButton);
            ClickOnWebElement(AuditorLogButton);
        }
    }
}
