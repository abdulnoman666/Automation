using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SeleniumA.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumA.Tests
{ 
  public class Tests
{
        IWebDriver webDriver = new ChromeDriver();
        [SetUp]
    public void Setup()
    {
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");
        }

    [Test]
    public void Login()
    {
            HomeP homeP = new HomeP(webDriver);
            homeP.ClickLogin();

            LoginP loginP = new LoginP(webDriver);
            loginP.Login("admin", "password");
           // Assert.That(homeP.IsEmployeeDetailsExist, Is.True);

    }
        [TearDown]
        public void TearDown() => webDriver.Quit();
} }