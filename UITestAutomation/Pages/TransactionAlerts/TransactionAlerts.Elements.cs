using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class TransactionAlerts
    {
        //UI Controls on Transaction Alerts Page
        By TransactionAlertsButton = By.XPath("//a[text()='Transaction Alerts']");
        By AddNewTransactionAlert = By.XPath("//button[@ng-click='addNewAlert()']");
        By DeleteAlert = By.XPath("//button[@ng-click='removeAlert($event, t);']");
        By EditAlert = By.XPath("//button[@ng-click='editAlert(t)']");
        By ActionField = By.XPath("//th[1]");
        By IDField = By.XPath("//th[2]");
        By TransactionAlertField = By.XPath("//th[3]");
        By WorkflowsField = By.XPath("//th[4]");
        By ReferenceField = By.XPath("//th[5]");
        By RefreshIcon = By.XPath("//button[@ng-click='refresh()']");

        //Fields on Add Transaction Alerts Page 
        By Name = By.XPath("//input[@ng-model='selectedTransactionAlert.alertInformation.name']");
        By Workflows = By.XPath("//ul[class='select2-selection__rendered']");
        By Reference = By.XPath("//input[@ng-model='selectedTransactionAlert.alertInformation.reference']");
        By Condition = By.XPath("//input[@ng-model='newAlertCondition.condition']");
        By Action = By.XPath("//select[@ng-model='newAlertCondition.action']");
        By Tooltip = By.XPath("//input[@ng-model='newAlertCondition.tooltip']");
        By SaveCondition = By.XPath("//button[@ng-disabled='addScriptItem.$invalid']");
        By SaveButton = By.XPath("//button[@ng-click='saveAlert()']");
        By CloseButton = By.XPath("(//button[text()=\"Close\"])[1]");
        By CrossButton = By.XPath("//button[class='close'][2]");
    }
}
