namespace UITestAutomation.Pages.Tasks
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
