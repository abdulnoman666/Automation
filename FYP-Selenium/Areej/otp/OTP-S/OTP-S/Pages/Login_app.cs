using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTP_S.Pages
{
    public class Login : Selenium_Methods.Selenium_Methods
    {
        By Email = By.XPath("///input[@type= 'email']");
        By Password = By.CssSelector("input[type=password]");
        By.Click_btn = By.Id("Login");
            public void initializeAndGoTo(string url)
        {
            initilize_driver();
            GoTo(url);
        }

        public void Email_app(string username)
        {
            Thread.Sleep(3000);
            Driver.FindElement(Email).SendKeys(username);
            
        }
        public void Password_app(string password)
        {
            Driver.FindElement(Password).SendKeys(password);


        }
        public void Click()
        {
            ClickOn(Click_btn)
        }
        




    }
}
