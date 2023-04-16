namespace UITestAutomation.Pages.BatchReporting
{
    internal partial class BatchReporting
    {
        public void AssertUIControlsOnBatchReportingPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Batch Reference":
                        FluentWaitForWebElement(BatchReference);
                        break;
                    case " Date Range":
                        FluentWaitForWebElement(DateRange);
                        break;
                    case " Calendar Icon":
                        FluentWaitForWebElement(CalendarIcon);
                        break;
                    case " Down Arrow Icon":
                        FluentWaitForWebElement(DownArrowIcon);
                        break;
                    case " Print Report":
                        FluentWaitForWebElement(PrintReport);
                        break;
                    case " Export Disputes":
                        FluentWaitForWebElement(ExportDisputes);
                        break;
                }
            }
        }
    }
}
