using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;
using OTP_S.Helper_Function;
using OTP_S.Pages;

namespace OTP_S
{
    public class Tests
    {
        IWebDriver webDriver;
        [SetUp]
       
        public void Setup()
        {
            webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://disputedev.azurewebsites.net/#/login");
        }

        [Test]
        public void Test1()
        {
            Thread.Sleep(5000);

            //Login
            Login_app login = new Login_app(webDriver);
            login.Loginclk("abdul@finboa.com", "Password@4");

            Thread.Sleep(6000);
            //Otp
            string appUsername = "abdul@finboa.com";
            string emailPassword = "$Pak35tan$2025";
            string otpToken = string.Empty;

            otpToken = HelperFunction.GetEmailAuthenticationCode2(appUsername, emailPassword);
            Console.WriteLine(otpToken);

            authenticate_app verify = new authenticate_app(webDriver);
            
            
            verify.Otpclick(otpToken);

            
        }

       
    }
}