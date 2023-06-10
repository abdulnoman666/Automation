namespace UITestAutomation
{
    internal partial class GLDefinitions: Selenium_Methods
    {
        public void ClickGLDefinitionsButton()
        {
            WaitForWebElementDisplayed(GLDefinitionsOption);
            ClickOnWebElement(GLDefinitionsOption);
        }
        public void AddGLDefinitionButton()
        {
            WaitForWebElementDisplayed(AddGLDefinition);
            ClickOnWebElement(AddGLDefinition);
        }
        public void DownloadfromLibraryButton()
        {
            WaitForWebElementDisplayed(DownloadLetter);
            ClickOnWebElement(DownloadLetter);
        }
    }
}
