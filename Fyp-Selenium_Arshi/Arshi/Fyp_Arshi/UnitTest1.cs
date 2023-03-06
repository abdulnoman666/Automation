using Fyp_Arshi.Pages_POM_;
using Fyp_Arshi.Helper_Functions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Fyp_Arshi
{
    public class Tests
    {
        IWebDriver webDriver;
        

        //Hooks in nunit
        [SetUp]
        public void Setup()
        {
            //Open browser (provides interface to open any browser)
            //Since chrome was not updated so in order to run this we need same versions of both chrome and chrome webdriver 
            //that is why downloaded this and provide path of this
            webDriver = new ChromeDriver();
            

            //Navigating website
            webDriver.Navigate().GoToUrl("https://disputedev.azurewebsites.net/#/login");
        }

        [Test]
        public void LoginWebsite()
        {
            Thread.Sleep(5000);

            //Login
            Login login = new Login(webDriver);
            login.Loginclk("abdul@finboa.com", "Password@4");

            Thread.Sleep(6000);
            //Otp
            string appUsername = "abdul@finboa.com";
            string emailPassword = "$Pak35tan$2025";
            string otpToken = string.Empty;
           
            otpToken=HelperFunction.GetEmailAuthenticationCode2(appUsername, emailPassword);
            Console.WriteLine(otpToken);

            Loginverification verify = new Loginverification(webDriver);
            verify.otpclk(otpToken);
           




            //Login
            //   IWebElement username = webDriver.FindElement(By.CssSelector("input[type=email]"));
            //  username.SendKeys("abdul@finboa.com");


            // IWebElement pass = webDriver.FindElement(By.CssSelector("input[type=password]"));
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