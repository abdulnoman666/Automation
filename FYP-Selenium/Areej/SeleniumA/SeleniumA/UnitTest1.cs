using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumA
{
    public class Test
    {



        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");

            IWebElement lnkLogin = webDriver.FindElement(By.LinkText("Login"));

            lnkLogin.Click();

            var txtUserName = webDriver.FindElement(By.Name("UserName"));

            Assert.That(txtUserName.Displayed, Is.True);
            txtUserName.SendKeys("Admin");
            webDriver.FindElement(By.Name("Password")).SendKeys("password");
            webDriver.FindElement(By.XPath("//input[@value= 'Log in']")).Submit();
            var lnkEmployeeDetails = webDriver.FindElement(By.LinkText("Employee Details"));
            Assert.That(lnkEmployeeDetails.Displayed, Is.True);
        }
    }
}