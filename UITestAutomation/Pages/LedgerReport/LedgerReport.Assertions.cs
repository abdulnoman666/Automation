namespace UITestAutomation
{
    internal partial class LedgerReport: Selenium_Methods
    {
        public void AssertUIControlsOnLedgerReportPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Date Range":
                        FluentWaitForWebElement(DateRange);
                        break;
                    case " Calendar Button":
                        FluentWaitForWebElement(CalendarButton);
                        break;
                    case " Triangle Button":
                        FluentWaitForWebElement(TriangleButton);
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
        public void AssertFieldsOnLedgerEntriesPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Date":
                        FluentWaitForWebElement(Date);
                        break;
                    case " Account":
                        FluentWaitForWebElement(Account);
                        break;
                    case " Customer":
                        FluentWaitForWebElement(Customer);
                        break;
                    case " Amount":
                        FluentWaitForWebElement(Amount);
                        break;
                    case " Type":
                        FluentWaitForWebElement(Type);
                        break;
                    case " Tran Code":
                        FluentWaitForWebElement(TranCode);
                        break;
                    case " Description":
                        FluentWaitForWebElement(Description);
                        break;
                    case " Close":
                        FluentWaitForWebElement(Close);
                        break;
                }
            }
        }
    }
}
