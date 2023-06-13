using OpenQA.Selenium;

namespace UITestAutomation
{
    internal partial class WorkflowAutomations
    {
        By WorkflowAutomationsOption = By.XPath("//div[@id='myNavbar']/ul[@class='nav navbar-nav navbar-right']/li[12]/ul[@class='dropdown-menu']//a[@href='#/finboaworkflowautomation']");
        By AddWorkflowAutomations_Button = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//button[@title='Add Automation']");
        By DeleteWorkflowAutomations_Button = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//div[@class='panel panel-primary']/table/tbody/tr[1]//button[@title='Delete Automation']");
        By EditWorkflowAutomations_Button = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//div[@class='panel panel-primary']/table/tbody/tr[1]//button[@title='Edit Automation']");
        By CopyAutomation_Button = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//div[@class='panel panel-primary']/table/tbody/tr[1]//button[@title='Copy Automation']");
        By DownloadAutomation_Button = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//button[@title='Download Automation']");
        By ConditionSearch_Field = By.XPath("/html//div[@id='main']/div[@class='container']/div[@class='ng-scope']//ul[@class='pagination']//input[@type='text']");

        //On Add Page
<<<<<<< HEAD
        By Name_Field = By.XPath("//div[@id='addWorkflow']//div[@class='modal-body']/form[@name='configform']//input[@name='automationName']");
        By Conditions_Field = By.XPath("//div[@id='addWorkflow']//div[@class='modal-body']/form[@name='configform']/div[3]/input[@type='text']");
        By WorkflowRefrence_Field = By.XPath("//div[@id='addWorkflow']//div[@class='modal-body']/form[@name='configform']/div[4]/input[@type='text']");
        By Scope_Field = By.XPath("//div[@id='addWorkflow']//div[@class='modal-body']/form[@name='configform']//select");

=======
        By Name_Field = By.CssSelector("[ng-model='newWorkflow\\.name']");
        By Conditions_Field = By.CssSelector("[ng-model='newWorkflow\\.conditions']");
        By WorkflowRefrence_Field = By.CssSelector("[ng-model='newWorkflow\\.reference']");
        By Scope_Field = By.XPath("/html//div[@id='addWorkflow']//form[@name='configform']//select");
>>>>>>> f50fa5dd0c8af6747f2b76dcba13fdc7548de1af
    }
}
