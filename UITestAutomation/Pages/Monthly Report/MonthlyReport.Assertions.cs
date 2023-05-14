namespace UITestAutomation
{
    internal partial class MonthlyReport
    {
        public void AssertFieldsonMonthlyReportPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Search By":
                        WaitForWebElementDisplayed(SearchBy_Dropdown);
                        FluentWaitForWebElement(SearchBy_Dropdown);
                        break;
                    case "Date Range":
                        FluentWaitForWebElement(DateRange_Dropdown);
                        break;
                    case "Workflow":
                        FluentWaitForWebElement(WorkflowMonthly_Dropdown);
                        break;
                    case "From":
                        FluentWaitForWebElement(From_Date);
                        break;
                    case "To":
                        FluentWaitForWebElement(To_Date);
                        break;
                    case "Export Disputes":
                        FluentWaitForWebElement(ExportDispute_Button);
                        break;
                }
            }
        }
    }
}
