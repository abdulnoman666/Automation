namespace UITestAutomation.Pages.CompanyDetails
{
    internal partial class CompanyDetails : Selenium_Methods
    {
        public void AssertUIControlsonCompanyDetailsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Basic Info":
                        FluentWaitForWebElement(BasicInfo);
                        break;
                    case " General Settings":
                        FluentWaitForWebElement(GeneralSettings);
                        break;
                    case " Lookup Value":
                        FluentWaitForWebElement(LookupValues);
                        break;
                    case " Style":
                        FluentWaitForWebElement(Style);
                        break;
                    case " Save":
                        FluentWaitForWebElement(Save);
                        break;
                }
            }
        }
        public void AssertFieldsonBasicInfoPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Company Name ":
                        FluentWaitForWebElement(CompanyName);
                        break;
                    case "Address":
                        FluentWaitForWebElement(Address);
                        break;
                    case "City":
                        FluentWaitForWebElement(City);
                        break;
                    case "State":
                        FluentWaitForWebElement(State);
                        break;
                    case "Zip":
                        FluentWaitForWebElement(Zip);
                        break;
                    case "Phone":
                        FluentWaitForWebElement(Phone);
                        break;
                    case "E Mail":
                        FluentWaitForWebElement(Email);
                        break;
                    case "Response Email":
                        FluentWaitForWebElement(ResponseEmail);
                        break;
                    case "Email Distribution List":
                        FluentWaitForWebElement(EmailList);
                        break;
                    case "Time Zone":
                        FluentWaitForWebElement(Time);
                        break;
                    case "Read only Questionnaires":
                        FluentWaitForWebElement(Questionnaires);
                        break;
                }
            }
        }

        public void AssertFieldsonGeneralSettingsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Signature Pad":
                        FluentWaitForWebElement(SignaturePad);
                        break;
                    case "Enter max idle time in minutes":
                        FluentWaitForWebElement(Timeout);
                        break;
                    case "Statement Cycle":
                        FluentWaitForWebElement(StatementCycle);
                        break;
                    case "Select Logo File":
                        FluentWaitForWebElement(SelectFileOption);
                        break;
                }
            }
        }

        public void AssertUIControlsOnLookupValuesPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Cross Button":
                        FluentWaitForWebElement(CrossButton);
                        break;
                    case " Add Submission Status":
                        FluentWaitForWebElement(AddSubmissionStatus);
                        break;
                    case " Edit Submission Status":
                        FluentWaitForWebElement(EditSubmissionStatus);
                        break;
                    case " Delete Submission Status":
                        FluentWaitForWebElement(DeleteSubmissionStatus);
                        break;
                    case " Add Source":
                        FluentWaitForWebElement(AddSource);
                        break;
                    case " Edit Source":
                        FluentWaitForWebElement(EditSource);
                        break;
                    case " Delete Source":
                        FluentWaitForWebElement(DeleteSource);
                        break;
                    case " Add Account Type":
                        FluentWaitForWebElement(AddAccountType);
                        break;
                    case " Edit Account Type":
                        FluentWaitForWebElement(EditAccountType);
                        break;
                    case " Delete Account Type":
                        FluentWaitForWebElement(DeleteAccountType);
                        break;
                    case " Add Dispute Research Detail":
                        FluentWaitForWebElement(AddDisputeDetail);
                        break;
                    case " Edit Dispute Research Detail":
                        FluentWaitForWebElement(EditDisputeDetail);
                        break;
                    case " Delete Dispute Research Detail":
                        FluentWaitForWebElement(DeleteDisputeDetail);
                        break;
                    case " Add Branch":
                        FluentWaitForWebElement(AddBranch);
                        break;
                    case " Edit Branch":
                        FluentWaitForWebElement(EditBranch);
                        break;
                    case " Delete Branch":
                        FluentWaitForWebElement(DeleteBranch);
                        break;
                    case " Add Charter/Branding":
                        FluentWaitForWebElement(AddCharter);
                        break;
                    case " Edit Charter/Branding":
                        FluentWaitForWebElement(EditCharter);
                        break;
                    case " Delete Charter/Branding":
                        FluentWaitForWebElement(DeleteCharter);
                        break;
                    case " Transaction Decline Reason":
                        FluentWaitForWebElement(AddTransactionDeclineReason);
                        break;
                    case " Edit Transaction Decline Reason":
                        FluentWaitForWebElement(EditTransactionDeclineReason);
                        break;
                    case " Delete Transaction Decline Reason":
                        FluentWaitForWebElement(DeleteTransactionDeclineReason);
                        break;
                    case " Batch Reporting Reference":
                        FluentWaitForWebElement(AddBatchReportingReference);
                        break;
                    case " Edit Batch Reporting Reference":
                        FluentWaitForWebElement(EditBatchReportingReference);
                        break;
                    case " Delete Batch Reporting Reference":
                        FluentWaitForWebElement(DeleteBatchReportingReference);
                        break;
                }
            }
        }

        public void AssertFieldsonAddPagesofLookupValuesPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Text Area":
                        FluentWaitForWebElement(TextArea);
                        break;
                    case "Save":
                        FluentWaitForWebElement(SaveButton);
                        break;
                    case "Close":
                        FluentWaitForWebElement(CloseButton);
                        break;
                }
            }
        }

        public void AssertUIControlsonStylePage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Primary Buttons Color":
                        FluentWaitForWebElement(Primary);
                        break;
                    case "Secondary Buttons Color":
                        FluentWaitForWebElement(Secondary);
                        break;
                    case "Primary Buttons Font Color":
                        FluentWaitForWebElement(PrimaryFont);
                        break;
                    case "Secondary Buttons Font Color":
                        FluentWaitForWebElement(SecondaryFont);
                        break;
                }
            }
        }
    }
}
