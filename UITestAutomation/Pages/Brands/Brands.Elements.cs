using OpenQA.Selenium;

namespace UITestAutomation
{
    internal partial class Brands
    {
        //UI Controls on Brands Page
        By BrandsOption = By.XPath("//a[text='Brands']");
        By AddNewCaseBrand = By.XPath("//button[@ng-click='addBrand()']");
        By DeleteBrand = By.XPath("//button[@ng-click='deleteBrand($event, brand)']");
        By EditBrand = By.XPath("//button[@ng-click='editBrand(brand)']");
        By RefreshIcon = By.XPath("//button[@ng-click='refreshBrand()']");
        By ActionField = By.XPath("//th[1]");
        By BrandNameField = By.XPath("//th[2]");
        By EmailField = By.XPath("//th[3]");
        By AddressField = By.XPath("//th[4]");
        By CityField = By.XPath("//th[5]");
        By StateField = By.XPath("//th[6]");
        By ZipField = By.XPath("//th[7]");
        By PhoneField = By.XPath("//th[8]");
        By FaxField = By.XPath("//th[9]");
        By CharterField = By.XPath("//th[10]");
        By LogoField= By.XPath("//th[11]");

        //Fields on Add Brand Page 
        By SelectLogoFile = By.XPath("//div[@ng-model='file']");
        By BrandName = By.XPath("//input[@ng-model='brand.name']");
        By Charter = By.XPath("//input[@ng-model='brand.charter']");
        By Email = By.XPath("//input[@ng-model='brand.email']");
        By Address = By.XPath("//input[@ng-model='brand.address']");
        By City = By.XPath("//input[@ng-model='brand.city']");
        By State = By.XPath("//input[@ng-model='brand.state']");
        By Zip = By.XPath("//input[@ng-model='brand.zip']");
        By Phone = By.XPath("//input[@ng-model='brand.phone']");
        By Fax = By.XPath("//input[@ng-model='brand.fax']");
        By SaveButton = By.XPath("//span[@ng-show='mode === 1'][2]");
        By CloseButton = By.XPath("//button[@ng-click='close()'][2]");
        By CrossButton = By.XPath("//button[@ng-click='close()'][1]");
    }
}
