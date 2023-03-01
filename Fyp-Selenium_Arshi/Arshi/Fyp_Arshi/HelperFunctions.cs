using OpenQA.Selenium;

namespace Fyp_Arshi
{
    internal class HelperFunctions
    {
        private IWebDriver webDriver;

        public HelperFunctions(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
    }
}