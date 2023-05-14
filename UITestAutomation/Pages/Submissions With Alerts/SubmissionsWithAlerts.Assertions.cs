
namespace UITestAutomation
{
    internal partial class SubmissionsWithAlerts : Selenium_Methods
    {
        public void AssertUIControlsonSubmissionsWithAlertsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Settings":
                        WaitForWebElementDisplayed(EnterPage_TextField);
                        FluentWaitForWebElement(Settings_Button);
                        break;
                    case "Refresh Alerts":
                        FluentWaitForWebElement(RefreshAlerts_Button);
                        break;
                    case "Enter Page":
                        FluentWaitForWebElement(EnterPage_TextField);
                        break;
                    case "Go":
                        FluentWaitForWebElement(Go_Button);
                        break;
                    case "Edit Submission":
                        FluentWaitForWebElement(EditSubmission_Button);
                        break;
                }
            }
        }

        public void AssertFieldsonSubmissionsWithAlertsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Action":
                        WaitForWebElementDisplayed(Action_Field);
                        FluentWaitForWebElement(Action_Field);
                        break;
                    case "ID":
                        FluentWaitForWebElement(ID_Field);
                        FluentWaitForWebElement(ID_TextField);
                        break;
                    case "Customer":
                        FluentWaitForWebElement(Customer_Field);
                        FluentWaitForWebElement(Customer_TextField);
                        break;
                    case "Status":
                        FluentWaitForWebElement(Status_Field);
                        FluentWaitForWebElement(Status_TextField);
                        break;
                    case "Source":
                        FluentWaitForWebElement(Source_Field);
                        FluentWaitForWebElement(Source_TextField);
                        break;
                    case "Alert":
                        FluentWaitForWebElement(Alert_Field);
                        FluentWaitForWebElement(Alert_TextField);
                        break;
                    case "Alert Type":
                        FluentWaitForWebElement(AlertType_Field);
                        FluentWaitForWebElement(AlertType_TextField);
                        break;
                    case "Deadline":
                        FluentWaitForWebElement(Deadline_Field);
                        break;
                    case "Assigned To":
                        FluentWaitForWebElement(AssignedTo_Field);
                        break;
                }
            }
        }

        //public void AssertFieldsonSubmissionsInfoPage(Table table)
        //{
        //    foreach (var item in table.Rows)
        //    {
        //        switch (item[0].Trim())
        //        {
        //            case "Next":
        //                WaitForWebElementDisplayed(Next_Button);
        //                FluentWaitForWebElement(Next_Button);
        //                break;
        //            case "Print Letter":
        //                FluentWaitForWebElement(PrintLetter_Button);
        //                break;
        //            case "Run Automation":
        //                FluentWaitForWebElement(RunAutomation_Button);
        //                break;
        //            case "Edit Customer":
        //                FluentWaitForWebElement(EditCustomer_Button);
        //                break;
        //            case "All Submission":
        //                FluentWaitForWebElement(AllSubmission_Button);
        //                break;
        //            case "Activity History":
        //                FluentWaitForWebElement(ActivityHistory_Button);
        //                break;
        //            case "Refresh Submissions":
        //                FluentWaitForWebElement(RefreshSubmissions_Button);
        //                break;
        //            case "Transactions":
        //                FluentWaitForWebElement(Transactions_Button);
        //                break;
        //            case "Save Comments":
        //                FluentWaitForWebElement(SaveComments_Button);
        //                break;
        //            case "Add Note":
        //                FluentWaitForWebElement(AddNote_Button);
        //                break;
        //            case "View All":
        //                FluentWaitForWebElement(ViewAll_Button);
        //                break;
        //            case "Calculate Interest":
        //                FluentWaitForWebElement(CalculateInterest_Button);
        //                break;
        //            case "Alert":
        //                WaitForWebElementDisplayed(AlertSubmission_Field);
        //                FluentWaitForWebElement(AlertSubmission_Field);
        //                break;
        //            case "Type":
        //                FluentWaitForWebElement(Type_Field);
        //                break;
        //            case "Deadline":
        //                FluentWaitForWebElement(DeadlineSubmission_Field);
        //                break;
        //            case "Comments and Resolution":
        //                FluentWaitForWebElement(CommentsandResolution_Field);
        //                break;
        //            case "Public":
        //                FluentWaitForWebElement(Public_Field);
        //                break;
        //            case "Date":
        //                FluentWaitForWebElement(Date_Field);
        //                break;
        //            case "Created By":
        //                FluentWaitForWebElement(CreatedBy_Field);
        //                break;
        //            case "Notes":
        //                FluentWaitForWebElement(Notes_Field);
        //                break;
        //            case "Pre-Auth":
        //                FluentWaitForWebElement(PreAuth_Field);
        //                break;
        //            case "Date Transaction":
        //                FluentWaitForWebElement(DateTransactions_Field);
        //                break;
        //            case "DeadlineTransaction":
        //                FluentWaitForWebElement(DeadlineTransaction_Field);
        //                break;
        //            case "POS":
        //                FluentWaitForWebElement(POS_Field);
        //                break;
        //            case "FT":
        //                FluentWaitForWebElement(FT_Field);
        //                break;
        //            case "Amount":
        //                FluentWaitForWebElement(Amount_Field);
        //                break;
        //            case "Disputed Amount":
        //                FluentWaitForWebElement(DisputedAmount_Field);
        //                break;
        //            case "Merchant":
        //                FluentWaitForWebElement(Merchant_Field);
        //                break;
        //            case "Do Not Send":
        //                FluentWaitForWebElement(DoNotSend_Field);
        //                break;
        //            case "Consumer Liability":
        //                FluentWaitForWebElement(ConsumerLiability_Field);
        //                break;
        //            case "Provisional Credit":
        //                FluentWaitForWebElement(ProvisionalCredit_Field);
        //                break;
        //            case "Reason":
        //                FluentWaitForWebElement(Reason_Field);
        //                break;
        //        }
        //    }
        //}

        //public void AssertFieldsonQuestionairePage(Table table)
        //{
        //    foreach (var item in table.Rows)
        //    {
        //        switch (item[0].Trim())
        //        {
        //            case "Signature":
        //                WaitForWebElementDisplayed(Signature_Field);
        //                FluentWaitForWebElement(Signature_Field);
        //                break;
        //            case "Acknowledged":
        //                FluentWaitForWebElement(Acknowledged_Checkbox);
        //                break;
        //        }
        //    }
        //}

        //public void AssertFieldsonFormsPage(Table table)
        //{
        //    foreach (var item in table.Rows)
        //    {
        //        switch (item[0].Trim())
        //        {
        //            case "Select Form to View":
        //                WaitForWebElementDisplayed(SelectFormtoView_Button);
        //                FluentWaitForWebElement(SelectFormtoView_Button);
        //                break;
        //            case "Save Form Data":
        //                FluentWaitForWebElement(SaveFormData_Button);
        //                break;
        //            case "Save PDF":
        //                FluentWaitForWebElement(SavePDF_Button);
        //                break;
        //            case "Send to Customer for E-Signature":
        //                FluentWaitForWebElement(ESignature_Button);
        //                break;
        //        }
        //    }
        //}

        //public void AssertFieldsonDisputesPage(Table table)
        //{
        //    foreach (var item in table.Rows)
        //    {
        //        switch (item[0].Trim())
        //        {
        //            case "Select Automation":
        //                WaitForWebElementDisplayed(ResearchDetail_Textbox);
        //                FluentWaitForWebElement(SelectAutomation_Button);
        //                break;
        //            case "Run Selected Workflow Automation":
        //                FluentWaitForWebElement(RunSelectedWorkflowAutomation_Button);
        //                break;
        //            case "Settings":
        //                FluentWaitForWebElement(Settings_Button);
        //                break;
        //            case "Hide Closed Disputes":
        //                FluentWaitForWebElement(HideClosedDisputes_Button);
        //                break;
        //            case "Settings Dispute":
        //                FluentWaitForWebElement(Settingsdisputes_Button);
        //                break;
        //            case "Submission Info":
        //                FluentWaitForWebElement(SubmissionInfo_Button);
        //                break;
        //            case "Action":
        //                FluentWaitForWebElement(Actiondisputes_Field);
        //                break;
        //            case "ID":
        //                FluentWaitForWebElement(IDdisputes_Field);
        //                break;
        //            case "Transaction Date":
        //                FluentWaitForWebElement(TransactionDate_Field);
        //                break;
        //            case "Amount":
        //                FluentWaitForWebElement(Amountdisputes_Field);
        //                break;
        //            case "Merchant":
        //                FluentWaitForWebElement(Merchantdisputes_Field);
        //                break;
        //            case "PC":
        //                FluentWaitForWebElement(PC_Field);
        //                break;
        //            case "Status":
        //                FluentWaitForWebElement(Statusdisputes_Field);
        //                break;
        //            case "Research Detail":
        //                FluentWaitForWebElement(ResearchDetail_Field);
        //                FluentWaitForWebElement(ResearchDetail_Textbox);
        //                break;
        //            case "Notes":
        //                FluentWaitForWebElement(Notesdisputes_Field);
        //                FluentWaitForWebElement(Notes_Textbox);
        //                break;
        //        }
        //    }
        //}

        //public void AssertFieldsonResearchPage(Table table)
        //{
        //    foreach (var item in table.Rows)
        //    {
        //        switch (item[0].Trim())
        //        {
        //            case "Submit Cases":
        //                WaitForWebElementDisplayed(SubmitCases_Button);
        //                FluentWaitForWebElement(SubmitCases_Button);
        //                break;
        //            case "Link Multiple":
        //                FluentWaitForWebElement(LinkMultiple_Button);
        //                break;
        //            case "Activity History":
        //                FluentWaitForWebElement(ActivityHistoryResearch_Button);
        //                break;
        //            case "Refresh":
        //                FluentWaitForWebElement(Refresh_Button);
        //                break;
        //            case "Actions":
        //                FluentWaitForWebElement(Actions_Field);
        //                break;
        //            case "Id":
        //                FluentWaitForWebElement(Id_Field);
        //                break;
        //            case "Master Case":
        //                FluentWaitForWebElement(MasterCase_Field);
        //                break;
        //            case "Fraud Report":
        //                FluentWaitForWebElement(FraudReport_Field);
        //                break;
        //            case "Visa Case Number":
        //                FluentWaitForWebElement(VisaCaseNumber_Field);
        //                break;
        //            case "POS":
        //                FluentWaitForWebElement(POSResearch_Field);
        //                break;
        //            case "PIN":
        //                FluentWaitForWebElement(PIN_Field);
        //                break;
        //            case "3DS":
        //                FluentWaitForWebElement(ThreeDS_Field);
        //                break;
        //            case "Fallback":
        //                FluentWaitForWebElement(Fallback_Field);
        //                break;
        //            case "MCC":
        //                FluentWaitForWebElement(MCC_Field);
        //                break;
        //            case "Country":
        //                FluentWaitForWebElement(Country_Field);
        //                break;
        //            case "Nwk":
        //                FluentWaitForWebElement(Nwk_Field);
        //                break;
        //            case "PI":
        //                FluentWaitForWebElement(PI_Field);
        //                break;
        //            case "RDR":
        //                FluentWaitForWebElement(RDR_Field);
        //                break;
        //            case "Transaction Date":
        //                FluentWaitForWebElement(TransactionDateResearch_Field);
        //                break;
        //            case "Amount":
        //                FluentWaitForWebElement(AmountResearch_Field);
        //                break;
        //            case "Merchant":
        //                FluentWaitForWebElement(MerchantResearch_Field);
        //                break;
        //            case "Visa Status":
        //                FluentWaitForWebElement(VisaStatus_Field);
        //                break;
        //            case "Link":
        //                FluentWaitForWebElement(Link_Button);
        //                break;
        //        }
        //    }
        //}


        //public void AssertFieldsonCustomerStatusPage(Table table)
        //{
        //    foreach (var item in table.Rows)
        //    {
        //        switch (item[0].Trim())
        //        {
        //            case "Case Number":
        //                WaitForWebElementDisplayed(CaseNumber_Field);
        //                FluentWaitForWebElement(CaseNumber_Field);
        //                break;
        //            case "Third Party Breach Source":
        //                FluentWaitForWebElement(ThirdPartyBreachSource_Dropdown);
        //                break;
        //            case "CAMS Case Number":
        //                FluentWaitForWebElement(CAMSCaseNumber_Field);
        //                break;
        //            case "Amount Prevented by Fraud Detection System":
        //                FluentWaitForWebElement(AmountPrevented_Field);
        //                break;
        //            case "Submission Status":
        //                FluentWaitForWebElement(SubmissionStatus_Dropdown);
        //                break;
        //            case "Provisional Credit Reversed":
        //                FluentWaitForWebElement(ProvisionalCreditReversed_Field);
        //                break;
        //            case "Resolution Notice Sent":
        //                FluentWaitForWebElement(ResolutionNoticeSent_Dropdown);
        //                break;
        //            case "Merchant Credit":
        //                FluentWaitForWebElement(MerchantCredit_Field);
        //                break;
        //            case "Merchant Credit Date":
        //                FluentWaitForWebElement(MerchantCreditDate_Dropdown);
        //                break;
        //            case "Final Credit":
        //                FluentWaitForWebElement(FinalCredit_Field);
        //                break;
        //            case "Final Credit Date":
        //                FluentWaitForWebElement(FinalCreditDate_Dropdown);
        //                break;
        //            case "Insurance Amount":
        //                FluentWaitForWebElement(InsuranceAmount_Field);
        //                break;
        //            case "Chargeback Amount":
        //                FluentWaitForWebElement(ChargebackAmount_Field);
        //                break;
        //            case "Other Fees":
        //                FluentWaitForWebElement(OtherFees_Field);
        //                break;
        //            case "Fee Reversal Amount":
        //                FluentWaitForWebElement(FeeReversalAmount_Field);
        //                break;
        //            case "Interest Credit Amount":
        //                FluentWaitForWebElement(InterestCreditAmount_Field);
        //                break;
        //            case "Processor Resolution Date":
        //                FluentWaitForWebElement(ProcessorResolutionDate_Dropdown);
        //                break;
        //            case "Processor Case Date":
        //                FluentWaitForWebElement(ProcessorCaseDate_Dropdown);
        //                break;
        //            case "Save":
        //                FluentWaitForWebElement(Save_Button);
        //                break;
        //        }
        //    }
        //}

        //public void AssertFieldsonContactsPage(Table table)
        //{
        //    foreach (var item in table.Rows)
        //    {
        //        switch (item[0].Trim())
        //        {
        //            case "Contact Name":
        //                WaitForWebElementDisplayed(ContactName_Field);
        //                FluentWaitForWebElement(ContactName_Field);
        //                FluentWaitForWebElement(ContactName_TextField);
        //                break;
        //            case "Reference":
        //                FluentWaitForWebElement(Reference_Field);
        //                FluentWaitForWebElement(Reference_TextField);
        //                break;
        //            case "Phone Contact":
        //                FluentWaitForWebElement(Phone_Field);
        //                FluentWaitForWebElement(Phone_TextField);
        //                break;
        //            case "Email":
        //                FluentWaitForWebElement(Email_Field);
        //                FluentWaitForWebElement(Email_TextField);
        //                break;
        //            case "Action":
        //                FluentWaitForWebElement(ActionContact_Field);
        //                break;
        //            case "Download":
        //                FluentWaitForWebElement(Download_Button);
        //                break;
        //        }


        //    }
        //}

        //public void AssertFieldsonGLLedgerPage(Table table)
        //{
        //    foreach (var item in table.Rows)
        //    {
        //        switch (item[0].Trim())
        //        {
        //            case "Date":
        //                WaitForWebElementDisplayed(DeleteLedgerEntry_Button);
        //                FluentWaitForWebElement(DateLedger_Field);
        //                break;
        //            case "Description":
        //                FluentWaitForWebElement(Description_Field);
        //                break;
        //            case "GL Account":
        //                FluentWaitForWebElement(GLAccount_Field);
        //                break;
        //            case "Account":
        //                FluentWaitForWebElement(Account_Field);
        //                break;
        //            case "Transaction Code":
        //                FluentWaitForWebElement(TransactionCode_Field);
        //                break;
        //            case "Amount":
        //                FluentWaitForWebElement(AmountLedger_Field);
        //                break;
        //            case "Delete Ledger Entry":
        //                FluentWaitForWebElement(DeleteLedgerEntry_Button);
        //                break;
        //            case "Add GL Transaction":
        //                FluentWaitForWebElement(AddGLTransaction_Button);
        //                break;
        //        }
        //    }
        //}

        //public void AssertFieldsonDocumentsPage(Table table)
        //{
        //    foreach (var item in table.Rows)
        //    {
        //        switch (item[0].Trim())
        //        {
        //            case "Delete Document":
        //                WaitForWebElementDisplayed(DeleteDocument_Button);
        //                FluentWaitForWebElement(DeleteDocument_Button);
        //                break;
        //            case "Download Document":
        //                FluentWaitForWebElement(DownloadDocument_Button);
        //                break;
        //            case "Edit Document Description":
        //                FluentWaitForWebElement(EditDocumentDescription_Button);
        //                break;
        //        }
        //    }
        //}
    }
}
