namespace UITestAutomation
{
    internal partial class Disputes
    {
        public void ClickDisputesButton()
        {
            WaitForWebElementDisplayed(DisputesOption);
            ClickOnWebElement(DisputesOption);
        }
        public void ClickSettingsButton()
        {
            WaitForWebElementDisplayed(SettingsButton);
            ClickOnWebElement(SettingsButton);   
        }
        public void ClickCloseButtononCustomizedPage()
        {
            WaitForWebElementDisplayed(closecustomizes_Button);
            ClickOnWebElement(closecustomizes_Button);
        }
        public void ClickSearchButton()
        {
            WaitForWebElementDisplayed(SearchSetDateButton);
            ClickOnWebElement(SearchSetDateButton);
        }
        public void ClickCloseButtononSearch()
        {
            WaitForWebElementDisplayed(closesearch_Button);
            ClickOnWebElement(closesearch_Button);
        }
        public void ClickShowClosedDisputesButton()
        {
            ClickOnWebElement(ShowClosedDisputesButton);
            WaitForWebElementDisplayed(ShowClosedDisputesButton);
        }
        public void ClickEditDisputeButton()
        {
            WaitForWebElementDisplayed(EditDisputeButton);
            ClickOnWebElement(EditDisputeButton);
        }
        public void ClickHistoryButton()
        {
            WaitForWebElementDisplayed(HistoryButton);
            ClickOnWebElement(HistoryButton);
            
        }
        public void ClickDocumentsButton()
        {
            WaitForWebElementDisplayed(DocumentsButton);
            ClickOnWebElement(DocumentsButton);
           
        }
        public void ClickResolutionButton()
        {
            WaitForWebElementDisplayed(ResolutionButton);
            ClickOnWebElement(ResolutionButton);
       
        }

        public void ClickCloseButtononResolution()
        {
            WaitForWebElementDisplayed(Close);
            ClickOnWebElement(Close);

        }
    }
}
