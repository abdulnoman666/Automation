using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowOtp.Selenium_Methods
{
    public class SMethods
    {

        public static IWebDriver driver;
        public void initialize_driver()

        {
            driver = new ChromeDriver();
            }
        public void GoTo(string url)
        driver.Navigate().GoToUrl(url);

            public void ClickOn(By reference)
        driver.FindElement(reference).click();

        }
    }
}