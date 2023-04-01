using FluentAssertions.Equivalency;
using NUnit.Framework.Internal.Execution;
using OpenQA.Selenium;
using System.Diagnostics.Metrics;
using System.Security.Principal;
using System.Transactions;

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
        By WorkflowSetting_Dropdown = By.XPath("//a[@href='#/workflowsettings']");

        ////on Delete Page
        //By No_Button = By.XPath("//button[@ng-click=\"dialog.abort()\"]");
        //By Yes_Button = By.XPath("//button[@ng-click=\"dialog.hide()\"]");

        //Add page (Settings UI Control)
        By Setting_Button = By.CssSelector(".ng-invalid-required [heading='Settings'] .ng-binding");
        By EventTriggers_Button = By.CssSelector(".ng-invalid-required [heading='Event Triggers'] .ng-binding");
        By SelfServiceVerbiage_Button = By.CssSelector("[heading='Self-Service Verbiage'] .ng-binding");
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
        By CloseAccount_Field = By.CssSelector(".ng-scope:nth-child(10) [name='closedAccountCondition']");
        By AddTransactions_Checkbox = By.XPath("//input[@ng-model=\"setting.addTransactions\"]");
        By AllowManualTransactions_Checkbox = By.XPath("//input[@ng-model=\"setting.allowManualTransactions\"]");
        By AllowUserToCopy_Checkbox = By.XPath("//input[@ng-model=\"setting.copyTransactions\"]");
        By CopyDescription_Checkbox = By.XPath("//input[@ng-model=\"setting.populateMerchantField\"]");
        By MerchantCopySource_Field = By.CssSelector("div:nth-of-type(11) > input[name='closedAccountCondition']");
        By TransactionFilterCondition_Field = By.CssSelector(".ng-invalid-required [name='transactionSearchCondition']");
        By TransactionNotAllowedCondition_Field = By.CssSelector(".ng-invalid-required [name='transactionNotAllowedCondition']");
        By ShowFraud_Checkbox = By.XPath("//input[@ng-model=\"setting.fraudNonFraud\"]");
        By DisableCustomerEdit_Checkbox = By.XPath("//input[@ng-model=\"setting.disableCustomerNameEdit\"]");
        By Questionnaire_Checkbox = By.XPath("//input[@ng-model=\"setting.hasQuestionnaire\"]");
        By ProvisionalCreditCalculation_Checkbox = By.XPath("//input[@ng-model=\"setting.provisionalCreditCalc\"]");
        By ShowCustomerType_Checkbox = By.XPath("//input[@ng-model=\"setting.customerType\"]");
        By HideComments_Checkbox = By.XPath("//input[@ng-model=\"setting.hideCommentsAndResolutionField\"]");
        By ReimburseFees_Checkbox = By.XPath("//input[@ng-model=\"setting.autoFeeReimbursement\"]");
        By TransactionCodeFilter_Field = By.CssSelector(".ng-invalid-required [name='feeTransactionCode']");
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
        By AddEventTrigger_Button = By.CssSelector(".ng-invalid-required .glyphicon-plus");
        By ActionOnEvent_Field = By.CssSelector(".ng-invalid-required tr th:nth-of-type(1)");
        By TriggerName_Field = By.CssSelector(".ng-invalid-required tr th:nth-of-type(2)");
        By TriggerEventType_Field = By.CssSelector(".ng-invalid-required tr th:nth-of-type(3)");

        //Fields on Add Trigger
        By TriggerNameOnAdd_Field = By.CssSelector("form[name='eventForm'] > input[name='triggerName']");
        By TriggerEventTypeOnAdd_Field = By.CssSelector("form[name='eventForm'] > input[name='triggerEventType']");
        By AdditionalCondition_Checkbox = By.XPath("//input[@ng-model=\"trigger.additionalCondition\"]");
        By AccountType_Checkbox = By.XPath("//input[@ng-model=\"trigger.addAccountTypeRestriction\"]");
        By AccountTypeTrigger_Dropdown = By.XPath("//select[@ng-model=\"trigger.accountTypeRestriction\"]");
        By AutomationReference_Checkbox = By.XPath("//input[@ng-model=\"trigger.automationReferenceFlag\"]");
        By AutomationReference_Dropdown =By.XPath("//select[@ng-model=\"trigger.automationReference\"]");
        By LetterTemplateReference_Checkbox = By.XPath("//input[@ng-model=\"trigger.templateReferenceFlag\"]");
        By LetterTemplateReference_Dropdown =By.XPath("//select[@ng-model=\"trigger.templateReference\"]");
        By GLReferenceTrigger_Checkbox = By.XPath("//input[@ng-model=\"trigger.glReferenceFlag\"]");
        By GLReferenceTrigger_Dropdown = By.XPath("//select[@ng-model=\"trigger.glReference\"]");
        By RunAutomation_Checkbox = By.XPath("//input[@ng-model=\"trigger.runAutomationFlag\"]");
        By AutomationReferenceAction_Dropdown = By.XPath("//select[@ng-model=\"trigger.runAutomationReference\"]");
        By SendEmailNotification_Checkbox = By.XPath("//input[@ng-model=\"trigger.emailNotificationFlag\"]");
        By EmailLetterTemplateReference_Dropdown = By.XPath("//select[@ng-model=\"trigger.emailTemplateReference\"]");
        By EmailDistributionList_Dropdown = By.XPath("//input[@ng-model=\"trigger.emailDistributionList\"]");
        By CloseTrigger_Button = By.CssSelector("div#addTrigger  .modal-content  .btn.btn-default");
        By SaveTrigger_Button = By.CssSelector("div#addTrigger  .modal-content  .btn.btn-info");

        //Fields on Self-Verbage
        By CompletionTitle_Field = By.CssSelector(".tab-content > div:nth-of-type(3) input[name='alertName']");
        By CompletionNote_Field = By.CssSelector(".fr-wrapper.show-placeholder > .fr-element.fr-view");

        public void ClickWorkflowSettings()
        {
            ClickTheWebElement(WorkflowSetting_Dropdown);
            WaitForWebElementDisplayed(EditWorkflowSetting_Button);
        }
        public void AssertUIControlsonWorkflowSettingPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Add":
                        FluentWaitForWebElement(AddWorkflowSetting_Button);
                        break;
                    case "Edit":
                        FluentWaitForWebElement(EditWorkflowSetting_Button);
                        break;
                    case "Delete":
                        FluentWaitForWebElement(DeleteWorkflowSetting_Button);
                        break;
                    case "Download Letter":
                        FluentWaitForWebElement(DownloadLetter_Button);
                        break;
                    case "Action":
                        FluentWaitForWebElement(Action_Field);
                        break;
                    case "ID":
                        FluentWaitForWebElement(ID_Field);
                        break;
                    case "Workflow":
                        FluentWaitForWebElement(Workflow_Field);
                        break;
                    case "Refresh":
                        FluentWaitForWebElement(Refresh_Button);
                        break;
                }
            }
        }

        public void ClickAddWorkflowSettings()
        {
            ClickOnWebElement(AddWorkflowSetting_Button);
            WaitForWebElementDisplayed(Workflow_field);
        }

        public void AssertUIControlsonEditWorkflowSettingDialog(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Settings":
                        FluentWaitForWebElement(Setting_Button);
                        break;
                    case "Event Triggers":
                        FluentWaitForWebElement(EventTriggers_Button);
                        break;
                    case "Self-Service Verbiage":
                        FluentWaitForWebElement(SelfServiceVerbiage_Button);
                        break;
                    case "Close":
                        FluentWaitForWebElement(Close_Button);
                        break;
                    case "Save":
                        FluentWaitForWebElement(Save_Button);
                        break;
                }
            }
        }

        public void AssertFieldsonEditWorkflowSettingDialog(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Workflow":
                        FluentWaitForWebElement(Workflow_field);
                        break;
                    case "Publish":
                        FluentWaitForWebElement(Publish_Checkbox);
                        break;
                    case "Allow Customer Access":
                        FluentWaitForWebElement(AllowCustomerAcess_Checkbox);
                        break;
                    case "Search By":
                        FluentWaitForWebElement(SearchBy_Dropdown);
                        break;
                    case "Send Notifications":
                        FluentWaitForWebElement(SendNotification_Checkbox);
                        break;
                    case "Distribution List":
                        FluentWaitForWebElement(DistributionList_Field);
                        break;
                    case "Transaction Type":
                        FluentWaitForWebElement(TransactionType_Dropdown);
                        break;
                    case "Account Types Allowed":
                        FluentWaitForWebElement(AccountType_Field);
                        break;
                    case "Closed Account Status":
                        FluentWaitForWebElement(CloseAccount_Field);
                        break;
                    case "Add Transactions":
                        FluentWaitForWebElement(AddTransactions_Checkbox);
                        break;
                    case "Allow Manual Transactions":
                        FluentWaitForWebElement(AllowManualTransactions_Checkbox);
                        break;
                    case "Allow user to copy / duplicate transactions":
                        FluentWaitForWebElement(AllowUserToCopy_Checkbox);
                        break;
                    case "Copy Description to Merchant Field by Default":
                        FluentWaitForWebElement(CopyDescription_Checkbox);
                        break;
                    case "Merchant Copy Source Field Name":
                        FluentWaitForWebElement(MerchantCopySource_Field);
                        break;
                    case "Transaction Filter Condition":
                        FluentWaitForWebElement(TransactionFilterCondition_Field);
                        break;
                    case "Transaction Not Allowed Condition":
                        FluentWaitForWebElement(TransactionNotAllowedCondition_Field);
                        break;
                    case "Show Fraud / Non-Fraud Option":
                        FluentWaitForWebElement(ShowFraud_Checkbox);
                        break;
                    case "Disable Customer Edit":
                        FluentWaitForWebElement(DisableCustomerEdit_Checkbox);
                        break;
                    case "Has Questionnaire":
                        FluentWaitForWebElement(Questionnaire_Checkbox);
                        break;
                    case "Has Provisional Credit Calculation":
                        FluentWaitForWebElement(ProvisionalCreditCalculation_Checkbox);
                        break;
                    case "Show Customer Type":
                        FluentWaitForWebElement(ShowCustomerType_Checkbox);
                        break;
                    case "Hide Comments And Resolution":
                        FluentWaitForWebElement(HideComments_Checkbox);
                        break;
                    case "Reimburse Fees":
                        FluentWaitForWebElement(ReimburseFees_Checkbox);
                        break;
                    case "Transaction Code Filter":
                        FluentWaitForWebElement(TransactionCodeFilter_Field);
                        break;
                    case "GL Reference":
                        FluentWaitForWebElement(GLReference_Dropdown);
                        break;
                    case "Interest Posting GL Reference":
                        FluentWaitForWebElement(InterestPostingGLReference_Dropdown);
                        break;
                    case "Compliance Regulation Screen":
                        FluentWaitForWebElement(ComplianceRegulationScreen_Dropdown);
                        break;
                    case "Dispute Screen Type":
                        FluentWaitForWebElement(DisputeScreenType_Dropdown);
                        break;
                    case "Email Template Reference":
                        FluentWaitForWebElement(EmailTemplateReference_Dropdown);
                        break;
                    case "Confirmation Email Template Reference":
                        FluentWaitForWebElement(ConfirmationEmailTemplate_Dropdown);
                        break;
                    case "Post Submission Automation Reference":
                        FluentWaitForWebElement(PostSubmissionAutomation_Dropdown);
                        break;
                    case "Automation Reference On Submission Complete":
                        FluentWaitForWebElement(AutomationReferenceOnSubmission_Dropdown);
                        break;
                    case "Submission Screen Template":
                        FluentWaitForWebElement(SubmissionScreenTemplate_Dropdown);
                        break;

                }
            }
        }

        public void ClickEventTrigger()
        {
            ClickTheWebElement(EventTriggers_Button);
            WaitForWebElementDisplayed(AddEventTrigger_Button);
        }

        public void AssertUIControlsOnEventTriggers(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Action":
                        FluentWaitForWebElement(ActionOnEvent_Field);
                        break;
                    case "Trigger Name":
                        FluentWaitForWebElement(TriggerName_Field);
                        break;
                    case "Trigger Event Type":
                        FluentWaitForWebElement(TriggerEventType_Field);
                        break;
                    case "Add":
                        FluentWaitForWebElement(AddEventTrigger_Button);
                        break;
                }
            }
        }

        public void ClickAddEventTriggerButton()
        {
            ClickTheWebElement(AddEventTrigger_Button);
            WaitForWebElementDisplayed(CloseTrigger_Button);
        }

        public void AssertFieldsOnAddTriggersDialog(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Trigger Name":
                        FluentWaitForWebElement(TriggerNameOnAdd_Field);
                        break;
                    case "Trigger Event Type":
                        FluentWaitForWebElement(TriggerEventTypeOnAdd_Field);
                        break;
                    case "Additional Condition (search for below)":
                        FluentWaitForWebElement(AdditionalCondition_Checkbox);
                        break;
                    case "Account Type":
                        FluentWaitForWebElement(AccountType_Checkbox);
                        FluentWaitForWebElement(AccountTypeTrigger_Dropdown);
                        break;
                    case "Automation Reference":
                        FluentWaitForWebElement(AutomationReference_Checkbox);
                        FluentWaitForWebElement(AutomationReference_Dropdown);
                        break;
                    case "Letter Template Reference":
                        FluentWaitForWebElement(LetterTemplateReference_Checkbox);
                        FluentWaitForWebElement(LetterTemplateReference_Dropdown);
                        break;
                    case "GL Reference":
                        FluentWaitForWebElement(GLReferenceTrigger_Checkbox);
                        FluentWaitForWebElement(GLReferenceTrigger_Dropdown);
                        break;
                    case "Run Automation":
                        FluentWaitForWebElement(RunAutomation_Checkbox);
                        break;
                    case "AutomationReference":
                        FluentWaitForWebElement(AutomationReferenceAction_Dropdown);
                        break;
                    case "Send Email Notification":
                        FluentWaitForWebElement(SendEmailNotification_Checkbox);
                        break;
                    case "Email Letter Template Reference":
                        FluentWaitForWebElement(EmailLetterTemplateReference_Dropdown);
                        break;
                    case "Email Distribution List":
                        FluentWaitForWebElement(EmailDistributionList_Dropdown);
                        break;
                    case "Close":
                        FluentWaitForWebElement(CloseTrigger_Button);
                        break;
                    case "Save":
                        FluentWaitForWebElement(SaveTrigger_Button);
                        break;
                }
            }
        }

        public void ClickSelfServiceVerbiageButton()
        {
            ClickTheWebElement(CloseTrigger_Button);
            ClickTheWebElement(SelfServiceVerbiage_Button);
            WaitForWebElementDisplayed(CompletionNote_Field);
        }

        public void AssertFieldsOnSelfServiceVerbiageDialog(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Self-Service Portal Submission Completion Title":
                        FluentWaitForWebElement(CompletionTitle_Field);
                        break;
                    case "Self-Service Portal Submission Completion Note":
                        FluentWaitForWebElement(CompletionNote_Field);
                        break;
                    case "Close":
                        FluentWaitForWebElement(Close_Button);
                        break;
                    case "Save":
                        FluentWaitForWebElement(Save_Button);
                        break;
                }
            }
        }

    }
}
