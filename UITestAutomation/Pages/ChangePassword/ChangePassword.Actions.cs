
namespace UITestAutomation.Pages.ChangePassword
{
    internal partial class ChangePassword :Selenium_Methods
    {
        public void ClickChangePassword()
        {
            ClickOnWebElement(ChangePassword_Dropdown);
            WaitForWebElementDisplayed(ChangePassword_Control);
        }
    }
}
