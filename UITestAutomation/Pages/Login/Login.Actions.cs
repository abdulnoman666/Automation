
namespace UITestAutomation.Pages.Login
{
    internal partial class Login
    {
        Selenium_Methods sM = new Selenium_Methods();
        public void EnterEmailOnLoginPage(string username)
        {
            sM.WaitForWebElementDisplayed(Email);
            sM.EnterValueinWebElement(Email, username);
        }
        public void EnterPasswordOnLoginPage(string password)
        {
            sM.WaitForWebElementDisplayed(Password);
            sM.EnterValueinWebElement(Password, password);
        }
        public void ClickLoginButtonOnLoginPage()
        {
            sM.WaitForWebElementDisplayed(Click_btn);
            sM.ClickOnWebElement(Click_btn);
        }
    }
}
