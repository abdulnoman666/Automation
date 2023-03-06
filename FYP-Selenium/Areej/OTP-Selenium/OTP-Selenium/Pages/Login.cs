using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTP_Selenium.Pages
{
    public class Login
    {
        public Login(IWebDriver webDriver)
        {
            Driver = webDriver;
        }
        private IWebDriver Driver;

        public IWebElement Email => Driver.FindElement(By.XPath("//input[@type=\"email\"]"));

       
        public IWebElement password
        {
            get
            {
                return Driver.FindElement(By.CssSelector("input[type=password]"));
            }
        }
        public IWebElement click => Driver.FindElement(By.Id("login"));


        public void Loginclk(string username, string pass)
        {
            Email.SendKeys(username);

            //performing assertion
            string em = Email.GetAttribute("value");
            Assert.That(em, Is.Not.Empty);

            password.SendKeys(pass);
            click.Click();

        }




    }
}
