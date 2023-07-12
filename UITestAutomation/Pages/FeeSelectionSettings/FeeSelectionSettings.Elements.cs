using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class FeeSelectionSettings
    {
        //UI Controls on Fee Selection Settings Page
        By FeeSelectionSettingsOption = By.XPath("//a[text()='Fee Selection Settings']");
        By AddFeeSelection = By.XPath("//button[@ng-click='addFeeSelection()']");
        By DeleteFeeSelection = By.XPath("//button[@ng-click='removeFeeSelection($event, fs);']");
        By EditFeeSelection = By.XPath("//button[@ng-click='editFeeSelection(fs)']");
        By RefreshIcon = By.XPath("//button[@ng-click='refresh()']");
        By ActionsField = By.XPath("//th[1]");
        By IDField = By.XPath("//th[2]");
        By FeeSelectionReferenceField = By.XPath("//th[3]");

        //Fields on Add Fee Selection Page
        By FeeSelectionReference = By.XPath("//input[@ng-model='selectedFeeSelectionSettings.feeSelectionReference']");
        By CopyTransactions = By.XPath("//input[@ng-model='selectedFeeSelectionSettings.copyTransactions']");
        By CreateCase = By.XPath("//input[@ng-model='selectedFeeSelectionSettings.createInterestRefundCase']");
        By SearchTransactions = By.XPath("//input[@ng-model='selectedFeeSelectionSettings.searchTransactionsBasedOnParameters']");
        By TransactionCodes = By.XPath("//input[@ng-model='selectedFeeSelectionSettings.searchTransactionCodes']");
        By SearchDates = By.XPath("//select[@ng-model='selectedFeeSelectionSettings.searchFromDate']");
        By SearchToday = By.XPath("//input[@ng-model='selectedFeeSelectionSettings.searchThroughToday']");
        By Days = By.XPath("//input[@ng-model='selectedFeeSelectionSettings.searchNumberOfDays']");
        By SaveButton = By.XPath("//button[@ng-click='saveFeeSelection()']");
        By CloseButton = By.XPath("(//button[text()='Close'])[1]");
     }
}