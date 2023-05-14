using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class TransactionAlerts
    {
        //UI Controls on Transaction Alerts Page
        By TransactionAlertsButton = By.LinkText("Transaction Alerts");
        By AddNewTransactionAlert = By.CssSelector("button[title='Add New Transaction Alert']");
        By ActionField = By.CssSelector("tr th:nth-of-type(1)");
        By IDField = By.CssSelector("tr th:nth-of-type(2)");
        By TransactionAlertField = By.CssSelector("tr th:nth-of-type(3)");
        By WorkflowsField = By.CssSelector("tr th:nth-of-type(4)");
        By ReferenceField = By.CssSelector("tr th:nth-of-type(5)");
        By RefreshIcon = By.CssSelector("button[title='Refresh']");

        //Fields on Add Transaction Alerts Page 
        By Name = By.CssSelector("form[name='fsForm'] > input[name='alertName']");
        By Workflows = By.CssSelector(".select2-selection__rendered");
        By Reference = By.CssSelector("form[name='fsForm'] > input[name='alertReference']");
        By Condition = By.CssSelector("div > input:nth-of-type(7)");
        By Action = By.XPath("//select[@ng-model='newAlertCondition.action']");
        By Tooltip = By.CssSelector("div > input:nth-of-type(8)");
        By SaveCondition = By.CssSelector(".btn.btn-default.btn-sm");
        By SaveButton = By.CssSelector(".modal-footer [data-dismiss='modal']:nth-of-type(2)");
        By CloseButton = By.CssSelector(".modal-lg .modal-footer [data-dismiss='modal']:nth-of-type(1)");
        By CrossButton = By.CssSelector(".modal-dialog.modal-lg .close");
    }
}
