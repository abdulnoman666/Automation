namespace UITestAutomation
{
    internal partial class ResetSubmission :Selenium_Methods
    {
        public void ClickResetSubmission()
        {
            ClickTheWebElement(ResetSubmission_Dropdown);
            WaitForWebElementDisplayed(Reset_Button);
        }
    }
}
