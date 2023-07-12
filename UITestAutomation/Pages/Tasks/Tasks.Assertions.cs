namespace UITestAutomation
{
    internal partial class Tasks: Selenium_Methods
    {
        public void AssertUIControlsOnTasksPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Add New Task":
                        WaitForWebElementDisplayed(AddNewTask);
                        FluentWaitForWebElement(AddNewTask);
                        break;
                    case " Delete Task":
                        FluentWaitForWebElement(DeleteTask);
                        break;
                    case " Edit Task":
                        FluentWaitForWebElement(EditTask);
                        break;
                    case " Refresh":
                        FluentWaitForWebElement(RefreshIcon);
                        break;
                    case " Action":
                        FluentWaitForWebElement(ActionField);
                        break;
                    case " ID":
                        FluentWaitForWebElement(IDField);
                        break;
                    case " Task Name":
                        FluentWaitForWebElement(TaskNameField);
                        break;
                    case " Reference":
                        FluentWaitForWebElement(ReferenceField);
                        break;
                    case " User Pool":
                        FluentWaitForWebElement(UserPoolField);
                        break;
                }
            }
        }

        public void AssertFieldsOnAddTasksPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Task Name":
                        WaitForWebElementDisplayed(TaskName);
                        FluentWaitForWebElement(TaskName);
                        break;
                    case " Reference":
                        FluentWaitForWebElement(Reference);
                        break;
                    case " User Pool":
                        FluentWaitForWebElement(UserPool);
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
