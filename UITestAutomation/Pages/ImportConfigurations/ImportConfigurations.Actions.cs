namespace UITestAutomation
{
    internal partial class ImportConfigurations : Selenium_Methods
    {
        public void ClickImportConfigurationsButton()
        {
            WaitForWebElementDisplayed(ImportConfigurationsOption);
            ClickOnWebElement(ImportConfigurationsOption);
        }
        public void AddConfigurationButton()
        {
            WaitForWebElementDisplayed(AddConfiguration);
            ClickOnWebElement(AddConfiguration);
        }
        public void ClickClosebuttononAddConfiguration()
        {
            WaitForWebElementDisplayed(CloseButton);
            ClickOnWebElement(CloseButton);
        }
    }
}
