
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;

namespace UITestAutomation
{
    internal partial class WorkflowSettings
    {
        int count;
        bool value;
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
                        count = GetElements(DeleteWorkflowSetting_Button).Count();
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

        //add
        public void AddvaluesonEditWorkflowSettingDialog(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Workflow":
                      //  Thread.Sleep(5000);
                        EnterValueinWebElement(Workflow_field, item[1]);
                        break;
                    case "Publish":
                       ClickOnWebElement(Publish_Checkbox);
                        break;
                    case "Allow Customer Access":
                        ClickOnWebElement(AllowCustomerAcess_Checkbox);
                        break;
                    case "Customer Description":
                        EnterValueinWebElement(CustomerDescription_Textbox, item[1]);
                        break;
                    case "Search By":
                        ClickOnWebElement(SearchBy_Dropdown);
                        ElementToBeSelectedFromDropdown(SearchBy_Dropdown, item[1]);
                        ClickOnWebElement(SearchBy_Dropdown);
                        break;
                    case "Send Notifications":
                        ClickOnWebElement(SendNotification_Checkbox);
                        break;
                    case "Distribution List":
                        EnterValueinWebElement(DistributionList_Field, item[1]);
                        break;
                    case "Transaction Type":
                        ClickOnWebElement(TransactionType_Dropdown);
                        ElementToBeSelectedFromDropdown(TransactionType_Dropdown, item[1]);
                        ClickOnWebElement(TransactionType_Dropdown);
                        break;
                    case "Account Types Allowed":
                       EnterValueinWebElement(AccountType_Field, item[1]);
                        break;
                    case "Closed Account Status":
                       EnterValueinWebElement(CloseAccount_Field, item[1]);
                        break;
                    case "Add Transactions":
                        ClickOnWebElement(AddTransactions_Checkbox);
                        break;
                    case "Allow Manual Transactions":
                        ClickOnWebElement(AllowManualTransactions_Checkbox);
                        break;
                    case "Allow user to copy / duplicate transactions":
                       ClickOnWebElement(AllowUserToCopy_Checkbox);
                        break;
                    case "Copy Description to Merchant Field by Default":
                        ClickOnWebElement(CopyDescription_Checkbox);
                        break;
                    case "Merchant Copy Source Field Name":
                        EnterValueinWebElement(MerchantCopySource_Field, item[1]);
                        break;
                    case "Transaction Filter Condition":
                       EnterValueinWebElement(TransactionFilterCondition_Field, item[1]);
                        break;
                    case "Transaction Not Allowed Condition":
                       EnterValueinWebElement(TransactionNotAllowedCondition_Field, item[1]);
                        break;
                    case "Show Fraud / Non-Fraud Option":
                        ClickOnWebElement(ShowFraud_Checkbox);
                        break;
                    case "Disable Customer Edit":
                        FluentWaitForWebElement(DisableCustomerEdit_Checkbox);
                        break;
                    case "Verbiage for Fraud":
                        EnterValueinWebElement(Verbiage_Fraud, item[1]);
                        break;
                    case "Verbiage for Non-Fraud":
                        EnterValueinWebElement(Verbiage_Nonfraud, item[1]);
                        break;
                    case "Has Questionnaire":
                        ClickOnWebElement(Questionnaire_Checkbox);
                        value = IsChecked(Questionnaire_Checkbox);
                        break;
                    case "Has Provisional Credit Calculation":
                        ClickOnWebElement(ProvisionalCreditCalculation_Checkbox);
                        break;
                    case "Show Customer Type":
                        ClickOnWebElement(ShowCustomerType_Checkbox);
                        break;
                    case "Hide Comments And Resolution":
                        ClickOnWebElement(HideComments_Checkbox);
                        break;
                    case "Reimburse Fees":
                        ClickOnWebElement(ReimburseFees_Checkbox);
                        break;
                    case "Transaction Code Filter":
                        EnterValueinWebElement(TransactionCodeFilter_Field, item[1]);
                        break;
                    case "GL Reference":
                        ClickOnWebElement(GLReference_Dropdown);
                        ElementToBeSelectedFromDropdown(GLReference_Dropdown, item[1]);
                        ClickOnWebElement(TransactionType_Dropdown);
                        break;
                    case "Interest Posting GL Reference":
                        ClickOnWebElement(InterestPostingGLReference_Dropdown);
                        ElementToBeSelectedFromDropdown(InterestPostingGLReference_Dropdown, item[1]);
                        ClickOnWebElement(InterestPostingGLReference_Dropdown);
                        break;
                    case "Compliance Regulation Screen":
                        ClickOnWebElement(ComplianceRegulationScreen_Dropdown);
                        ElementToBeSelectedFromDropdown(ComplianceRegulationScreen_Dropdown, item[1]);
                        ClickOnWebElement(ComplianceRegulationScreen_Dropdown);
                        break;
                    case "PC Business Days ":
                        ClickOnWebElement(PCBusinessDays_Checkbox);
                        break;
                    case "Provisional Credit Days":
                        EnterValueinWebElement(ProvisionalCreditDays_Field, item[1]);
                        break;
                    case "Resolution Business Days":
                        ClickOnWebElement(ResolutionBusiness_Checkbox);
                        break;
                    case "Resolution Days":
                        EnterValueinWebElement(ResolutionDays_Field, item[1]);
                        break;
                    case "Dispute Screen Type":
                        ClickOnWebElement(DisputeScreenType_Dropdown);
                        ElementToBeSelectedFromDropdown(DisputeScreenType_Dropdown, item[1]);
                        ClickOnWebElement(DisputeScreenType_Dropdown);
                        break;
                    case "Email Template Reference":
                        ClickOnWebElement(EmailTemplateReference_Dropdown);
                        ElementToBeSelectedFromDropdown(EmailTemplateReference_Dropdown, item[1]);
                        ClickOnWebElement(EmailTemplateReference_Dropdown);
                        break;
                    case "Confirmation Email Template Reference":
                        ClickOnWebElement(ConfirmationEmailTemplate_Dropdown);
                        ElementToBeSelectedFromDropdown(ConfirmationEmailTemplate_Dropdown, item[1]);
                        ClickOnWebElement(ConfirmationEmailTemplate_Dropdown);
                        break;
                    case "Post Submission Automation Reference":
                        ClickOnWebElement(PostSubmissionAutomation_Dropdown);
                        ElementToBeSelectedFromDropdown(PostSubmissionAutomation_Dropdown, item[1]);
                        ClickOnWebElement(PostSubmissionAutomation_Dropdown);
                        break;
                    case "Automation Reference On Submission Complete":
                        ClickOnWebElement(AutomationReferenceOnSubmission_Dropdown);
                        ElementToBeSelectedFromDropdown(AutomationReferenceOnSubmission_Dropdown, item[1]);
                        ClickOnWebElement(AutomationReferenceOnSubmission_Dropdown);
                        break;
                    case "Submission Screen Template":
                        ClickOnWebElement(SubmissionScreenTemplate_Dropdown);
                        ElementToBeSelectedFromDropdown(SubmissionScreenTemplate_Dropdown, item[1]);
                        ClickOnWebElement(SubmissionScreenTemplate_Dropdown);
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

        public void AddDatatofieldsOnAddTriggersDialog(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Trigger Name":
                        EnterValueinWebElement(TriggerNameOnAdd_Field, item[1]);
                        break;
                    case "Trigger Event Type":
                        EnterValueinWebElement(TriggerEventTypeOnAdd_Field, item[1]);
                        break;
                    case "Additional Condition (search for below)":
                        ClickOnWebElement(AdditionalCondition_Checkbox);
                        break;
                    case "Account Type":
                        ClickOnWebElement(AccountType_Checkbox);
                        break;
                    case "Account Type Restriction":
                        ClickOnWebElement(AccountTypeTrigger_Dropdown);
                        ElementToBeSelectedFromDropdown(AccountTypeTrigger_Dropdown, item[1]);
                        ClickOnWebElement(AccountTypeTrigger_Dropdown);
                        break;
                    case "Automation Reference":
                        ClickOnWebElement(AutomationReference_Checkbox);
                        break;
                    case "Automation Reference Box":
                        ClickOnWebElement(AutomationReference_Dropdown);
                        ElementToBeSelectedFromDropdown(AutomationReference_Dropdown, item[1]);
                        ClickOnWebElement(AutomationReference_Dropdown);
                        break;
                    case "Letter Template Reference":
                        ClickOnWebElement(LetterTemplateReference_Checkbox);
                        break;
                    case "Template Reference":
                        ClickOnWebElement(LetterTemplateReference_Dropdown);
                        ElementToBeSelectedFromDropdown(LetterTemplateReference_Dropdown, item[1]);
                        ClickOnWebElement(LetterTemplateReference_Dropdown);
                        break;
                    case "GL Reference":
                        ClickOnWebElement(GLReferenceTrigger_Checkbox);
                        break;
                    case "GL Reference Box":
                        ClickOnWebElement(GLReferenceTrigger_Dropdown);
                        ElementToBeSelectedFromDropdown(GLReferenceTrigger_Dropdown, item[1]);
                        ClickOnWebElement(GLReferenceTrigger_Dropdown);
                        break;
                    case "Run Automation":
                        ClickOnWebElement(RunAutomation_Checkbox);
                        break;
                    case "AutomationReference":
                        ClickOnWebElement(AutomationReferenceAction_Dropdown);
                        ElementToBeSelectedFromDropdown(AutomationReferenceAction_Dropdown, item[1]);
                        ClickOnWebElement(AutomationReferenceAction_Dropdown);
                        break;
                    case "Send Email Notification":
                        ClickOnWebElement(SendEmailNotification_Checkbox);
                        break;
                    case "Email Letter Template Reference":
                        ClickOnWebElement(EmailLetterTemplateReference_Dropdown);
                        ElementToBeSelectedFromDropdown(EmailLetterTemplateReference_Dropdown, item[1]);
                        ClickOnWebElement(EmailLetterTemplateReference_Dropdown);
                        break;
                    case "Email Distribution List":
                        EnterValueinWebElement(EmailDistributionList_Dropdown, item[1]);
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

        public void AddvaluesonSelfServiceVerbiagePage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Self-Service Portal Submission Completion Title":
                        EnterValueinWebElement(CompletionTitle_Field, item[1]);
                        break;
                    case "Self-Service Portal Submission Completion Note":
                        EnterValueinWebElement(CompletionNote_Field,item[1]);
                        break;
                }
            }
        }

