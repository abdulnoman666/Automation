using OpenQA.Selenium;

namespace UITestAutomation.Pages.Brands.Brands
{
    internal partial class Brands
    {
        //UI Controls on Brands Page
        By BrandsOption = By.LinkText("Brands");
        By AddNewCaseBrand = By.CssSelector("button[title='New Case']");
        By DeleteBrand = By.CssSelector("tr:nth-of-type(1)  button[title='Edit Brand']");
        By EditBrand = By.CssSelector("tr:nth-of-type(1)  button[title='Edit Brand']");
        By RefreshIcon = By.CssSelector("button[title = 'Refresh']");
        By ActionField = By.CssSelector("tr > th:nth-of-type(1)");
        By BrandNameField = By.XPath("tr > th:nth-of-type(2)");
        By EmailField = By.XPath("tr > th:nth-of-type(3)");
        By AddressField = By.XPath("tr > th:nth-of-type(4)");
        By CityField = By.XPath("tr > th:nth-of-type(5)");
        By StateField = By.XPath("tr > th:nth-of-type(6)");
        By ZipField = By.XPath("tr > th:nth-of-type(7)");
        By PhoneField = By.XPath("tr > th:nth-of-type(8)");
        By FaxField = By.XPath("tr > th:nth-of-type(9)");
        By CharterField = By.XPath("tr > th:nth-of-type(10)");
        By SelectLogoFileField = By.CssSelector("tr > th:nth-of-type(11)");

        //Fields on Add Brand Page 
        By SelectLogoFile = By.CssSelector("[ng-controller] [role] [ng-model='file']");
        By BrandName = By.XPath("//input[@ng-model='brand.name']");
        By Charter = By.XPath("//input[@ng-model='brand.charter']");
        By Email = By.XPath("//input[@ng-model='brand.email']");
        By Address = By.XPath("//input[@ng-model='brand.address']");
        By City = By.XPath("//input[@ng-model='brand.city']");
        By State = By.XPath("//input[@ng-model='brand.state']");
        By Zip = By.XPath("//input[@ng-model='brand.zip']");
        By Phone = By.XPath("//input[@ng-model='brand.phone']");
        By Fax = By.XPath("//input[@ng-model='brand.fax']");
        By SaveButton = By.CssSelector(".btn.btn-info > span:nth-of-type(1)");
        By CloseButton = By.CssSelector("form[name='brandform'] .btn.btn-default");
        By CrossButton = By.CssSelector(".close > span");

    }
}
