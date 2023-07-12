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
            WaitForWebElementDisplayed(AddNewTask);
            ClickOnWebElement(AddNewTask);
        }
        public void ClickCloseButtonAddNewTask()
        {
            WaitForWebElementDisplayed(CloseButton);
            ClickOnWebElement(CloseButton);
          
        }
    }
}
