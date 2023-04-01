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
        By AddFieldUpdateScript = By.CssSelector("button[title='Add Field Update Script']");
        By DeleteScript = By.CssSelector("button[title='Delete Script']");
        By EditScript = By.CssSelector("button[title='Edit Script']");
        By CopyScript = By.CssSelector("button[title='Copy Script']");
        By RefreshIcon = By.CssSelector("button[title = 'Refresh']");
        By DownloadLetter = By.CssSelector("button[title = 'Download Letter']");

        //Fields on Delete Page
        By NoButton = By.CssSelector("md-dialog-actions [type='button']:nth-of-type(1)");
        By YesButton = By.CssSelector("md-dialog-actions [type='button']:nth-of-type(2)");

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
        By Action= By.CssSelector("field-script-library-popup tr th:nth-of-type(1)");
        By Reference = By.CssSelector("field-script-library-popup tr th:nth-of-type(2)");
        By Name= By.CssSelector("field-script-library-popup tr th:nth-of-type(3)");
        By CloseButton2 = By.CssSelector("field-script-library-popup .modal-footer [data-dismiss]");
        By DownloadTemplate= By.CssSelector("tr:nth-of-type(1)  button[title='Download Template']");
    }
}
