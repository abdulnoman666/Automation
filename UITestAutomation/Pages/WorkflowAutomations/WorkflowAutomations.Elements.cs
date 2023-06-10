using OpenQA.Selenium;

namespace UITestAutomation
{
    internal partial class WorkflowAutomations
    {
        By WorkflowAutomationsOption = By.LinkText("Workflow Automations");
        By AddWorkflowAutomations_Button = By.CssSelector("button[title='Add Automation']");
        By DeleteWorkflowAutomations_Button = By.CssSelector("tr:nth-of-type(1) > th > button[title='Delete Automation']");
        By EditWorkflowAutomations_Button = By.CssSelector("tr:nth-of-type(1) > th > button[title='Edit Automation']");
        By CopyAutomation_Button = By.CssSelector("tr:nth-of-type(1) > th > button[title='Copy Automation']");
        By DownloadAutomation_Button = By.CssSelector("button[title='Download Automation']");
        By ConditionSearch_Field = By.CssSelector("[ng-model='workflowsearch\\.conditions']");

        //On Add Page
        By Name_Field = By.CssSelector("[ng-model='newWorkflow\\.name']");
        By Conditions_Field = By.CssSelector("[ng-model='newWorkflow\\.conditions']");
        By WorkflowRefrence_Field = By.CssSelector("[ng-model='newWorkflow\\.reference']");
        By Scope_Field = By.XPath("/html//div[@id='addWorkflow']//form[@name='configform']//select");
    }
}
