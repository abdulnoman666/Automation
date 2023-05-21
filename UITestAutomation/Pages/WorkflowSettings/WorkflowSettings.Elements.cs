using OpenQA.Selenium;


namespace UITestAutomation
{
    internal partial class WorkflowSettings
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
        By WorkflowSetting_Dropdown = By.XPath("//a[@href='#/workflowsettings']");

        ////on Delete Page
        //By No_Button = By.XPath("//button[@ng-click=\"dialog.abort()\"]");
        //By Yes_Button = By.XPath("//button[@ng-click=\"dialog.hide()\"]");

        //Add page (Settings UI Control)
        By Setting_Button = By.XPath("(//a[text()=\"Settings\"])[1]");
        By EventTriggers_Button = By.XPath("(//a[text()=\"Event Triggers\"])[1]");
        By SelfServiceVerbiage_Button = By.XPath("(//a[text()=\"Self-Service Verbiage\"])[1]");
        By Save_Button = By.XPath("(//button[@ng-click=\"savesetting()\"])[1]");
        By Close_Button = By.XPath("(//button[text()=\"Close\"])[2]");

        //fields on setting page
        By Workflow_field = By.XPath("//input[@ng-model=\"setting.source\"]");
        By Publish_Checkbox = By.XPath("//input[@ng-model=\"setting.publish\"]");
        By AllowCustomerAcess_Checkbox = By.XPath("//input[@ng-model=\"setting.customerAccess\"]");
        By SearchBy_Dropdown = By.XPath("//select[@ng-model=\"setting.searchBy\"]");
        By SendNotification_Checkbox = By.XPath("//input[@ng-model=\"setting.sendNotifications\"]");
        By DistributionList_Field = By.XPath("//input[@ng-model=\"setting.distributionList\"]");
        By TransactionType_Dropdown = By.XPath("//select[@ng-model=\"setting.transactionType\"]");
        By AccountType_Field = By.XPath("//input[@ng-model=\"setting.accountSearchCondition\"]");
        By CloseAccount_Field = By.XPath("//input[@ng-model=\"setting.closedAccountCondition\"]");
        By AddTransactions_Checkbox = By.XPath("//input[@ng-model=\"setting.addTransactions\"]");
        By AllowManualTransactions_Checkbox = By.XPath("//input[@ng-model=\"setting.allowManualTransactions\"]");
        By AllowUserToCopy_Checkbox = By.XPath("//input[@ng-model=\"setting.copyTransactions\"]");
        By CopyDescription_Checkbox = By.XPath("//input[@ng-model=\"setting.populateMerchantField\"]");
        By MerchantCopySource_Field = By.XPath("//input[@ng-model=\"setting.merchantCopySource\"]");
        By TransactionFilterCondition_Field = By.XPath("//input [@ng-model=\"setting.transactionSearchCondition\"]");
        By TransactionNotAllowedCondition_Field = By.XPath("//input[@ng-model=\"setting.transactionNotAllowedCondition\"]");
        By ShowFraud_Checkbox = By.XPath("//input[@ng-model=\"setting.fraudNonFraud\"]");
        By DisableCustomerEdit_Checkbox = By.XPath("//input[@ng-model=\"setting.disableCustomerNameEdit\"]");
        By Questionnaire_Checkbox = By.XPath("//input[@ng-model=\"setting.hasQuestionnaire\"]");
        By ProvisionalCreditCalculation_Checkbox = By.XPath("//input[@ng-model=\"setting.provisionalCreditCalc\"]");
        By ShowCustomerType_Checkbox = By.XPath("//input[@ng-model=\"setting.customerType\"]");
        By HideComments_Checkbox = By.XPath("//input[@ng-model=\"setting.hideCommentsAndResolutionField\"]");
        By ReimburseFees_Checkbox = By.XPath("//input[@ng-model=\"setting.autoFeeReimbursement\"]");
        By TransactionCodeFilter_Field = By.XPath("//input[@ng-model=\"setting.feeTransactionCode\"]");
        By GLReference_Dropdown = By.XPath("//select[@ng-model=\"setting.feeGLReference\"]");
        By InterestPostingGLReference_Dropdown = By.XPath("//select[@ng-model=\"setting.interestPostingGLReference\"]");
        By ComplianceRegulationScreen_Dropdown = By.XPath("//select[@ng-model=\"setting.complianceRegulationScreen\"]");
        By DisputeScreenType_Dropdown = By.XPath("//select[@ng-model=\"setting.disputeScreenType\"]");
        By EmailTemplateReference_Dropdown = By.XPath("//select[@ng-model=\"setting.emailTemplateReference\"]");
        By ConfirmationEmailTemplate_Dropdown = By.XPath("//select[@ng-model=\"setting.confirmationEmailTemplateReference\"]");
        By PostSubmissionAutomation_Dropdown = By.XPath("//select[@ng-model=\"setting.confirmationAutomationReference\"]");
        By AutomationReferenceOnSubmission_Dropdown = By.XPath("//select[@ng-model=\"setting.automationReferenceSubmissionComplete\"]");
        By SubmissionScreenTemplate_Dropdown = By.XPath("//select[@ng-model=\"setting.screenTemplateReference\"]");

