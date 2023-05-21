using OpenQA.Selenium;

namespace UITestAutomation
{
    internal partial class QuestionnaireDependencySetup 
    {
        //UI Controls on QuestionareDPage
        By QuestionnaireDependencySetupOption = By.XPath("//div[@id='myNavbar']/ul[@class='nav navbar-nav navbar-right']/li[12]/ul[@class='dropdown-menu']//a[@href='#/finboaforms']");
        By AddFormDependancyList = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//button[@title='Add Form Dependency List']");
        By DeleteList = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//div[@class='panel-body']/table/tbody/tr[1]//button[@class='btn btn-danger glyphicon glyphicon-trash']");
        By EditFormDependencySetup = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//div[@class='panel-body']/table/tbody/tr[1]//button[@title='Edit Form Dependency Setup']");
        By CopyForm = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//div[@class='panel-body']/table/tbody/tr[1]//button[@title='Copy Form']");
        By RefreshIcon = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//div[@class='btn-group pull-right']/button[@title='Refresh']");
        By ConditionSearchText = By.XPath("/html//div[@id='main']/div[@class='container']/div[@class='ng-scope']//ul[@class='pagination']//input[@type='text']");

        //Add Brand Page (Field)
        By WorkFlowName = By.XPath("//div[@id='addForm']/div/form[@name='configform']//div[@class='modal-body']/input[@type='text']");
        By SaveButton = By.XPath("/html//div[@id='addForm']/div/form[@name='configform']//div[@class='modal-footer']/button[2]");
        By CloseButton = By.XPath("/html//div[@id='addForm']/div/form[@name='configform']//div[@class='modal-footer']/button[1]");
    }

}
