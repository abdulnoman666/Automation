namespace UITestAutomation
{
    internal partial class FeeSelectionSettings : Selenium_Methods
    {
        public void ClickFeeSelectionSettingsButton()
        {
            WaitForWebElementDisplayed(FeeSelectionSettingsOption);
            ClickOnWebElement(FeeSelectionSettingsOption);
        }
        public void ClickAddFeeSelectionButton()
        {
            ClickOnWebElement(AddFeeSelection);
            WaitForWebElementDisplayed(AddFeeSelection);
        }
    }
}
