using Fyp_Arshi.Pages_POM_;
using Fyp_Arshi.Helper_Functions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Fyp_Arshi
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
           




        