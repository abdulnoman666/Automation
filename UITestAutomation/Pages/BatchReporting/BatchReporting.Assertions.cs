namespace UITestAutomation  
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
                        WaitForWebElementDisplayed(BatchReference);
                        FluentWaitForWebElement(BatchReference);
                        break;
                    case " Date Range":
                        FluentWaitForWebElement(DateRange);
                        break;
                    case " From":
                        FluentWaitForWebElement(From);
                        break;
                    case " To":
                        FluentWaitForWebElement(To);
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
