using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Collections.ObjectModel;
using System.Linq;

namespace UITestAutomation
{
    public class Selenium_Methods
    {
        public static IWebDriver driver;
        public static void InitializeDriver()
        {    
            driver = new ChromeDriver(ConfigHelper.GetConfig("ChromeDriver"));
        }

        public static void GoToURL(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }

        public void ClickOnWebElement(By reference)
        {
            driver.FindElement(reference).Click();

        }

        public void WaitForWebElementDisplayed(By refernce, int seconds = 60)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            wait.Until(ExpectedConditions.ElementIsVisible(refernce));
        }

        public void EnterValueinWebElement(By element, string value)
        {
            driver.FindElement(element).SendKeys(value);
        }

        public void ElementToBeSelectedFromDropdown(By reference, string value)
        {
            SelectElement select = new SelectElement(driver.FindElement(reference));
            select.SelectByText(value);

        }

        public void ClickTheWebElement(By reference)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(reference)).Click();
        }

        public void FluentWaitForWebElement(By reference, int seconds = 60)
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(seconds);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(1000);
            fluentWait.Message = "timeout occured";
            Assert.IsTrue(driver.FindElement(reference).Displayed, "Element is not Displayed");
        }

        public  bool IsChecked(By reference)
        {
            if (driver.FindElement(reference).Selected) {
                return true;
            }
            else {
                return false;
            }
        }

        public ReadOnlyCollection<IWebElement> GetElements(By element)
        {
            var elements = driver.FindElements(element);
            return elements;
        }

        public static void CloseDriver()
        {
            driver.Close();
        }
    }
}
