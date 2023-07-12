﻿
namespace UITestAutomation
{
    internal partial class Brands : Selenium_Methods
    {
        public void ClickBrandsButton()
        {
            WaitForWebElementDisplayed(BrandsOption);
            ClickOnWebElement(BrandsOption);
        }
        public void ClickAddNewCaseBrandButton()
        {
            WaitForWebElementDisplayed(AddNewCaseBrand);
            ClickOnWebElement(AddNewCaseBrand);
            WaitForWebElementDisplayed(AddNewCaseBrand);
        }
    }
}
