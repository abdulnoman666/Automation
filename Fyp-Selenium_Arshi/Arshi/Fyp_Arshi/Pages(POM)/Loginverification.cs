using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Fyp_Arshi.Pages_POM_
{
    public class Loginverification
    {
        private IWebDriver Driver;

       
        //  public Loginverification(IWebDriver webDriver)
        //{
        //  Driver = webDriver;
        //}

        public Loginverification(IWebDriver webDriver)
        {
           
            Driver = webDriver;
        }
        

        // using get set property 
        public IWebElement otpverify
        {
            get
            {
                return Driver.FindElement(By.Id("otp"));
            }
        }

        public IWebElement otpclkbtn
        {
            get
            {
                return Driver.FindElement(By.ClassName("reply-button"));
            }
        }
        public void otpclk(string otp)
        {
            otpverify.SendKeys(otp);

            
            otpclkbtn.Click();

        }
    }
}
