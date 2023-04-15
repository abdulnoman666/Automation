namespace UITestAutomation.Pages.GLDefinitions
{
    internal partial class GLDefinitions
    {
        public void AssertUIControlsonGLDefinitionsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Add GL Definition":
                        FluentWaitForWebElement(AddGLDefinition);
                        break;
                    case " Delete GL Definition":
                        FluentWaitForWebElement(DeleteGLDefinition);
                        break;
                    case " Edit GL Definition":
                        FluentWaitForWebElement(EditGLDefinition);
                        break;
                    case " Copy GL Definition":
                        FluentWaitForWebElement(CopyGLDefinition);
                        break;
                    case " Refresh":
                        FluentWaitForWebElement(RefreshIcon);
                        break;
                    case " Download Letter":
                        FluentWaitForWebElement(DownloadLetter);
                        break;
                    case " Show Deleted GL Definition":
                        FluentWaitForWebElement(ShowDeletedGLDefinition);
                        break;
                    case " Action":
                        FluentWaitForWebElement(ActionField);
                        break;
                    case " Transfer Type":
                        FluentWaitForWebElement(TransferTypeField);
                        break;
                    case " GL Account":
                        FluentWaitForWebElement(GLAccountField);
                        break;
                    case " Description":
                        FluentWaitForWebElement(DescriptionField);
                        break;
                    case " Reference":
                        FluentWaitForWebElement(ReferenceField);
                        break;
                    case " Source":
                        FluentWaitForWebElement(SourceField);
                        break;
                    case " Branch":
                        FluentWaitForWebElement(BranchField);
                        break;
                    case " Customer Type":
                        FluentWaitForWebElement(CustomerTypeField);
                        break;
                }
            }
        }

        public void AssertFieldsonAddGLDefinitionPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Transfer Type":
                        FluentWaitForWebElement(TransferType);
                        break;
                    case " Transaction Type":
                        FluentWaitForWebElement(TransactionType);
                        break;
                    case " Transfer Account":
                        FluentWaitForWebElement(TransferAccount);
                        break;
                    case " Transfer GL Code":
                        FluentWaitForWebElement(TransferGLCode);
                        break;
                    case " Transfer Account Type":
                        FluentWaitForWebElement(TransferAccountType);
                        break;
                    case " Transfer Description":
                        FluentWaitForWebElement(TransferDescription);
                        break;
                    case " Transfer Transaction Code":
                        FluentWaitForWebElement(TransferTransactionCode);
                        break;
                    case " Transfer GL Branch Code":
                        FluentWaitForWebElement(TransferGLBranchCode);
                        break;
                    case " Transfer GL Cost Center":
                        FluentWaitForWebElement(TransferGLCostCenter);
                        break;
                    case " GL Account":
                        FluentWaitForWebElement(GLAccount);
                        break;
                    case " GL Code":
                        FluentWaitForWebElement(GLCode);
                        break;
                    case " GL Transaction Code":
                        FluentWaitForWebElement(GLTransactionCode);
                        break;
                    case " GL Branch Code":
                        FluentWaitForWebElement(GLBranchCode);
                        break;
                    case " GL Cost Center":
                        FluentWaitForWebElement(GLCostCenter);
                        break;
                    case " GL Transaction Description":
                        FluentWaitForWebElement(GLDescription);
                        break;
                    case " Reference":
                        FluentWaitForWebElement(Reference);
                        break;
                    case " Workflow":
                        FluentWaitForWebElement(Workflow);
                        break;
                    case " Branch":
                        FluentWaitForWebElement(Branch);
                        break;
                    case " Customer Type":
                        FluentWaitForWebElement(CustomerType);
                        break;
                    case " Cross Button":
                        FluentWaitForWebElement(CrossButton);
                        break;
                    case " Save":
                        FluentWaitForWebElement(SaveButton);
                        break;
                    case " Close":
                        FluentWaitForWebElement(CloseButton);
                        break;
                    case " Delete Definition":
                        FluentWaitForWebElement(DeleteDefinition);
                        break;
                }
            }
        }


        public void AssertFieldsonDownloadfromLibraryPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Cross Button 2":
                        FluentWaitForWebElement(CrossButton2);
                        break;
                    case " Search Bar":
                        FluentWaitForWebElement(SearchBar);
                        break;
                    case " Search Button":
                        FluentWaitForWebElement(SearchButton);
                        break;
                    case " Action":
                        FluentWaitForWebElement(ActionField2);
                        break;
                    case " ID":
                        FluentWaitForWebElement(IDField);
                        break;
                    case " Description":
                        FluentWaitForWebElement(DescriptionField2);
                        break;
                    case " Download GL Definition":
                        FluentWaitForWebElement(DownloadGLDefinitionField);
                        break;
                    case " Close":
                        FluentWaitForWebElement(CloseButton2);
                        break;
                }
            }
        }
    }
}
