using OpenQA.Selenium;

namespace UITestAutomation.Pages
{
    public class ChangePassword : Selenium_Methods
    {
        By ChangePassword_Control = By.ClassName("form-login-heading");
        By CurrentPassword_Field = By.XPath("//input[@placeholder=\"Current Password\"]");
        By NewPassword_Field = By.XPath("//input[@placeholder=\"New Password\"]");
        By ConfirmPassword_Field = By.XPath("//input[@placeholder=\"Confirm Password\"]");
        By Submit_Button= By.XPath("//button[@data-ng-click=\"submit()\"]");
    }
}
