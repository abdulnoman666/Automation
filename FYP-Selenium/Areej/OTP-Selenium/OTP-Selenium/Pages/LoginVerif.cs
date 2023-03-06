using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OTP_Selenium.Pages
{
    public class LoginVerif
    {
        private IWebDriver Driver;
        public LoginVerif(IWebDriver webDriver)
        {

            Driver = webDriver;
        }
       
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
       // public void otpclk(string otp)
       // {
         //   otpverify.SendKeys(otp);


           // otpclkbtn.Click();

      //  }
    }
}