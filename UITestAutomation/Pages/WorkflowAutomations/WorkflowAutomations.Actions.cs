using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestAutomation
{
    internal partial class WorkflowAutomations : Selenium_Methods
    {
        public void ClickWorkflowAutomationsButton()
        {
            WaitForWebElementDisplayed(WorkflowAutomationsOption);
            ClickOnWebElement(WorkflowAutomationsOption);
        }
        public void ClickOnAddWorkflowAutomationsButton()
        {
            WaitForWebElementDisplayed(AddWorkflowAutomations_Button);
            ClickOnWebElement(AddWorkflowAutomations_Button);
        }
    }
}
