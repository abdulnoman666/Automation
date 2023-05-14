using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class GLDefinitions
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
        By CrossButton2 = By.CssSelector("div#gldefinitionLibraryPopup.modal-content.close");
        By SearchBar = By.CssSelector("[placeholder='Search']");
        By SearchButton = By.CssSelector(".glyphicon-search");
        By ActionField2 = By.CssSelector("gl-definition-library-popup tr th:nth-of-type(1)");
        By IDField = By.CssSelector("gl-definition-library-popup tr th:nth-of-type(2)");
        By DescriptionField2 = By.CssSelector("gl-definition-library-popup tr th:nth-of-type(3)");
        By DownloadGLDefinitionField = By.CssSelector("tr:nth-of-type(1)  button[title='Downlaod GL Definition']");
        By CloseButton2 = By.CssSelector("gl-definition-library-popup .modal-footer [data-dismiss]");
    }
}
