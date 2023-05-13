using OpenQA.Selenium;
namespace UITestAutomation.Pages.FeeSelectionSettings
{
    internal partial class FeeSelectionSettings
    {
        //UI Controls on Fee Selection Settings Page
        By FeeSelectionSettingsOption = By.LinkText("Fee Selection Settings");
        By AddFeeSelection = By.CssSelector("button[title='Add Fee Selection']");
        By DeleteFeeSelection = By.CssSelector("button[title='Delete Fee Selection']");
        By EditFeeSelection = By.CssSelector("button[title='Edit Fee Selection']");
        By RefreshIcon = By.CssSelector("button[title = 'Refresh']");
        By ActionsField = By.CssSelector("tr > th:nth-of-type(1)");
        By IDField = By.CssSelector("tr > th:nth-of-type(2)");
        By FeeSelectionReferenceField = By.CssSelector("tr > th:nth-of-type(3)");

        //Fields on Add Fee Selection Page
        By FeeSelectionReference = By.CssSelector("input[name='feeSelectionReference']");
        By CopyTransactions = By.CssSelector("input[name='copyTransactions']");
        By CreateCase = By.CssSelector("input[name='createInterestRefundCase']");
        By SearchTransactions = By.CssSelector("input[name='searchTransactions']]");
        By TransactionCodes = By.CssSelector("input[name='searchTransactionsCodes']");
        By SearchDates = By.CssSelector("select#searchFromDate");
        By SearchToday = By.CssSelector("input[name='searchThroughToday']");
        By Days = By.CssSelector("input[name='searchNumberOfDays']");
        By SaveButton = By.CssSelector(".btn.btn-info");
        By CloseButton = By.CssSelector(".modal-dialog .btn.btn-default");
     }
}