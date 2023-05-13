

namespace UITestAutomation
{
    internal partial class Customer :Selenium_Methods
    {
        public void ClickAddCustomerButton()
        {
            ClickOnWebElement(AddCustomer_Button);
            WaitForWebElementDisplayed(CoreCustomerKey_Textbox);
        }

        public void ClickCloseAddButton()
        {
            ClickOnWebElement(CloseAddCustomer_Button);
            WaitForWebElementDisplayed(Search_Button);
        }
        public void ClickSearchButton()
        {
            ClickOnWebElement(Search_Button);
            WaitForWebElementDisplayed(CustomerName_Textbox);
        }

        public void EnterCustomerNameinSearchButtonPage(string name)
        {
            EnterValueinWebElement(CustomerName_Textbox, name);
        }

        public void ClickSearchButtonAfterEnteringValue()
        {
            ClickOnWebElement(search_Button);
            WaitForWebElementDisplayed(EditCustomerDetails_Button);
        }

        public void ClickViewTransactionButton()
        {
            ClickOnWebElement(ViewTransactions_Button);
            WaitForWebElementDisplayed(From_Field);
        }

        public void ClickCloseButtononTransactionPage()
        {
            ClickOnWebElement(CloseTransaction_Button);
        }
        public void ClickEditCustomerDocumentButton()
        {
            ClickOnWebElement(EditCustomerDetails_Button);
            WaitForWebElementDisplayed(IDEdit_Label);
        }

        public void ClickCloseButtononEditCustomerDocumentDialog()
        {
            ClickOnWebElement(EditClose_Button);
        }
        public void ClickCustomerDocumentButton()
        {
            ClickOnWebElement(CustomerDocuments_Button);
            WaitForWebElementDisplayed(DownloadDocument_Button);
        }
    }
}