        public void validateActionfieldsonWorkflowSettingsPage()
        {
            Thread.Sleep(5000);
            int afteradd = GetElements(DeleteWorkflowSetting_Button).Count();
            for (int i = 1; i <= afteradd; i++)
            {
                if (i > count)
                {
                    Thread.Sleep(5000);
                    var value = driver.FindElement(By.XPath("(//button[@ng-click=\"deleteSetting($event, s)\"])[" + i + "]"));
                    value.Click();
                    Thread.Sleep(5000);
                    ClickOnWebElement(Yes_Button);
                }
            }

        }

        public void AssertFieldsOnQuestionaireDialog(Table table)
        {
            Thread.Sleep(5000);
            bool a = true;
            if(value == a) {
                ClickOnWebElement(Questionaire_Button);
                WaitForWebElementDisplayed(QuestionaireTemplate_Field);
            foreach (var item in table.Rows)
            {
                    switch (item[0].Trim())
                    {
                        case "Questionnaire Template":
                            FluentWaitForWebElement(QuestionaireTemplate_Field);
                            ClickOnWebElement(QuestionaireTemplate_Field);
                            ElementToBeSelectedFromDropdown(QuestionaireTemplate_Field, item[1]);
                            ClickOnWebElement(QuestionaireTemplate_Field);
                            break;
                        case "e-Consent Notice Template":
                            FluentWaitForWebElement(eConsentNoticeTemplate_Field);
                            ClickOnWebElement(eConsentNoticeTemplate_Field);
                            ElementToBeSelectedFromDropdown(eConsentNoticeTemplate_Field, item[1]);
                            ClickOnWebElement(eConsentNoticeTemplate_Field);
                            break;
                        case "Read Only Questionnaire":
                            FluentWaitForWebElement(Read_Checkbox);
                            ClickOnWebElement(Read_Checkbox);
                            break;
                        case "Hide Send To Customer":
                            FluentWaitForWebElement(HideSend_Checkbox);
                            ClickOnWebElement(HideSend_Checkbox);
                            break;
                        case "Hide Customer Acknowledgement Form":
                            FluentWaitForWebElement(HideCustomer_Checkbox);
                            ClickOnWebElement(HideCustomer_Checkbox);
                            break;
                        case "Close Screen Message":
                            FluentWaitForWebElement(CloseScreenMessage_Checkbox);
                            ClickOnWebElement(CloseScreenMessage_Checkbox);
                            break;
                    }
                }
            }
        }

    }
}
