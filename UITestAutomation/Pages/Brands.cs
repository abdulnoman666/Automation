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
        By AddNewCaseBrand = By.CssSelector("button[title='New Case']");
        By Name = By.CssSelector("div:nth-of-type(2) > label");
        By Email = By.CssSelector("tr > th:nth-of-type(3)");
        By Address = By.CssSelector("tr > th:nth-of-type(4)");
        By City = By.CssSelector("tr > th:nth-of-type(5)");
        By State = By.CssSelector("tr > th:nth-of-type(6)");
        By Zip = By.CssSelector("tr > th:nth-of-type(7)");
        By Phone = By.CssSelector("tr > th:nth-of-type(8)");
        By Fax = By.CssSelector("tr > th:nth-of-type(9)");
        By Charter = By.CssSelector("tr > th:nth-of-type(10)");
        By Logo = By.CssSelector("tr > th:nth-of-type(11)");
        By SaveButton= By.ClassName("btn btn-info");
  
        public void ClickAddBrandProcessesElementOnBrandProcessPage()
        {
            WaitForWebElementDisplayed(AddNewCaseBrand);
            ClickOnWebElement(AddNewCaseBrand);
        }
        public void EnterBrandNameonBrandSetupDialog()
        {
            WaitForWebElementDisplayed(Name);
        }
        public void EnterEmailonBrandSetupDialog()
        {
            WaitForWebElementDisplayed(Email);
        }
        public void EnterAddressonBrandSetupDialog()
        {
            WaitForWebElementDisplayed(Address);
        }
        public void EnterCityonBrandSetupDialog()
        {
            WaitForWebElementDisplayed(City);
        }
        public void EnterStateonBrandSetupDialog()
        {
            WaitForWebElementDisplayed(State);
        }
        public void EnterZiponBrandSetupDialog()
        {
            WaitForWebElementDisplayed(Zip);
        }
        public void EnterPhoneonBrandSetupDialog()
        {
            WaitForWebElementDisplayed(Phone);
        }
        public void EnterFaxonBrandSetupDialog()
        {
            WaitForWebElementDisplayed(Fax);
        }
        public void EnterCharteronBrandSetupDialog()
        {
            WaitForWebElementDisplayed(Charter);
        }
        public void EnterLogoonBrandSetupDialog()
        {
            WaitForWebElementDisplayed(Logo);
        }
        public void UserClicksSaveButtonOnAddBrandSetupDialog()
        {
            WaitForWebElementDisplayed(SaveButton);
            ClickOnWebElement(SaveButton);
        }
    }
}
