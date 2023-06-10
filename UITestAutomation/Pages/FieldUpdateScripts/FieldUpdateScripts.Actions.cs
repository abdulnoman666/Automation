namespace UITestAutomation { 
    internal partial class FieldUpdateScripts: Selenium_Methods
    {
        public void ClickFieldUpdateScriptsButton()
        {
            WaitForWebElementDisplayed(FieldUpdateScriptsOption);
            ClickOnWebElement(FieldUpdateScriptsOption);
        }
        public void ClickAddFieldUpdateScriptButton()
        {
            WaitForWebElementDisplayed(AddFieldUpdateScript);
            ClickOnWebElement(AddFieldUpdateScript);
        }
        public void ClickDownloadfromlibraryButton()
        {
            WaitForWebElementDisplayed(DownloadfromLibraryButton);
            ClickOnWebElement(DownloadfromLibraryButton);
        }
    }
}
