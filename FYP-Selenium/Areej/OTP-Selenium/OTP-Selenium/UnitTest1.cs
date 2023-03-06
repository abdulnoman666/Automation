
using OTP_Selenium.Pages;
using OTP_Selenium.HelperFunctions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OTP_Selenium
{
    public class Tests
    {
        IWebDriver webDriver;


        //Hooks in nunit
        [SetUp]
        public void Setup()
        {
          
            IWebDriver webDriver = new ChromeDriver();

            //Navigating website
            webDriver.Navigate().GoToUrl("https://disputedev.azurewebsites.net/#/login");
        }

        [Test]
        public void LoginWebsite()
        {
            Thread.Sleep(5000);

           // Login
            Login login = new(webDriver);
            login.Loginclk("abdul@finboa.com", "Password@4");

           Thread.Sleep(6000);
          // Otp
           string appUsername = "abdul@finboa.com";
          string emailPassword = "$Pak35tan$2025";
            string otpToken = string.Empty;

       otpToken = Helper_Function.GetEmailAuthenticationCode2(appUsername, emailPassword);
       Console.WriteLine(otpToken);

       LoginVerif verify = new LoginVerif(webDriver);
       verify.otpclk(otpToken);





            //Login
         // IWebElement username = webDriver.FindElement(By.CssSelector("input[type=email]"));
           // username.SendKeys("abdul@finboa.com");


           //IWebElement pass = webDriver.FindElement(By.CssSelector("input[type=password]"));
          // pass.SendKeys("Password@4");

         // IWebElement btn = webDriver.FindElement(By.Id("login"));
           // btn.Click();

        }
        // [TearDown]
        //  public void CloseBrowser()
        //  {
        //      webDriver.Quit();
        //  }
    }
}
//Since I am using C# (Syntax)
//IWebElement and IWebDriver where I is interface