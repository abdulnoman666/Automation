namespace UITestAutomation.Pages.DailyLedger
{
    internal partial class DailyLedger: Selenium_Methods
    {
        public void AssertUIControlsOnDailyLedgerPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Refresh Ledger":
                        FluentWaitForWebElement(RefreshLedger);
                        break;
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
                }
            }
        }
    }
}
