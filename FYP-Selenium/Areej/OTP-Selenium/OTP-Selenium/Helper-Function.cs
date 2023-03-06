using OpenQA.Selenium;

namespace OTP_Selenium
{
    internal class Helper_Function
    {
        private IWebDriver webDriver;

        public Helper_Function(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        internal static string GetEmailAuthenticationCode2(string appUsername, string emailPassword)
        {
            throw new NotImplementedException();
        }
    }
}