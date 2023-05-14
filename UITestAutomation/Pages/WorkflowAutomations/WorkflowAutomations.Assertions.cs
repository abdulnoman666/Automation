
namespace UITestAutomation
{
  internal partial class WorkflowAutomations
    {
        public void AssertUIControlsOnWorkflowAutomationsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Add workflow":
                        FluentWaitForWebElement(AddWorkflowAutomations_Button);
                        break;
                    case "Delete Workflow":
                        FluentWaitForWebElement(DeleteWorkflowAutomations_Button);
                        break;
                    case "Edit Workflow":
                        FluentWaitForWebElement(EditWorkflowAutomations_Button);
                        break;
                    case "Copy WorkFlow":
                        FluentWaitForWebElement(CopyAutomation_Button);
                        break;
                    case "Download Automation":
                        FluentWaitForWebElement(DownloadAutomation_Button);
                        break;
                    case "Condition Search":
                        FluentWaitForWebElement(ConditionSearch_Field);
                        break;
                }
            }
        }
        public void AssertFieldssOnAddWorkflowAutomationsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Name":
                        FluentWaitForWebElement(Name_Field);
                        break;
                    case "Conditions":
                        FluentWaitForWebElement(Conditions_Field);
                        break;
                    case "Workflow Refrence":
                        FluentWaitForWebElement(WorkflowRefrence_Field);
                        break;
                    case "Scope":
                        FluentWaitForWebElement(Scope_Field);
                        break;
                }
            }
        }
    }
}
