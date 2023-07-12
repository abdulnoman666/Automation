namespace UITestAutomation
{
    internal partial class MonthlyReport
    {
        public void ClickMonthlyReportButton()
        {
            WaitForWebElementDisplayed(MonthlyReportOption);
            ClickOnWebElement(MonthlyReportOption);
        }
        public void ClickListButton()
        {
            WaitForWebElementDisplayed(ListButton);
            ClickOnWebElement(ListButton);
        }
        public void ClickSummaryButton()
        {
            WaitForWebElementDisplayed(SummaryButton);
            ClickOnWebElement(SummaryButton);
        }
        public void ClickCloseButtononSummary()
        {
            WaitForWebElementDisplayed(Close);
            ClickOnWebElement(Close);
        }
        public void ClickCloseButtononListPage()
        {
            WaitForWebElementDisplayed(Close2);
            ClickOnWebElement(Close2);
        }
    }
}
