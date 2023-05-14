
namespace UITestAutomation
{
    internal partial class MyTasks
    {
        public void AssertFieldsonMyTasksPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Show Closed Tasks":
                        WaitForWebElementDisplayed(ShowClosedTasks_Button);
                        FluentWaitForWebElement(ShowClosedTasks_Button);
                        break;
                    case "Actions":
                        FluentWaitForWebElement(Actions_Field);
                        break;
                    case "Status":
                        FluentWaitForWebElement(Status_Field);
                        break;
                    case "Task":
                        FluentWaitForWebElement(Task_Field);
                        break;
                    case "Case ID":
                        FluentWaitForWebElement(CaseID_Field);
                        break;
                    case "Created On":
                        FluentWaitForWebElement(CreatedOn_Field);
                        break;
                    case "Assigned On":
                        FluentWaitForWebElement(AssignedOn_Field);
                        break;
                }
            }
        }
    }
}
