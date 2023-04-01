using OpenQA.Selenium;

namespace UITestAutomation
{
    public class Login
    {
        Selenium_Methods sM = new Selenium_Methods();
        //Locating Elements of Login-Page
        By Email =    By.XPath("//input[@type='email']");
        By Password = By.CssSelector("input[type=password]");
        By Click_btn = By.Id("login");

        public void initializeAndGoTo(string url)
        {
            Selenium_Methods.InitializeDriver();
            Selenium_Methods.GoToURL(url);
        }

        public void EnterEmailOnLoginPage(string username)
        {
            sM.WaitForWebElementDisplayed(Email);
            sM.EnterValueinWebElement(Email, username);
        }
        public void EnterPasswordOnLoginPage(string password)
        {
            sM.WaitForWebElementDisplayed(Password);
            sM.EnterValueinWebElement(Password,password);
        }
        public void ClickLoginButtonOnLoginPage()
        {
            sM.WaitForWebElementDisplayed(Click_btn);
            sM.ClickOnWebElement(Click_btn);
        }
       

    }
}
