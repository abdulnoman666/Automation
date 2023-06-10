using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class GLDefinitions
    {
        //UI Controls on GL Definitions Page
        By GLDefinitionsOption = By.XPath("//a[text='GL Definitions']");
        By AddGLDefinition = By.XPath("//button[@ng-click='addDefinition()']");
        By DeleteGLDefinition = By.XPath("//button[@ng-click='deleteTransactionType($event, definition)']");
        By EditGLDefinition = By.XPath("//button[@ng-click='editGLTransactionType(definition)']");
        By CopyGLDefinition = By.XPath("//button[@ng-click='copyGLTransactionType(definition)']");
        By RefreshIcon = By.XPath("//button[@ng-click='refreshGLAccounts()']");
        By DownloadLetter = By.XPath("//button[title='Download Letter']");
        By ShowDeletedGLDefinition = By.XPath("//input[@ng-model='showDeleted']");
        By ActionField = By.XPath("//th[1][1]");
        By TransferTypeField = By.XPath("//input[@ng-model='$.accountType']");
        By GLAccountField = By.XPath("//input[@ng-model='$.account']");
        By DescriptionField = By.XPath("//th[4][1]");
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
        By CrossButton = By.XPath("//button[class='close'][2]");
        By SaveButton = By.XPath("//button[@ng-click='saveTransactionType()']");
        By CloseButton = By.XPath("//button[class='btn btn-default'][2]");
        By DeleteDefinition = By.XPath("//button[@ng-click='toggleIsDeleted($event, newType, modal, $modal)']");

        // Fields on Download from Library Page
        By CrossButton2 = By.XPath("//button[class='close'][4]");
        By SearchBar = By.XPath("//input[@ng-model='txtSearch']");
        By SearchButton = By.XPath("//span[class='glyphicon glyphicon-search']");
        By ActionField2 = By.XPath("//th[1][2]");
        By IDField = By.XPath("//th[2][2]");
        By DescriptionField2 = By.XPath("//th[3][2]");
        By DownloadGLDefinitionField = By.XPath("//button[@ng-click='copygldefinitionToPackage({glDefinition: t})']");
        By CloseButton2 = By.XPath("//button[class='btn btn-default'][4]");
    }
}
