
namespace UITestAutomation
{
    internal partial class WorkflowAutomations : Selenium_Methods
    {
        public void ClickWorkflowAutomation()
        {
            ClickTheWebElement(WorkflowAutomation_Icon);
            WaitForWebElementDisplayed(ConditionSearch_Field);
        }

        public void ClickAddWorkflowAutomations()
        {
            ClickTheWebElement(AddWorkflowAutomations_Button);
            WaitForWebElementDisplayed(Scope_Field);
        }
    }
}
