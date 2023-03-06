using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTP_S.Pages
{
    public class authenticate_app
    {
        private IWebDriver Driver;

        public authenticate_app(IWebDriver webDriver)
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
        public void Otpclick(string otp)
        {
            otpverify.SendKeys(otp);


            otpclkbtn.Click();

        }
    }
}
