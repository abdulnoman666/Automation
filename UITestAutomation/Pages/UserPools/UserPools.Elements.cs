using OpenQA.Selenium;

namespace UITestAutomation
{
    internal partial class UserPools
    {
        //pool page
        By AddPool_Button = By.XPath("//button[@ng-click=\"addPool()\"]");
        By EditPool_Button = By.XPath("//button[@ng-click=\"editPool(p)\"]");
        By DeletePool_Button = By.XPath("//button[@ng-click=\"deletePool($event, p)\"]");
        By Refresh_Button = By.XPath("//button[@ng-click=\"refreshPools()\"]");
        By ReferenceSearch_TextBox = By.XPath("//input[@placeholder=\"Reference Search\"]");
        By Action_Field = By.XPath("//div[@class='panel panel-primary']/table//th[.='Action']");
        By ID_Field = By.XPath("//div[@class='panel panel-primary']/table//th[.='ID']");
        By GroupName_Field = By.XPath("//div[@class='panel panel-primary']/table//th[.='Group Name']");
        By Rerefernce_Field = By.XPath("//div[@class='panel panel-primary']/table//th[.='Reference']");
        By User_Field = By.XPath("//div[@class='panel panel-primary']/table//th[.='Users']");
        By show_Button = By.XPath("//button[@ng-click=\"showUsersOfPool(p)\"]");
        By UserPools_Dropdown = By.XPath("//a[@href='#/userpools']");

        //addpage
        By PoolName_Field = By.XPath("//input[@ng-model=\"selectedPool.groupName\"]");
        By PoolReference_Field = By.XPath("//form[@name='configform']/div[@class='modal-body']/div[2]/input[@type='text']");
        By PoolUserEmaillist_Field = By.XPath("//ul[@class=\"select2-selection__rendered\"]");
        By Save_Button = By.XPath("//span[text()=\"Save\"]");
        By Close_Button = By.XPath("(//button[text()=\"Close\"])[1]");

        ////edit
        //By Update_Button = By.XPath("//button[@ng-click=\"savePool()\"]");
        ////delete
        //By No_Button = By.XPath("//button[@ng-click=\"dialog.abort()\"]");
        By Yes_Button = By.XPath("//button[@ng-click=\"dialog.hide()\"]");
        By lastdelete_Element = By.XPath("(//button[@title=\"Delete Pool\"])[7]");
        By select_otpion = By.XPath("//select[@ng-model=\"selectedPool.users\"]");
    }
}
