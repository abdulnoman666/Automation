namespace UITestAutomation
{
    internal partial class TaskReports : Selenium_Methods
    {
        public void ClickTaskReports()
        {
            ClickTheWebElement(TaskReport_Dropdown);
            WaitForWebElementDisplayed(ExportTasks_Button);
        }
    }
}
