namespace UITestAutomation
{
    internal partial class AlertDefinitions : Selenium_Methods
    {
        public void ClickAlertDefinitionsButton()
        {
            WaitForWebElementDisplayed(AlertDefinitionButton);
            ClickOnWebElement(AlertDefinitionButton);
        }

        public void ClickAddAlertDefinitionButton()
        {
            WaitForWebElementDisplayed(AddAlertDefinitions_Button);
            ClickOnWebElement(AddAlertDefinitions_Button);
        }
        public void ClickExplanationButton()
        {
            WaitForWebElementDisplayed(Explanation_Button);
            ClickOnWebElement(Explanation_Button);
        }
        public void ClickCloseButtononAddalertdefinition()
        {
            WaitForWebElementDisplayed(Close_Button);
            ClickOnWebElement(Close_Button);
        }

    }
}
