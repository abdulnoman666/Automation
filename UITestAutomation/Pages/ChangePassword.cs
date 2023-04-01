using NUnit.Framework;
using OpenQA.Selenium;

namespace UITestAutomation.Pages
{
    public class ChangePassword : Selenium_Methods
    {
        By ChangePassword_Control = By.CssSelector("form[role='form'] > .form-login-heading");
        By CurrentPassword_Field = By.XPath("//input[@placeholder=\"Current Password\"]");
        By NewPassword_Field = By.XPath("//input[@placeholder=\"New Password\"]");
        By ConfirmPassword_Field = By.XPath("//input[@placeholder=\"Confirm Password\"]");
        By Submit_Button = By.XPath("//button[@data-ng-click=\"submit()\"]");
        By ChangePassword_Dropdown = By.CssSelector("[href='\\#\\/changepassword']");

        public void ClickChangePassword()
        {
            ClickOnWebElement(ChangePassword_Dropdown);
            WaitForWebElementDisplayed(ChangePassword_Control);

        }
        public void AssertUIControlsOnChangePasswordPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Change Password":
                        FluentWaitForWebElement(ChangePassword_Control);
                        break;
                    case "Submit":
                        FluentWaitForWebElement(Submit_Button);
                        break;
                }
            }
        }
        public void AssertFieldsOnChangePasswordPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Current Password":
                        FluentWaitForWebElement(CurrentPassword_Field);
                        break;
                    case "New Password":
                        FluentWaitForWebElement(NewPassword_Field);
                        break;
                    case "Confirm Password":
                        FluentWaitForWebElement(ConfirmPassword_Field);
                        break;
                }
            }
        }

    }
}
