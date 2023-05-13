namespace UITestAutomation.Pages.Disputes
{
    internal partial class Disputes
    {
        public void ClickDisputesButton()
        {
            WaitForWebElementDisplayed(DisputesOption);
            ClickOnWebElement(DisputesOption);
        }
        public void ClickAlertsButton()
        {
            ClickOnWebElement(AlertsButton);
            WaitForWebElementDisplayed(AlertsButton);
        }
        public void ClickSearchButton()
        {
            WaitForWebElementDisplayed(SearchSetDateButton);
            ClickOnWebElement(SearchSetDateButton);
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
            ClickOnWebElement(HistoryButton);
            WaitForWebElementDisplayed(HistoryButton);
        }
        public void ClickDocumentsButton()
        {
            ClickOnWebElement(DocumentsButton);
            WaitForWebElementDisplayed(DocumentsButton);
        }
        public void ClickResolutionButton()
        {
            ClickOnWebElement(ResolutionButton);
            WaitForWebElementDisplayed(ResolutionButton);
        }
    }
}
