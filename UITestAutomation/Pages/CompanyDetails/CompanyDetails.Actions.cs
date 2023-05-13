namespace UITestAutomation.Pages.CompanyDetails
{
    internal partial class CompanyDetails
    {
        public void ClickCompanyDetailsButton()
        {
            WaitForWebElementDisplayed(CompanyDetailsOption);
            ClickOnWebElement(CompanyDetailsOption);
        }
        public void ClickBasicInfoButton()
        {
            WaitForWebElementDisplayed(BasicInfo);
            ClickOnWebElement(BasicInfo);
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
        public void ClickStyleButton()
        {
            WaitForWebElementDisplayed(Style);
            ClickOnWebElement(Style);
        }
    }
}
