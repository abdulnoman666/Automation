using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class ImportConfigurations
    {
        //UI Controls on Import Configurations Page
        By ImportConfigurationsOption = By.XPath("//a[text='Import Configurations']");
        By AddConfiguration = By.XPath("//button[@ng-click='addConfig()']");
        By EditConfiguration = By.XPath("//button[@ng-click='editConfig(c)']");
        By RefreshIcon = By.XPath("//button[@ng-click='refreshConfig()']");
        By ActionField = By.XPath("//th[1][1]");
        By IDField = By.XPath("//th[2][1]");
        By NameField = By.XPath("//th[3][1]");

        //Fields on Add Configuration Page
        By CrossButton = By.XPath("//button[class='close'][2]");
        By Name = By.XPath("//input[@ng-model='newConfig.description']");
        By Delimiter = By.XPath("//select[@ng-model='newConfig.delimiter']");
        By FieldList = By.XPath("//select[@ng-model='newConfig.fieldListName']");
        By Chechbox = By.XPath("//input[@ng-model='newConfig.hasHeaderRow']");
        By CloseButton = By.XPath("//button[class='btn btn-default'][2]");
        By SaveButton = By.XPath("//button[@ng-click='saveConfig()']");
    }
}
