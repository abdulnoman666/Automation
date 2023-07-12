using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class AlertDefinitions
    {
        By AlertDefinitionButton = By.XPath("//div[@id='myNavbar']/ul[@class='nav navbar-nav navbar-right']/li[12]/ul[@class='dropdown-menu']//a[@href='#/alertdefinitions']");
        By AddAlertDefinitions_Button = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//button[@title='Add Alert Definition']");
        By DeleteAlertDefinitions_Button = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//div[@class='panel-body']/table/tbody/tr[1]//button[@title='Delete Alert Definition']/span[@class='glyphicon glyphicon-trash']");
        By CopyAlertDefinition_Button = By.XPath("/html//div[@id='main']/div[@class='container']/div[@class='ng-scope']//div[@class='panel-body']/table/tbody/tr[1]//button[@title='Edit Alert Definition']");
        By CreateAlertDefinitons_Button = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//div[@class='panel-heading']/button[@class='btn btn-default']");
        By DownloadFromLibrary_Button = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//button[@title='Download alert']");
        By EditAlertDefinition_Button=  By.XPath("//button[@title=\"Edit Alert Definition\"]");
        By Explanation_Button = By.XPath("(//a[@ng-click=\"select($event)\"])[2]");

        // Add Definition Dialog
        By DefinitionName_Field = By.XPath("/html//div[@id='addDefinition']//form[@name='configform']//div[@class='modal-body']//div[@class='tab-content']/div[1]//input[@name='alertName']");
        By AlertType_Field = By.XPath("/html//div[@id='addDefinition']//form[@name='configform']//div[@class='modal-body']//div[@class='tab-content']/div[1]/div[2]/select[@name='delimiter']");
        By TableName_Field = By.XPath("/html//div[@id='addDefinition']//form[@name='configform']//div[@class='modal-body']//div[@class='tab-content']/div[1]/div[3]/select[@name='delimiter']");
        By DeadlineRefrence_Field = By.XPath("/html//div[@id='addDefinition']//form[@name='configform']//div[@class='modal-body']//div[@class='tab-content']/div[1]/div[4]/input[@name='deadlineReference']");
        By BusinessDays_CheckBox = By.XPath("//div[@id='addDefinition']//form[@name='configform']//div[@class='modal-body']//div[@class='tab-content']/div[1]//div[@class='col-md-4']/input[@name='businessDays']");
        By CalculateTheLastBusinessDay_CheckBox = By.XPath("//div[@id='addDefinition']//form[@name='configform']//div[@class='modal-body']//div[@class='tab-content']/div[1]//div[@class='col-md-8']/input[@name='calculateTheLastBusinessDay']");
        By Days_Field = By.XPath("/html//div[@id='addDefinition']//form[@name='configform']//div[@class='modal-body']//div[@class='tab-content']/div[1]/div[6]/input[@name='deadlineReference']");
        By Reference_Field = By.XPath("/html//div[@id='addDefinition']//form[@name='configform']//div[@class='modal-body']//div[@class='tab-content']/div[1]//input[@name='reference']");
        By SourceList_Field = By.XPath("/html//div[@id='addDefinition']//form[@name='configform']//div[@class='modal-body']//div[@class='tab-content']/div[1]//input[@name='sourceList']");
        By Save_Button = By.XPath("/html//div[@id='addDefinition']//form[@name='configform']//div[@class='modal-footer']/button[2]");
        By Close_Button = By.XPath("/html//div[@id='addDefinition']//form[@name='configform']//div[@class='modal-footer']/button[1]");
        //Explanation page
        By Explanation_Form = By.XPath("//div[@id='addDefinition']//form[@name='configform']//div[@class='tab-content']/div[2]/div[@role='application']/div[@class='fr-wrapper show-placeholder']/div[@class='fr-element fr-view']");




    }
}
