namespace UITestAutomation.Pages.ImportConfigurations
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
    }
}
