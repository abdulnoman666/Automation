using OpenQA.Selenium;

namespace UITestAutomation.Pages
{
    public class WorkflowSettings : Selenium_Methods
    {
        //on the workflow page
        By AddWorkflowSetting_Button = By.XPath("//button[@ng-click=\"addsetting()\"]");
        By DownloadLetter_Button = By.XPath("//button[@title=\"Download Letter\"]");
        By DeleteWorkflowSetting_Button = By.XPath("//button[@ng-click=\"deleteSetting($event, s)\"]");
        By EditWorkflowSetting_Button = By.XPath("//button[@ng-click=\"editsetting(s)\"]");
        By Action_Field = By.XPath("//div[@class='panel-body']//th[.='Action']");
        By ID_Field = By.XPath("//div[@class='panel-body']//th[.='ID']");
        By Workflow_Field = By.XPath("//div[@class='panel-body']/table/thead/tr/th[3]");
        By Refresh_Button = By.XPath("//button[@ng-click=\"refresh()\"]");

        //on Delete Page
        By No_Button = By.XPath("//button[@ng-click=\"dialog.abort()\"]");
        By Yes_Button = By.XPath("//button[@ng-click=\"dialog.hide()\"]");

        //Add page (Settings UI Control)
        By Setting_Button = By.CssSelector(".ng-invalid-required [heading='Settings'] .ng-binding");
        By EventTriggers_Button = By.CssSelector(".ng-invalid-required [heading='Event Triggers'] .ng-binding");
        By SelfServiceVerbiage_Button = By.CssSelector("[heading='Self-Service Verbiage'] .ng-binding");
        By UploadToLibrary_Button = By.XPath("//button[@ng-click=\"copyToNewWorkflow()\"]");
        By Save_Button = By.CssSelector(".modal-footer [data-dismiss='modal']:nth-of-type(3)");
        By Close_Button = By.CssSelector(".ng-invalid-required .modal-footer [data-dismiss='modal']:nth-of-type(2)");

        //fields on setting page
        By Workflow_field = By.XPath("//input[@ng-model=\"setting.source\"]");
        By Publish_Checkbox = By.XPath("//input[@ng-model=\"setting.publish\"]");
        By AllowCustomerAcess_Checkbox = By.XPath("//input[@ng-model=\"setting.customerAccess\"]");
        By SearchBy_Dropdown = By.XPath("//select[@ng-model=\"setting.searchBy\"]");
        By SendNotification_Checkbox = By.XPath("//input[@ng-model=\"setting.sendNotifications\"]");
        By DistributionList_Field = By.XPath("//input[@ng-model=\"setting.distributionList\"]");
        By TransactionType_Dropdown = By.XPath("//select[@ng-model=\"setting.transactionType\"]");
        By AccountType_Field = By.XPath("//input[@ng-model=\"setting.accountSearchCondition\"]");





            
    }
}
