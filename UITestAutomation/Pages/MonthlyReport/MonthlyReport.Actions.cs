namespace UITestAutomation.Pages.MonthlyReport
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

    }
}
