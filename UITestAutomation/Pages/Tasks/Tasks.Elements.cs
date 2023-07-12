using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class Tasks
    {
        //UI Controls on Tasks Page
        By TasksOption = By.XPath("//a[text()='Tasks']");
        By AddNewTask = By.XPath("//button[@ng-click='addNewTask()']");
        By DeleteTask = By.XPath("button[title='Delete Task']");
        By EditTask = By.XPath("//button[@ng-click='editTask(st)']");
        By RefreshIcon = By.XPath("//button[@ng-click='refresh()']");
        By ActionField = By.XPath("//th[1]");
        By IDField = By.XPath("//th[2]");
        By TaskNameField = By.XPath("//th[3]");
        By ReferenceField = By.XPath("//th[4]");
        By UserPoolField = By.XPath("//th[5]");

        //Fields on Add Tasks Page
        By TaskName = By.XPath("//input[@ng-model='selectedSubmissionTask.name']");
        By Reference = By.XPath("//input[@ng-model='selectedSubmissionTask.reference']");
        By UserPool = By.XPath("//select[@ng-model='selectedSubmissionTask.userPoolReference']");
        By SaveButton = By.XPath("//button[@ng-click='saveTask()']");
        By CloseButton = By.XPath("(//button[text()=\"Close\"])[1]");
    }
}
