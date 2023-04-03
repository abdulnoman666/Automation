
namespace UITestAutomation.Pages.WorkflowSettings
{
    internal partial class WorkflowSettings
    {
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
