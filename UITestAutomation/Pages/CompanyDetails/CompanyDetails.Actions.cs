namespace UITestAutomation
{
    internal partial class CompanyDetails
    {
        public void ClickCompanyDetailsButton()
        {
            WaitForWebElementDisplayed(CompanyDetailsOption);
            ClickOnWebElement(CompanyDetailsOption);
        }
        public void ClickGeneralSettingsButton()
        {
            WaitForWebElementDisplayed(GeneralSettings);
            ClickOnWebElement(GeneralSettings);
        }
        public void ClickLookupValuesButton()
        {
            WaitForWebElementDisplayed(LookupValues);
            ClickOnWebElement(LookupValues);
        }
        public void ClickaddSubmissionButton()
        {
            WaitForWebElementDisplayed(AddSubmission_Button);
            ClickOnWebElement(AddSubmission_Button);
        }
        public void ClickCloseButtononaddSubmission()
        {
            WaitForWebElementDisplayed(CloseButton);
            ClickOnWebElement(CloseButton);
        }
        public void ClickStyleButton()
        {
            WaitForWebElementDisplayed(Style);
            ClickOnWebElement(Style);
        }
    }
}
