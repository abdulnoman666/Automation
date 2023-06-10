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
    }
}
