using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SpecFlowProject_prac.Selenium_Methods
{
    public class Selenium_Methods
    {
        public static IWebDriver driver;
        public void InitializeDriver()
        {
            driver = new ChromeDriver("E:\\chromedriver_win32");
        }

        public void GoToURL(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public void ClickOnWebElement(By reference)
        {
            driver.FindElement(reference).Click();
            
        }
        public void WaitForWebElementDisplayed(By refernce)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementIsVisible(refernce));
        }
        public void EnterValueinWebElement(By element, string value)
        {
            driver.FindElement(element).SendKeys(value);
        }
        public void ElementToBeSelectedFromDropdown(By reference,string value)
        {
            SelectElement select = new SelectElement(driver.FindElement(reference));
            select.SelectByText(value);
           
        }





       public void ClickTheWebElement(By reference)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(reference)).Click();
        }

        public void GetValidation(By reference,string v){
            IList<IWebElement> elements = driver.FindElements(reference);
         
            foreach (IWebElement element in elements)
            {
                if(element.Text == v)
                {

                    //   WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                    //  wait.Until(ExpectedConditions.ElementToBeClickable(element)).Click();
                   // Action action = new Action();

                  //  actions().mouseMove(element).click().perform();


                }
            }
        }

        


    }
}
