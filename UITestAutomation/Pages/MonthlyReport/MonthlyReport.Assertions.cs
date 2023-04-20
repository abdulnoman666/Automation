namespace UITestAutomation.Pages.MonthlyReport
{
    internal partial class MonthlyReport: Selenium_Methods
    {
        public void AssertUIControlsOnMonthlyReportPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Reported On":
                        FluentWaitForWebElement(ReportedOn);
                        break;
                    case " Date Range":
                        FluentWaitForWebElement(DateRange);
                        break;
                    case " Workflows":
                        FluentWaitForWebElement(Workflows);
                        break;
                    case " Calendar Button":
                        FluentWaitForWebElement(CalendarButton);
                        break;
                    case " Traingle Option":
                        FluentWaitForWebElement(TraingleOption);
                        break;
                    case " Print Report":
                        FluentWaitForWebElement(PrintReport);
                        break;
                    case " Summary":
                        FluentWaitForWebElement(SummaryButton);
                        break;
                    case " Charts":
                        FluentWaitForWebElement(Charts);
                        break;
                    case " List":
                        FluentWaitForWebElement(ListButton);
                        break;
                    case " Export Disputes":
                        FluentWaitForWebElement(ExportDisputes);
                        break;
                }
            }
        }
        public void AssertFieldslsOnSummaryPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Submission Count":
                        FluentWaitForWebElement(SubmissionCount);
                        break;
                    case " Total Claimed":
                        FluentWaitForWebElement(TotalClaimed);
                        break;
                    case " Total Disputed":
                        FluentWaitForWebElement(TotalDisputed);
                        break;
                    case " Bank Loss":
                        FluentWaitForWebElement(BankLoss);
                        break;
                    case " Merchant Loss":
                        FluentWaitForWebElement(MerchantLoss);
                        break;
                    case " Consumer Loss":
                        FluentWaitForWebElement(ConsumerLoss);
                        break;
                    case " Recovered":
                        FluentWaitForWebElement(Recovered);
                        break;
                    case " Pending Provisional Credit":
                        FluentWaitForWebElement(ProvisionalCredit);
                        break;
                    case " Export":
                        FluentWaitForWebElement(Export);
                        break;
                    case " Close":
                        FluentWaitForWebElement(Close);
                        break;
                }
            }
        }
        public void AssertFieldsOnListsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Reported":
                        FluentWaitForWebElement(Reported);
                        break;
                    case " Days":
                        FluentWaitForWebElement(Days);
                        break;
                    case " P/C":
                        FluentWaitForWebElement(PC);
                        break;
                    case " R/S":
                        FluentWaitForWebElement(RS);
                        break;
                    case " C/A":
                        FluentWaitForWebElement(CA);
                        break;
                    case " Status":
                        FluentWaitForWebElement(Status);
                        break;
                    case " Detail":
                        FluentWaitForWebElement(Detail);
                        break;
                    case " Resolution":
                        FluentWaitForWebElement(Resolution);
                        break;
                    case " Amount":
                        FluentWaitForWebElement(Amount);
                        break;
                    case " Recovered":
                        FluentWaitForWebElement(Recovered2);
                        break;
                    case " Type":
                        FluentWaitForWebElement(Type);
                        break;
                    case " Customer":
                        FluentWaitForWebElement(Customer);
                        break;
                    case " Assigned To":
                        FluentWaitForWebElement(AssignedTo);
                        break;
                    case " Close":
                        FluentWaitForWebElement(Close2);
                        break;
                }
            }
        }

    }
}
