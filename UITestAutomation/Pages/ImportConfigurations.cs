using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestAutomation.Pages
{
    public class ImportConfigurations : Selenium_Methods
    {
        //UI Controls on Import Configurations Page
        By AddConfiguration = By.CssSelector("button[title='Add Configuration']");
        By EditConfiguration = By.CssSelector("tr:nth-of-type(1)  button[title='Edit Configuration']");
        By RefreshIcon = By.CssSelector("button[title='Refresh']");

        //Fields on Add Configuration Page
        By Name = By.CssSelector("input[name='description']");
        By Delimiter = By.CssSelector("select[name='delimiter']");
        By FieldList = By.CssSelector("select[name='fieldListName']");
        By CloseButton = By.CssSelector(".modal-lg .modal-footer [data-dismiss='modal']:nth-of-type(1)");
        By SaveButton = By.CssSelector(".btn.btn-info > span:nth-of-type(1)");
    }
}
