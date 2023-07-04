﻿namespace UITestAutomation
{
    internal partial class LedgerBatches : Selenium_Methods
    {
        public void AssertUIControlsOnLedgerBatchesPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Date Range":
                        FluentWaitForWebElement(DateRange);
                        break;
                    case " From":
                        FluentWaitForWebElement(From);
                        break;
                    case " To":
                        FluentWaitForWebElement(To);
                        break;
                    case " Action":
                        FluentWaitForWebElement(Action);
                        break;
                    case " Id":
                        FluentWaitForWebElement(Id);
                        break;
                    case " Process":
                        FluentWaitForWebElement(Process);
                        break;
                    case " Created":
                        FluentWaitForWebElement(Created);
                        break;
                    case " Print Report":
                        FluentWaitForWebElement(PrintReport);
                        break;
                    case " Export Entries":
                        FluentWaitForWebElement(ExportEntries);
                        break;
                    case " Ledger Entries":
                        FluentWaitForWebElement(LedgerEntries);
                        break;
                }
            }
        }
    }
}