        //Controls on Event Trigger page
        By AddEventTrigger_Button = By.XPath("(//button[@ng-click=\"addTrigger()\"])[1]");
        By ActionOnEvent_Field = By.XPath("(//th[text()=\"Action\"])[3]");
        By TriggerName_Field = By.XPath("(//th[text()=\"Trigger Name\"])[1]");
        By TriggerEventType_Field = By.XPath("(//th[text()=\"Trigger Event Type\"])[1]");

        //Fields on Add Trigger
        By TriggerNameOnAdd_Field = By.XPath("//input[@ng-model=\"trigger.triggerName\"]");
        By TriggerEventTypeOnAdd_Field = By.XPath("//input[@ng-model=\"trigger.triggerEventType\"]");
        By AdditionalCondition_Checkbox = By.XPath("//input[@ng-model=\"trigger.additionalCondition\"]");
        By AccountType_Checkbox = By.XPath("//input[@ng-model=\"trigger.addAccountTypeRestriction\"]");
        By AccountTypeTrigger_Dropdown = By.XPath("//select[@ng-model=\"trigger.accountTypeRestriction\"]");
        By AutomationReference_Checkbox = By.XPath("//input[@ng-model=\"trigger.automationReferenceFlag\"]");
        By AutomationReference_Dropdown = By.XPath("//select[@ng-model=\"trigger.automationReference\"]");
        By LetterTemplateReference_Checkbox = By.XPath("//input[@ng-model=\"trigger.templateReferenceFlag\"]");
        By LetterTemplateReference_Dropdown = By.XPath("//select[@ng-model=\"trigger.templateReference\"]");
        By GLReferenceTrigger_Checkbox = By.XPath("//input[@ng-model=\"trigger.glReferenceFlag\"]");
        By GLReferenceTrigger_Dropdown = By.XPath("//select[@ng-model=\"trigger.glReference\"]");
        By RunAutomation_Checkbox = By.XPath("//input[@ng-model=\"trigger.runAutomationFlag\"]");
        By AutomationReferenceAction_Dropdown = By.XPath("//select[@ng-model=\"trigger.runAutomationReference\"]");
        By SendEmailNotification_Checkbox = By.XPath("//input[@ng-model=\"trigger.emailNotificationFlag\"]");
        By EmailLetterTemplateReference_Dropdown = By.XPath("//select[@ng-model=\"trigger.emailTemplateReference\"]");
        By EmailDistributionList_Dropdown = By.XPath("//input[@ng-model=\"trigger.emailDistributionList\"]");
        By CloseTrigger_Button = By.XPath("(//button[text()=\"Close\"])[4]");
        By SaveTrigger_Button = By.XPath("//button[@ng-click=\"saveTrigger()\"]");

        //Fields on Self-Verbage
        By CompletionTitle_Field = By.XPath("//input[@ng-model=\"setting.selfServicePortalSubmissionCompletionTitle\"]");
        By CompletionNote_Field = By.XPath("//div[@class=\"fr-element fr-view\"]");

    }
}
