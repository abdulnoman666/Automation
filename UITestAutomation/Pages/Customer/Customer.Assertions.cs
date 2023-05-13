

namespace UITestAutomation
{
    internal partial class Customer
    {
        public void AssertUIControlsonCustomerPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Search and set date range":
                        WaitForWebElementDisplayed(Search_Button);
                        FluentWaitForWebElement(Search_Button);
                        break;
                    case "Add Customer":
                        FluentWaitForWebElement(AddCustomer_Button);
                        break;
                    case "Links":
                        FluentWaitForWebElement(Links_Field);
                        break;
                    case "Id":
                        FluentWaitForWebElement(Id_Field);
                        break;
                    case "Customer Name":
                        FluentWaitForWebElement(CustomerName_Field);
                        break;
                    case "Card Number":
                        FluentWaitForWebElement(CardNumber_Field);
                        break;
                    case "Account Type":
                        FluentWaitForWebElement(AccountType_Field);
                        break;
                    case "Account":
                        FluentWaitForWebElement(Account_Field);
                        break;
                    case "Main Phone":
                        FluentWaitForWebElement(MainPhone_Field);
                        break;
                    case "Email":
                        FluentWaitForWebElement(Email_Field);
                        break;
                }
            }
        }

        public void AssertFieldssonAddCustomerDialog(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "ID":
                        FluentWaitForWebElement(ID_Label);
                        break;
                    case "Cardholder Name":
                        FluentWaitForWebElement(CardholderName_Textbox);
                        break;
                    case "Core Customer Key":
                        FluentWaitForWebElement(CoreCustomerKey_Textbox);
                        break;
                    case "Card Number":
                        FluentWaitForWebElement(CardNumber_Textbox);
                        break;
                    case "Account":
                        FluentWaitForWebElement(Account_Textbox);
                        break;
                    case "Account Status":
                        FluentWaitForWebElement(AccountStatus_Textbox);
                        break;
                    case "Account Type":
                        FluentWaitForWebElement(AccountType_Dropdown);
                        break;
                    case "Customer Type":
                        FluentWaitForWebElement(CustomerType_Dropdown);
                        break;
                    case "Branch":
                        FluentWaitForWebElement(Branch_Dropdown);
                        break;
                    case "Charter / Branding":
                        FluentWaitForWebElement(CharterBranding_Dropdown);
                        break;
                    case "Mobile Phone":
                        FluentWaitForWebElement(MobilePhone_Textbox);
                        break;
                    case "Home Phone":
                        FluentWaitForWebElement(HomePhone_Textbox);
                        break;
                    case "Office Phone":
                        FluentWaitForWebElement(OfficePhone_Textbox);
                        break;
                    case "Email":
                        FluentWaitForWebElement(Email_Textbox);
                        break;
                    case "Statement Cycle Day (enter 0 for month end)":
                        FluentWaitForWebElement(StatementCycleDay_Count);
                        break;
                    case "Statement Cycle Code":
                        FluentWaitForWebElement(StatementCycleCode_Textbox);
                        break;
                    case "Statement Date - Next Business Day":
                        FluentWaitForWebElement(StatementDate_Checkbox);
                        break;
                    case "Address":
                        FluentWaitForWebElement(Address_Textbox);
                        break;
                    case "Close":
                        FluentWaitForWebElement(CloseAddCustomer_Button);
                        break;
                    case "Save":
                        FluentWaitForWebElement(SaveAddCustomer_Button);
                        break;
                }
            }
        }

        public void AssertFieldssonSearchButtonPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Customer Name":
                        FluentWaitForWebElement(CustomerName_Textbox);
                        break;
                    case "Full Card Number":
                        FluentWaitForWebElement(FullCardNumber_Textbox);
                        break;
                    case "Full Account Number":
                        FluentWaitForWebElement(FullAccountNumber_Textbox);
                        break;
                    case "Reset":
                        FluentWaitForWebElement(Reset_Button);
                        break;
                    case "Search":
                        FluentWaitForWebElement(search_Button);
                        break;
                    case "Close":
                        FluentWaitForWebElement(Close_Button);
                        break;
                }
            }
        }

        public void AssertUIControlsonCustomerPageAfterSearch(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Search and set date range":
                        FluentWaitForWebElement(Search_Button);
                        break;
                    case "Add Customer":
                        FluentWaitForWebElement(AddCustomer_Button);
                        break;
                    case "Links":
                        FluentWaitForWebElement(Links_Field);
                        break;
                    case "Id":
                        FluentWaitForWebElement(Id_Field);
                        break;
                    case "Customer Name":
                        FluentWaitForWebElement(CustomerName_Field);
                        break;
                    case "Card Number":
                        FluentWaitForWebElement(CardNumber_Field);
                        break;
                    case "Account Type":
                        FluentWaitForWebElement(AccountType_Field);
                        break;
                    case "Account":
                        FluentWaitForWebElement(Account_Field);
                        break;
                    case "Main Phone":
                        FluentWaitForWebElement(MainPhone_Field);
                        break;
                    case "Email":
                        FluentWaitForWebElement(Email_Field);
                        break;
                    case "Edit Customer Details":
                        FluentWaitForWebElement(EditCustomerDetails_Button);
                        break;
                    case "Customer Documents":
                        FluentWaitForWebElement(CustomerDocuments_Button);
                        break;
                    case "Copy Customer Record":
                        FluentWaitForWebElement(CopyCustomerRecord_Button);
                        break;
                    case "View Transactions":
                        FluentWaitForWebElement(ViewTransactions_Button);
                        break;
                    case "Print Letter":
                        FluentWaitForWebElement(PrintLetter_Button);
                        break;
                }
            }
        }

        public void AssertFieldssonTransactionButtonPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "From":
                        FluentWaitForWebElement(From_Field);
                        break;
                    case "To":
                        FluentWaitForWebElement(To_Field);
                        break;
                    case "Load Transactions":
                        FluentWaitForWebElement(LoadTransactions_Button);
                        break;
                    case "Search for (enter description, merchant, amount)":
                        FluentWaitForWebElement(Search_Textbox);
                        break;
                    case "Id":
                        FluentWaitForWebElement(IdTransaction_Field);
                        break;
                    case "Date":
                        FluentWaitForWebElement(Date_Field);
                        break;
                    case "Description":
                        FluentWaitForWebElement(Description_Field);
                        break;
                    case "Amount":
                        FluentWaitForWebElement(Amount_Field);
                        break;
                    case "Transaction Code":
                        FluentWaitForWebElement(TransactionCode_Field);
                        break;
                    case "Pos":
                        FluentWaitForWebElement(Pos_Field);
                        break;
                    case "Close":
                        FluentWaitForWebElement(CloseTransaction_Button);
                        break;
                }
            }
        }

        public void AssertFieldssonEditCustomerDocumentDialog(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "ID":
                        FluentWaitForWebElement(IDEdit_Label);
                        break;
                    case "Cardholder Name":
                        FluentWaitForWebElement(EditCardholderName_Textbox);
                        break;
                    case "Core Customer Key":
                        FluentWaitForWebElement(EditCoreCustomerKey_Textbox);
                        break;
                    case "Card Number":
                        FluentWaitForWebElement(EditCardNumber_Textbox);
                        break;
                    case "Account":
                        FluentWaitForWebElement(EditAccount_Textbox);
                        break;
                    case "Account Status":
                        FluentWaitForWebElement(EditAccountStatus_Textbox);
                        break;
                    case "Account Type":
                        FluentWaitForWebElement(EditAccountType_Dropdown);
                        break;
                    case "Customer Type":
                        FluentWaitForWebElement(EditCustomerType_Dropdown);
                        break;
                    case "Branch":
                        FluentWaitForWebElement(EditBranch_Dropdown);
                        break;
                    case "Charter / Branding":
                        FluentWaitForWebElement(EditCharterBranding_Dropdown);
                        break;
                    case "Mobile Phone":
                        FluentWaitForWebElement(EditMobilePhone_Textbox);
                        break;
                    case "Home Phone":
                        FluentWaitForWebElement(EditHomePhone_Textbox);
                        break;
                    case "Office Phone":
                        FluentWaitForWebElement(EditOfficePhone_Textbox);
                        break;
                    case "Email":
                        FluentWaitForWebElement(EditEmail_Textbox);
                        break;
                    case "Statement Cycle Day (enter 0 for month end)":
                        FluentWaitForWebElement(EditStatementCycleDay_Count);
                        break;
                    case "Statement Cycle Code":
                        FluentWaitForWebElement(EditStatementCycleCode_Textbox);
                        break;
                    case "Statement Date - Next Business Day":
                        FluentWaitForWebElement(EditStatementDate_Checkbox);
                        break;
                    case "Address":
                        FluentWaitForWebElement(EditAddress_Textbox);
                        break;
                    case "Close":
                        FluentWaitForWebElement(EditClose_Button);
                        break;
                    case "Update":
                        FluentWaitForWebElement(EditUpdate_Button);
                        break;
                }
            }
        }


        public void AssertUIControlsonDocumentManaagerPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Download Document":
                        FluentWaitForWebElement(DownloadDocument_Button);
                        break;
                    case "gotoPage":
                        WaitForWebElementDisplayed(gotoPage_Button);
                        FluentWaitForWebElement(gotoPage_Button);
                        break;
                    case "prevPage":
                        FluentWaitForWebElement(prevPage_Button);
                        break;
                    case "nextPages":
                        FluentWaitForWebElement(nextPages_Button);
                        break;
                    case "gotoPage(totalPages)":
                        FluentWaitForWebElement(total_Pages);
                        break;
                    case "Rotate":
                        FluentWaitForWebElement(Rotate_Button);
                        break;
                    case "Print/Download":
                        FluentWaitForWebElement(Print_Button);
                        break;
                }
            }
        }






    }
}
