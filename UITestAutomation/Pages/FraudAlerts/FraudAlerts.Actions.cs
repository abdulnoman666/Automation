namespace UITestAutomation
{
    internal partial class FraudAlerts
    {
        public void ClickFraudAlertsButton()
        {
            WaitForWebElementDisplayed(FraudAlertsButton);
            ClickOnWebElement(FraudAlertsButton);
        }
        public void ClickUploadAlertsFileButton()
        {
            WaitForWebElementDisplayed(UploadAlertFileBtn);
            ClickOnWebElement(UploadAlertFileBtn);
        }
        public void ClickCloseButtononUploadAlertsFile()
        {
            WaitForWebElementDisplayed(Close_upload);
            ClickOnWebElement(Close_upload);
        }
        public void ClickEnterAlertsManuallyButton()
        {
            WaitForWebElementDisplayed(EntermanuallyButton);
            ClickOnWebElement(EntermanuallyButton);
          
        }
        public void ClickCloseButtononManually()
        {
            WaitForWebElementDisplayed(CloseManual);
            ClickOnWebElement(CloseManual);
           
        }
        public void ClickSearchSetDateRangeButton()
        {
            WaitForWebElementDisplayed(SearchSetDateRangeBtn);
            ClickOnWebElement(SearchSetDateRangeBtn);
        }
        public void ClickCloseButtononSearch()
        {
            WaitForWebElementDisplayed(CloseSearch);
            ClickOnWebElement(CloseSearch);
            
        }
        public void ClickCloseButtononShowSubmission()
        {
            WaitForWebElementDisplayed(Close3);
            ClickOnWebElement(Close3);
            
        }
        public void ClickShowSubmissionPageButton()
        {
            WaitForWebElementDisplayed(ShowSubmissions);
            ClickOnWebElement(ShowSubmissions);
//            WaitForWebElementDisplayed(ReportedOn);
        }
    }
}
