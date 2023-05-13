using OpenQA.Selenium;

namespace UITestAutomation
{
    internal partial class ChangePassword
    {
        By ChangePassword_Control = By.CssSelector("form[role='form'] > .form-login-heading");
        By CurrentPassword_Field = By.XPath("//input[@placeholder=\"Current Password\"]");
        By NewPassword_Field = By.XPath("//input[@placeholder=\"New Password\"]");
        By ConfirmPassword_Field = By.XPath("//input[@placeholder=\"Confirm Password\"]");
        By Submit_Button = By.XPath("//button[@data-ng-click=\"submit()\"]");
        By ChangePassword_Dropdown = By.CssSelector("[href='\\#\\/changepassword']");
    }
}
