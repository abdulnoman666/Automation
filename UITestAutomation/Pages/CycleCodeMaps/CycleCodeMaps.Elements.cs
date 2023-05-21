using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class CycleCodeMaps
    {
        By CycleCodeMapsOption = By.XPath("//div[@id='myNavbar']/ul[@class='nav navbar-nav navbar-right']/li[12]/ul[@class='dropdown-menu']//a[@href='#/cyclecodemaps']Cycle Code Maps");
        By AddCycleCodeMaps_Button = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//button[@title='Add Cycle Code Map']");
        By DeleteCycleCodeMaps_Button = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//table/tbody/tr[1]//button[@title='Delete Cycle Code Map']");
        By EditCycleCodeMaps_Button = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//table/tbody/tr[1]//button[@title='Edit Cycle Code Map']");

        //ADD PAGE
        By CycleCode_Field = By.XPath("/html//div[@id='addMap']//form[@name='configform']/div[1]/input[@type='text']");
        By MappedValue_Field = By.XPath("/html//div[@id='addMap']//form[@name='configform']/div[2]/input[@type='text']");
        By Save_Button = By.XPath("/html//div[@id='addMap']//div[@class='modal-footer']/button[2]");
        By Close_Button = By.XPath("/html//div[@id='addMap']//div[@class='modal-footer']/button[1]");
    }
}
