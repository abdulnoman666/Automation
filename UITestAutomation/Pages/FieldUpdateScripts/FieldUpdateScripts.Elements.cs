using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class FieldUpdateScripts
    {
        //UI Controls on Field Update Scripts Page
        By FieldUpdateScriptsOption = By.XPath("//a[text='Field Update Scripts']");
        By AddFieldUpdateScript = By.XPath("//button[@ng-click='addScript()']");
        By DeleteScript = By.XPath("//button[@ng-click='deleteScript($event, s)']");
        By EditScript = By.XPath("//button[@ng-click='editScripts(s)']");
        By CopyScript = By.XPath("//button[@ng-click='copyScript($event, s)']");
        By RefreshIcon = By.XPath("//button[@ng-click='refreshScripts()']");
        By DownloadfromLibraryButton = By.XPath("//button[class='btn btn-default ng-scope']");
        By ActionField = By.XPath(".panel-body thead [width]");
        By ReferenceField = By.XPath(".panel-body tr th:nth-of-type(2)");//
        By NameField = By.XPath(".panel-body tr th:nth-of-type(3)");//


        // Fields on Add Field Update Scripts Page
        By CrossButton = By.XPath("//button[class='close'][2]");
        By ScriptName = By.XPath("//input[@ng-model='newScript.automationName']");
        By UniqueReference = By.XPath("//input[@ng-model='newScript.reference']");
        By Table = By.XPath("//select[@ng-model='newUpdate.tableName']");
        By Field = By.XPath("//select[@ng-model='newUpdate.field']");
        By Operator = By.XPath("//select[@ng-model='newUpdate.operatorAction']");
        By Value = By.XPath("//input[@ng-model='newUpdate.value']");
        By AddUpdateButton = By.XPath("//button[@ng-click='saveScriptUpdateRecord(addScriptItem)']");
        By UploadLibrary = By.XPath("//button[@ng-click='copyToNewFieldScript()']");
        By CloseButton = By.XPath("//button[class='btn btn-default'][3]");
        By SaveButton = By.XPath("//span[@ng-show='mode === 1'][2]");

        // Fields on Download from library
        By CrossButton2 = By.XPath("//button[class='close'][4]");
        By SearchBar = By.XPath("//input[@ng-model='txtSearch']");
        By SearchButton = By.XPath("//span[class='glyphicon glyphicon-search']");
        By ActionField2 = By.XPath("//th[1]");
        By ReferenceField2 = By.XPath("//th[2]");
        By NameField2 = By.XPath("//th[3]");
        By CloseButton2 = By.XPath("//button[class='btn btn-default'][5]");
        By DownloadTemplate = By.XPath("//span[class='glyphicon glyphicon-download']");
    }
}
