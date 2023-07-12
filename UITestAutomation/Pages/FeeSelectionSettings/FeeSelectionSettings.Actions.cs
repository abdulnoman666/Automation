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
            WaitForWebElementDisplayed(AddFeeSelection);
            ClickOnWebElement(AddFeeSelection);
           
        }

        public void ClickCloseButtononAddFeeSelection()
        {
            WaitForWebElementDisplayed(CloseButton);
            ClickOnWebElement(CloseButton);

        }
    }
}
