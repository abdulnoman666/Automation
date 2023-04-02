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
        By ImportConfigurationsOption = By.LinkText("Import Configurations");
        By AddConfiguration = By.CssSelector("button[title='Add Configuration']");
        By EditConfiguration = By.CssSelector("button[title='Edit Configuration']");
        By RefreshIcon = By.CssSelector("button[title='Refresh']");
        By ActionField = By.CssSelector(".panel-body thead tr [width='50']:nth-of-type(1)");
        By IDField = By.CssSelector(".panel-body thead tr [width='50']:nth-of-type(2)");
        By NameField = By.CssSelector(".panel-body thead [width='300']");

        //Fields on Add Configuration Page
        By CrossButton = By.CssSelector(".modal-lg .modal-header [data-dismiss]");
        By Name = By.CssSelector("input[name='description']");
        By Delimiter = By.CssSelector("select[name='delimiter']");
        By FieldList = By.CssSelector("select[name='fieldListName']");
        By Chechbox = By.CssSelector("form[name='configform'] > input[name='headerRow']");
        By CloseButton = By.CssSelector(".modal-lg .modal-footer [data-dismiss='modal']:nth-of-type(1)");
        By SaveButton = By.CssSelector(".btn.btn-info > span:nth-of-type(1)");

        public void ClickImportConfigurationsOption()
        {
            WaitForWebElementDisplayed(ImportConfigurationsOption);
            ClickOnWebElement(ImportConfigurationsOption);
        }

        public void AssertUIControlsonImportConfigurationsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Add Configuration":
                        FluentWaitForWebElement(AddConfiguration);
                        break;
                    case "Edit Configuration":
                        FluentWaitForWebElement(EditConfiguration);
                        break;
                    case "Refresh":
                        FluentWaitForWebElement(RefreshIcon);
                        break;
                    case "Action Field":
                        FluentWaitForWebElement(ActionField);
                        break;
                    case "ID Field":
                        FluentWaitForWebElement(IDField);
                        break;
                    case "Name Field":
                        FluentWaitForWebElement(NameField);
                        break;
                }
            }
        }

        public void AddConfigurationButtonn()
        {
            WaitForWebElementDisplayed(AddConfiguration);
            ClickOnWebElement(AddConfiguration);
        }
        public void AssertFieldsonAddConfigurationonImportConfigurationsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Cross Button":
                        FluentWaitForWebElement(CrossButton);
                        break;
                        case "Name ":
                        FluentWaitForWebElement(Name);
                        break;
                    case "Delimiter":
                        FluentWaitForWebElement(Delimiter);
                        break;
                    case "FieldList":
                        FluentWaitForWebElement(FieldList);
                        break;
                    case "Chechbox":
                        FluentWaitForWebElement(Chechbox);
                        break;
                    case "Close Button":
                        FluentWaitForWebElement(CloseButton);
                        break;
                    case "Save Button":
                        FluentWaitForWebElement(SaveButton);
                        break;
                }

            }
        }
    }
}


