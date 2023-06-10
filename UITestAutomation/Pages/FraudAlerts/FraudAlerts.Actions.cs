namespace UITestAutomation
{
    internal partial class FraudAlerts
    {
       /* public void ClickFraudAlertsButton()
        {
            WaitForWebElementDisplayed(FraudAlertsButton);
            ClickOnWebElement(FraudAlertsButton);
        }*/
        public void ClickUploadAlertsFileButton()
        {
            ClickOnWebElement(UploadAlertFileBtn);
            WaitForWebElementDisplayed(UploadAlertFileBtn);
        }
        public void ClickEnterAlertsManuallyButton()
        {
            ClickOnWebElement(EnterAlertsBtn);
            WaitForWebElementDisplayed(EnterAlertsBtn);
        }
        public void ClickSearchSetDateRangeButton()
        {
            WaitForWebElementDisplayed(SearchSetDateRangeBtn);
            ClickOnWebElement(SearchSetDateRangeBtn);
        }
        public void ClickShowSubmissionPageButton()
        {
            WaitForWebElementDisplayed(ShowSubmissions);
            ClickOnWebElement(ShowSubmissions);
        }
    }
}
