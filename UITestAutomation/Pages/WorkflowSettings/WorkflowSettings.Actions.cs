using System;


namespace UITestAutomation.Pages.WorkflowSettings
{
    internal partial class WorkflowSettings : Selenium_Methods
    {
        public void ClickWorkflowSettings()
        {
            ClickTheWebElement(WorkflowSetting_Dropdown);
            WaitForWebElementDisplayed(EditWorkflowSetting_Button);
        }

        public void ClickAddWorkflowSettings()
        {
            ClickOnWebElement(AddWorkflowSetting_Button);
            WaitForWebElementDisplayed(Workflow_field);
        }

        public void ClickEventTrigger()
        {
            ClickTheWebElement(EventTriggers_Button);
            WaitForWebElementDisplayed(AddEventTrigger_Button);
        }

        public void ClickAddEventTriggerButton()
        {
            ClickTheWebElement(AddEventTrigger_Button);
            WaitForWebElementDisplayed(CloseTrigger_Button);
        }

        public void ClickCloseButtononAddTriggerDialog()
        {
            ClickTheWebElement(CloseTrigger_Button);
        }

        public void ClickSelfServiceVerbiageButton()
        {
            ClickTheWebElement(SelfServiceVerbiage_Button);
            WaitForWebElementDisplayed(CompletionNote_Field);
        }

        public void ClickCloseButtononSelfVerbiage()
        {
            ClickOnWebElement(Close_Button);
        }
    }
}
