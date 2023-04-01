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
        By AddNewCaseBrand = By.CssSelector("button[title='New Case']");
        By DeleteBrand = By.CssSelector("tr:nth-of-type(1)  button[title='Edit Brand']");
        By EditBrand = By.CssSelector("tr:nth-of-type(1)  button[title='Edit Brand']");
        By RefreshIcon = By.CssSelector("button[title = 'Refresh']");
        

        //Add Brand Page (Fields)
        By SelectLogoFile = By.CssSelector("[ng-controller] [role] [ng-model='file']");
        By Name = By.XPath("//input[@ng-model='brand.name']");
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
    }
}
