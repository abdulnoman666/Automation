using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class Tasks
    {
        //UI Controls on Tasks Page
        By TasksOption = By.LinkText("Tasks");
        By AddNewTask = By.CssSelector("button[title='Add New Task']");
        By DeleteTask = By.CssSelector("button[title='Delete Task']");
        By EditTask = By.CssSelector("button[title='Edit Task']");
        By RefreshIcon = By.CssSelector("button[title = 'Refresh']");
        By ActionField = By.CssSelector("tr > th:nth-of-type(1)");
        By IDField = By.CssSelector("tr > th:nth-of-type(2)");
        By TaskNameField = By.CssSelector("tr > th:nth-of-type(3)");
        By ReferenceField = By.CssSelector("tr > th:nth-of-type(4)");
        By UserPoolField = By.CssSelector("tr > th:nth-of-type(5)");

        //Fields on Add Tasks Page
        By TaskName = By.CssSelector("form[name='fsForm'] > input:nth-of-type(1)");
        By Reference = By.CssSelector("form[name='fsForm'] > input:nth-of-type(2)");
        By UserPool = By.CssSelector("form[name='fsForm'] > select[name='userPoolReference']");
        By SaveButton = By.XPath("//button[@ng-click='saveTask()']");
        By CloseButton = By.CssSelector(".modal-dialog .btn.btn-default");
    }
}
