namespace UITestAutomation.Pages.FeeSelectionSettings
{
    internal partial class FeeSelectionSettings : Selenium_Methods
    {
        public void AssertUIControlsOnFeeSelectionSettingsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " FeeSelectionSettingsOption":
                        FluentWaitForWebElement(FeeSelectionSettingsOption);
                        break;
                    case " AddFeeSelection":
                        FluentWaitForWebElement(AddFeeSelection);
                        break;
                    case " DeleteFeeSelection":
                        FluentWaitForWebElement(DeleteFeeSelection);
                        break;
                    case " EditFeeSelection":
                        FluentWaitForWebElement(EditFeeSelection);
                        break;
                    case " Refresh":
                        FluentWaitForWebElement(RefreshIcon);
                        break;
                    case " ActionsField":
                        FluentWaitForWebElement(ActionsField);
                        break;
                    case " IDField":
                        FluentWaitForWebElement(IDField);
                        break;
                    case " FeeSelectionReferenceField":
                        FluentWaitForWebElement(FeeSelectionReferenceField);
                        break;
                }
            }
        }
        public void AssertFieldsOnAddFeeSelectionPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " FeeSelectionReference":
                        FluentWaitForWebElement(FeeSelectionReference);
                        break;
                    case " Copy Transactions from Parent Submission":
                        FluentWaitForWebElement(CopyTransactions);
                        break;
                    case " Create Case for Interest Refund":
                        FluentWaitForWebElement(CreateCase);
                        break;
                    case " Search for Transactions using Parameters below":
                        FluentWaitForWebElement(SearchTransactions);
                        break;
                    case " Transaction Codes":
                        FluentWaitForWebElement(TransactionCodes);
                        break;
                    case " Search from Date ":
                        FluentWaitForWebElement(SearchDates);
                        break;
                    case "  Search through Today":
                        FluentWaitForWebElement(SearchToday);
                        break;
                    case " Number of Days":
                        FluentWaitForWebElement(Days);
                        break;
                    case " Save":
                        FluentWaitForWebElement(SaveButton);
                        break;
                    case " Close":
                        FluentWaitForWebElement(CloseButton);
                        break;
                }
            }
        }
    }
}
