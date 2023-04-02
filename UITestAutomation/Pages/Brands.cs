using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace UITestAutomation.Pages
{
    public class Brands: Selenium_Methods
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

        //Add Brand Page (Fields)
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
        By SaveButton= By.ClassName("btn btn-info");
        By CloseButton = By.ClassName("btn btn-default");
        By CrossButton = By.CssSelector(".close > span");
       
        public void ClickBrandsOption()
        {
            WaitForWebElementDisplayed(BrandsOption);
            ClickOnWebElement(BrandsOption);
        }
         
        public void AssertUIControlsOnBrandsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Add New Case Brand":
                        FluentWaitForWebElement(AddNewCaseBrand);
                        break;
                    case "Delete Brand":
                        FluentWaitForWebElement(DeleteBrand);
                        break;
                    case "Edit Brand":
                        FluentWaitForWebElement(EditBrand);
                        break;
                    case "Refresh Icon":
                        FluentWaitForWebElement(RefreshIcon);
                        break;
                    case "Action Field ":
                        FluentWaitForWebElement(ActionField);
                        break;
                    case "Brand Name Field":
                        FluentWaitForWebElement(BrandNameField);
                        break;
                    case "E Mail Field":
                        FluentWaitForWebElement(EmailField);
                        break;
                    case "Address Field":
                        FluentWaitForWebElement(AddressField);
                        break;
                    case "City Field":
                        FluentWaitForWebElement(CityField);
                        break;
                    case "State Field":
                        FluentWaitForWebElement(StateField);
                        break;
                    case "Zip Field":
                        FluentWaitForWebElement(ZipField);
                        break;
                    case "Phone Field":
                        FluentWaitForWebElement(PhoneField);
                        break;
                    case "Fax Field":
                        FluentWaitForWebElement(FaxField);
                        break;
                    case "Charter Field ":
                        FluentWaitForWebElement(CharterField);
                        break;
                    case "Select Logo File Field":
                        FluentWaitForWebElement(SelectLogoFileField);
                        break;
                }
            }
        }

        public void ClickAddNewCaseBrandButton()
        {
            ClickOnWebElement(AddNewCaseBrand);
            WaitForWebElementDisplayed(AddNewCaseBrand);
        }

        public void AssertFieldsonAddBrandsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Select Logo File":
                        FluentWaitForWebElement(SelectLogoFile);
                        break;
                    case "Brand Name ":
                        FluentWaitForWebElement(BrandName);
                        break;
                    case "Charter ":
                        FluentWaitForWebElement(Charter);
                        break;
                    case "E Mail":
                        FluentWaitForWebElement(Email);
                        break;
                    case "Address":
                        FluentWaitForWebElement(Address);
                        break;
                    case "City":
                        FluentWaitForWebElement(City);
                        break;
                    case "State":
                        FluentWaitForWebElement(State);
                        break;
                    case "Zip":
                        FluentWaitForWebElement(Zip);
                        break;
                    case "Phone":
                        FluentWaitForWebElement(Phone);
                        break;
                    case "Fax":
                        FluentWaitForWebElement(Fax);
                        break;
                    case "Save":
                        FluentWaitForWebElement(SaveButton);
                        break;
                    case "Close":
                        FluentWaitForWebElement(CloseButton);
                        break;
                    case "Cross":
                        FluentWaitForWebElement(CrossButton);
                        break;
                }
            }
        }
    }
}
