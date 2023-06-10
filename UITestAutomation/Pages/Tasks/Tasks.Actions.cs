namespace UITestAutomation
{
    internal partial class Tasks
    {
        public void ClickTasksButton()
        {
            WaitForWebElementDisplayed(TasksOption);
            ClickOnWebElement(TasksOption);
        }
        public void ClickAddNewTaskButton()
        {
            ClickOnWebElement(AddNewTask);
            WaitForWebElementDisplayed(AddNewTask);
        }
    }
}
