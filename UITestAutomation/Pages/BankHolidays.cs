using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestAutomation.Pages
{
    public class BankHolidays: Selenium_Methods
    {
        //UI Controls on Bank Holidays Page
        By AddNewBankHolidays = By.CssSelector("button[title='Add Holiday']");
        By DeleteBankHolidays = By.CssSelector("tr:nth-of-type(1)  button[title='Delete Holiday']");
        By EditBankHolidays = By.CssSelector("tr:nth-of-type(1)  button[title='Edit Holiday']");
        By RefreshIcon = By.CssSelector("button[title='Refresh']");

        //Add Brand Page (Field)
        By AddHoliday = By.XPath("/html//div[@id='addHoliday']//md-datepicker[@type='date']/div/button[@type='button']");
        By SaveButton = By.ClassName("btn btn-info");
        By CloseButton = By.ClassName("btn btn-default");
    }
  
}
