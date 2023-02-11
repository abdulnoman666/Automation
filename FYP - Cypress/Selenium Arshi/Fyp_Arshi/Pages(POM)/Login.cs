using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fyp_Arshi.Pages_POM_
{
    public class Login
    {

         public Login(IWebDriver webDriver) {
          Driver = webDriver;
        }
        private IWebDriver Driver;


        // using lambda expression
           public IWebElement email => Driver.FindElement(By.CssSelector("input[type=email]"));
        


        // using get set property 
        public IWebElement password
        {
            get
            {
                return Driver.FindElement(By.CssSelector("input[type=password]"));
            }
        }

        public IWebElement click => Driver.FindElement(By.Id("login"));
       

        public void Loginclk(string username,string pass)
        {
            email.SendKeys(username);

            //performing assertion
            string em = email.GetAttribute("value");
            Assert.That(em, Is.Not.Empty);

            password.SendKeys(pass);
            click.Click();

        }

      


    }
}
