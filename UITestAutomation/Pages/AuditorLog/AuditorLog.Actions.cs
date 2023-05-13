namespace UITestAutomation
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
