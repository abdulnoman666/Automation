using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestAutomation.Pages
{
    public class FieldUpdateScripts : Selenium_Methods
    {
        //UI Controls on Field Update Scripts Page
        By FieldUpdateScriptsOption = By.LinkText("Field Update Scripts");
        By AddFieldUpdateScript = By.CssSelector("button[title='Add Field Update Script']");
        By DeleteScript = By.CssSelector("button[title='Delete Script']");
        By EditScript = By.CssSelector("button[title='Edit Script']");
        By CopyScript = By.CssSelector("button[title='Copy Script']");
        By RefreshIcon = By.CssSelector("button[title = 'Refresh']");
        By DownloadfromLibraryButton = By.CssSelector("button[title = 'Download Letter']");
        By ActionField = By.CssSelector(".panel-body thead [width]");
        By ReferenceField = By.CssSelector(".panel-body tr th:nth-of-type(2)");//
        By NameField = By.CssSelector(".panel-body tr th:nth-of-type(3)");//


        // Fields on Add Field Update Scripts Page
        By CrossButton = By.CssSelector("form[name='configForm'] .close");
        By ScriptName = By.CssSelector("input[name = 'iname']");
        By UniqueReference = By.CssSelector("input[name='reference']");
        By Table = By.XPath("//select[@ng-model='newUpdate.tableName']");
        By Field= By.XPath("//select[@ng-model='newUpdate.field']");
        By Operator = By.XPath("//select[@ng-model='newUpdate.operatorAction']");
        By Value = By.XPath("//input[@ng-model='newUpdate.value']");
        By AddUpdateButton = By.CssSelector(".btn.btn-default.btn-sm");
        By UploadLibrary = By.CssSelector(".btn.btn-default.btn-sm"); 
        By CloseButton= By.CssSelector("form[name='configForm']  .modal-footer > button:nth-of-type(2)");
        By SaveButton = By.CssSelector("form[name='configForm'] .btn.btn-info");

        // Fields on Download from library
        By CrossButton2 = By.CssSelector("div#fieldScriptPopup  .modal-content  .close");
        By SearchBar= By.CssSelector("[placeholder='Search']");
        By SearchButton = By.CssSelector(".glyphicon-search"); 
        By ActionField2= By.CssSelector("field-script-library-popup tr th:nth-of-type(1)");
        By ReferenceField2 = By.CssSelector("field-script-library-popup tr th:nth-of-type(2)");
        By NameField2= By.CssSelector("field-script-library-popup tr th:nth-of-type(3)");
        By CloseButton2 = By.CssSelector("field-script-library-popup .modal-footer [data-dismiss]");
        By DownloadTemplate= By.CssSelector("tr:nth-of-type(1)  button[title='Download Template']");

        public void ClickFieldUpdateScriptsOption()
        {
            WaitForWebElementDisplayed(FieldUpdateScriptsOption);
            ClickOnWebElement(FieldUpdateScriptsOption);
        }

        public void AssertUIControlsonFieldUpdateScriptsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Add Field Update Script":
                        FluentWaitForWebElement(AddFieldUpdateScript);
                        break;
                    case " Edit Script":
                        FluentWaitForWebElement(EditScript);
                        break;
                    case " Delete Script":
                        FluentWaitForWebElement(DeleteScript);
                        break;
                    case " Copy Script":
                        FluentWaitForWebElement(CopyScript);
                        break;
                    case " Refresh":
                        FluentWaitForWebElement(RefreshIcon);
                        break;
                    case " Download from Library":
                        FluentWaitForWebElement(DownloadfromLibraryButton);
                        break;
                    case " Action":
                        FluentWaitForWebElement(ActionField);
                        break;
                    case " Reference":
                        FluentWaitForWebElement(ReferenceField);
                        break;
                    case " Name":
                        FluentWaitForWebElement(NameField);
                        break;
                }
            }
        }

        public void ClickAddFieldUpdateScriptOption()
        {
            WaitForWebElementDisplayed(AddFieldUpdateScript);
            ClickOnWebElement(AddFieldUpdateScript);
        }
        public void AssertFieldsonAddFieldUpdateScriptPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Cross Button":
                        FluentWaitForWebElement(CrossButton);
                        break;
                    case " Script Name":
                        FluentWaitForWebElement(ScriptName);
                        break;
                    case " Unique Reference":
                        FluentWaitForWebElement(UniqueReference);
                        break;
                    case " Table":
                        FluentWaitForWebElement(Table);
                        break;
                    case " Field":
                        FluentWaitForWebElement(Field);
                        break;
                    case " Operator":
                        FluentWaitForWebElement(Operator);
                        break;
                    case " Value":
                        FluentWaitForWebElement(Value);
                        break;
                    case " Add Update to Script":
                        FluentWaitForWebElement(AddUpdateButton);
                        break;
                    case " Upload to Library":
                        FluentWaitForWebElement(UploadLibrary);
                        break;
                    case " Close":
                        FluentWaitForWebElement(CloseButton);
                        break;
                    case " Save":
                        FluentWaitForWebElement(SaveButton);
                        break;
                }
            }
        }
        public void ClickDownloadfromlibraryButton()
        {
            WaitForWebElementDisplayed(DownloadfromLibraryButton);
            ClickOnWebElement(DownloadfromLibraryButton);
        }
        public void AssertFieldsonDownloadfromlibraryPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Cross Button":
                        FluentWaitForWebElement(CrossButton2);
                        break;
                    case " Search Bar":
                        FluentWaitForWebElement(SearchBar);
                        break;
                    case " Search Button":
                        FluentWaitForWebElement(SearchButton);
                        break;
                    case " Action":
                        FluentWaitForWebElement(ActionField2);
                        break;
                    case " Reference":
                        FluentWaitForWebElement(ReferenceField2);
                        break;
                    case " Name":
                        FluentWaitForWebElement(NameField2);
                        break;
                    case " Close":
                        FluentWaitForWebElement(CloseButton2);
                        break;
                    case " Download Template":
                        FluentWaitForWebElement(DownloadTemplate);
                        break;
                }
            }
        }
    }
}
