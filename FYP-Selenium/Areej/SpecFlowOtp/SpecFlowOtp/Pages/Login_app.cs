using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowOtp.Pages
{
    public class Login_app: SpecFlowOtp.Selenium_Methods.SMethods
    {
        By Email = By.XPath("///input[@type= 'email']");
        By Password = By.CssSelector("input[type=password]");
        By Click_btn = By.Id("Login_app");
            public void initializeAndGoTo(string url)
        {
            initialize_driver();
            GoTo(url);
        }

        public void Email_app(string username)
        {
            Thread.Sleep(3000);
            driver.FindElement(Email).SendKeys(username);

        }
        public void Password_app(string password)
        {
            driver.FindElement(Password).SendKeys(password);


        }
        public void Click()
        {
            ClickOn(Click_btn);
        }

    }
}
