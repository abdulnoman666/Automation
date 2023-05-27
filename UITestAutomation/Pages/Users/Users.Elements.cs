using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class Users
    {
        By Users_Dropdown = By.XPath("//a[@href='#/companyusers']");
        By AddUser_Button = By.XPath("//button[@ng-click=\"addUser()\"]");
        By Refresh_Button = By.XPath("//button[@ng-click=\"refreshUsers()\"]");
        By ShowDeletedUsers_Button = By.XPath("//input[@ng-model=\"showDeleted\"]");
        By SetPage_Button = By.XPath("//span[@ng-click=\"setpageDirect(pages.length)\"]");
        By PrevPage_Button = By.XPath("//span[@ng-click=\"prevpage()\"]");
        By NextPage_Button = By.XPath("//span[@ng-click=\"nextpage()\"]");
        By SetPageDirect_Button = By.XPath("//span[@ng-click='setpageDirect(1)']");
        By EnterPage_Textbox = By.XPath("//input[@placeholder=\"Enter Page\"]");
        By Go_Button = By.XPath("//span[text()=\"Go\"]");
        By Action_Field = By.XPath("(//th[1])[1]");
        By Name_Field = By.XPath("(//th[2])[1]");
        By Name_Textbox = By.XPath("(//th[2])[2]");
        By Email_Field = By.XPath("(//th[3])[1]");
        By Email_Textbox = By.XPath("(//input[@ng-model=\"$.email\"])[1]");
        By Phone_Field = By.XPath("(//th[4])[1]");
        By Role_Field = By.XPath("(//th[5])[1]");
        By Role_Textbox = By.XPath("(//th[5])[2]");
        By Deleted_Field = By.XPath("(//th[6])[1]");
        By HasLogin_Field = By.XPath("(//th[7])[1]");
        By Branch_Field = By.XPath("(//th[8])[1]");
        By More_Field = By.XPath("(//th[9])[1]");
        By Delete_Button = By.XPath("//button[@title='Delete User']");
        By Edit_Button = By.XPath("//button[@title='Edit User']");
        By FirstName_Textbox = By.XPath("//input[@ng-model=\"newUser.firstName\"]");
        By LastName_Textbox = By.XPath("//input[@ng-model=\"newUser.lastName\"]");
        By EmailAddUser_Textbox = By.XPath("//input[@ng-model=\"newUser.email\"]");
        By Phone_Textbox = By.XPath("//input[@ng-model=\"newUser.mobilePhone\"]");
        By Role_Dropdown = By.XPath("//select[@ng-model=\"newUser.role\"]");
        By SaveAddUser_Button = By.XPath("//button[@ng-click=\"addNewUser(form1)\"]");
        By CloseAddUser_Button = By.XPath("(//button[text()=\"Close\"])[2]");
        By DeleteUser_Button = By.XPath("//button[@ng-click=\"dialog.hide()\"]");
    }
}
