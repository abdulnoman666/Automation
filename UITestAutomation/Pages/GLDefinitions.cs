using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestAutomation.Pages
{
    public class GLDefinitions : Selenium_Methods
    {
        //UI Controls on GL Definitions Page
        By GLDefinitionsOption = By.LinkText("GL Definitions");
        By AddGLDefinition = By.CssSelector("button[title='Add GL Definition']");
        By DeleteGLDefinition = By.CssSelector("button[title='Delete GL Definition']");
        By EditGLDefinition = By.CssSelector("button[title='Edit GL Definition']");
        By CopyGLDefinition = By.CssSelector("button[title='Copy GL Definition']");
        By RefreshIcon = By.CssSelector("button[title='Refresh']");
        By DownloadLetter = By.CssSelector("button[title='Download Letter']");
        By ShowDeletedGLDefinition = By.CssSelector(".page-link");
        By ActionField = By.CssSelector(".table.table-bordered.table-striped > thead > tr > th:nth-of-type(1)");
        By TransferTypeField = By.XPath("//input[@ng-model='$.accountType']");
        By GLAccountField = By.XPath("//input[@ng-model='$.account']");
        By DescriptionField = By.CssSelector("tr:nth-of-type(1) > td:nth-of-type(4)");
        By ReferenceField = By.XPath("//input[@ng-model='$.reference']");
        By SourceField = By.XPath("//input[@ng-model='$.source']");
        By BranchField = By.XPath("//input[@ng-model='$.branchCode']");
        By CustomerTypeField = By.XPath("//input[@ng-model='$.accountOwnershipType']");

        // Fields on Add GL Definitions Page
        By TransferType = By.XPath("(//select[@ng-model='newType.accountType'])[1]");
        By TransactionType = By.XPath("(//select[@ng-model='newType.transactionType'])[1]");
        By TransferAccount = By.XPath("(//input[@ng-model='newType.transferAccount'])[1]");
        By TransferGLCode = By.XPath("(//input[@ng-model='newType.transferGLCode'])[1]");
        By TransferAccountType = By.XPath("(//input[@ng-model='newType.transferAccountType'])[1]");
        By TransferDescription = By.XPath("(//input[@ng-model='newType.transferDescription'])[1]");
        By TransferTransactionCode = By.XPath("(//input[@ng-model='newType.transferTransactionCode'])[1]");
        By TransferGLBranchCode = By.XPath("(//input[@ng-model='newType.transferGLBranchCode'])[1]");
        By TransferGLCostCenter = By.XPath("(//input[@ng-model='newType.transferCostCenter'])[1]");
        By GLAccount = By.XPath("(//input[@ng-model='newType.account'])[1]");
        By GLCode = By.XPath("(//input[@ng-model='newType.glCode'])[1]");
        By GLTransactionCode = By.XPath("(//input[@ng-model='newType.offsetTransactionCode'])[1]");
        By GLBranchCode = By.XPath("(//input[@ng-model='newType.glBranchCode'])[1]");
        By GLCostCenter = By.XPath("(//input[@ng-model='newType.glCostCenter'])[1]");
        By GLDescription = By.XPath("(//input[@ng-model='newType.offsetDescription'])[1]");
        By Reference = By.XPath("(//input[@ng-model='newType.reference'])[1]");
        By Workflow = By.XPath("(//select[@ng-model='newType.source'])[1]");
        By Branch = By.XPath("(//select[@ng-model='newType.branchCode'])[1]");
        By CustomerType = By.XPath("(//select[@ng-model='newType.accountOwnershipType'])[1]");
        By CrossButton = By.XPath("form[name='definitionForm'] .close > span");
        By SaveButton = By.XPath("form[name='definitionForm'] .btn.btn-info");
        By CloseButton = By.XPath(".container .modal-footer [data-dismiss='modal']:nth-of-type(3)");
        By DeleteDefinition = By.XPath("button[title='Delete Definition']");

        // Fields on Download from Library Page
        By CrossButton2 = By.CssSelector("div#gldefinitionLibraryPopup  .modal-content  .close");
        By SearchBar = By.CssSelector("[placeholder='Search']");
        By SearchButton = By.CssSelector(".glyphicon-search");
        By ActionField2 = By.CssSelector("gl-definition-library-popup tr th:nth-of-type(1)");
        By IDField = By.CssSelector("gl-definition-library-popup tr th:nth-of-type(2)");
        By DescriptionField2 = By.CssSelector("gl-definition-library-popup tr th:nth-of-type(3)");
        By DownloadGLDefinitionField = By.CssSelector("tr:nth-of-type(1)  button[title='Downlaod GL Definition']");
        By CloseButton2 = By.CssSelector("gl-definition-library-popup .modal-footer [data-dismiss]");


        public void ClickGLDefinitionsOption()
        {
            WaitForWebElementDisplayed(GLDefinitionsOption);
            ClickOnWebElement(GLDefinitionsOption);
        }
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
        public void AddGLDefinitionButton()
        {
            WaitForWebElementDisplayed(AddGLDefinition);
            ClickOnWebElement(AddGLDefinition);
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

        public void DownloadfromLibraryButton()
        {
            WaitForWebElementDisplayed(DownloadLetter);
            ClickOnWebElement(DownloadLetter);
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
