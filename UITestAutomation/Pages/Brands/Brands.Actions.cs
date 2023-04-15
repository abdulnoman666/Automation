
namespace UITestAutomation.Pages.Brands.Brands
{
    internal partial class Brands : Selenium_Methods
    {
        public void ClickBrandsOption()
        {
            WaitForWebElementDisplayed(BrandsOption);
            ClickOnWebElement(BrandsOption);
        }
        public void ClickAddNewCaseBrandButton()
        {
            ClickOnWebElement(AddNewCaseBrand);
            WaitForWebElementDisplayed(AddNewCaseBrand);
        }
    }
}
