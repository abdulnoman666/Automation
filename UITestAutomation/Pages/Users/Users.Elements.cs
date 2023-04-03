using OpenQA.Selenium;


namespace UITestAutomation.Pages.Users
{
    internal partial class Users
    {
        By Users_Dropdown = By.XPath("//a[@href='#/companyusers']");
        By AddUser_Button = By.CssSelector("button[title='Add User']");
        By Refresh_Button = By.CssSelector("button[title='Refresh']");
        By ShowDeletedUsers_Button = By.XPath("//span[@class='page-link']");
        By SetPage_Button = By.CssSelector("[ng-click='setpageDirect\\(1\\)']");
        By PrevPage_Button = By.CssSelector("[ng-click='prevpage\\(\\)']");
        By NextPage_Button = By.CssSelector("[ng-click='nextpage\\(\\)']");
        By SetPageDirect_Button = By.CssSelector("[ng-click='setpageDirect\\(pages\\.length\\)']");
        By EnterPage_Textbox = By.CssSelector("[ng-hide] span [type='text']");
        By Go_Button = By.CssSelector("li[role='button'] > span");
        By Action_Field = By.CssSelector("[width='110']");
        By Name_Field = By.CssSelector("thead tr th:nth-of-type(2)");
        By Name_Textbox = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//table/tbody/tr[1]/th[2]/input[@type='text']");
        By Email_Field = By.CssSelector("thead tr th:nth-of-type(3)");
        By Email_Textbox = By.CssSelector("tbody [width='200']:nth-of-type(3) .form-control");
        By Phone_Field = By.CssSelector("thead tr th:nth-of-type(4)");
        By Role_Field = By.CssSelector("thead tr th:nth-of-type(5)");
        By Role_Textbox = By.CssSelector("[width='120'] .form-control");
        By Deleted_Field = By.CssSelector("thead tr th:nth-of-type(6)");
        By HasLogin_Field = By.CssSelector("thead tr th:nth-of-type(7)");
        By Branch_Field = By.CssSelector("thead tr th:nth-of-type(8)");
        By More_Field = By.CssSelector("thead tr th:nth-of-type(9)");
        By Delete_Button = By.XPath("//button[@title='Delete User']");
        By Edit_Button = By.XPath("//button[@title='Edit User']");
        By FirstName_Textbox = By.CssSelector("input[name='firstName']");
        By LastName_Textbox = By.CssSelector("input[name='lastName']");
        By EmailAddUser_Textbox = By.CssSelector("form[name='form1'] input[name='email']");
        By Phone_Textbox = By.CssSelector("input[name='mobilePhone']");
        By Role_Dropdown = By.XPath("//div[@id='addUser']//form[@name='form1']//select");
        By SaveAddUser_Button = By.XPath("//button[@ng-disabled=\"!form1.$valid || (!newUser.id && newUser.hasAccount)\"]");
        By CloseAddUser_Button = By.CssSelector("form[name='form1']  .btn.btn-default");

    }
}
