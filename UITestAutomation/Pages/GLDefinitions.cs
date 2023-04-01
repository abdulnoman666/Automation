using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestAutomation.Pages
{
    public class GLDefinitions : Selenium_Methods
    {
        //UI Controls on GL Definitions Page
        By AddGLDefinition = By.CssSelector("button[title='Add GL Definition']");
        By DeleteGLDefinition = By.CssSelector("button[title='Delete GL Definition']");
        By EditGLDefinition = By.CssSelector("button[title='Edit GL Definition']");
        By CopyGLDefinition = By.CssSelector("button[title='Copy GL Definition']");
        By RefreshIcon = By.CssSelector("button[title='Refresh']");
        By ShowDeletedGLDefinition = By.CssSelector(".page-link");

        // Fields on Add Field Update Scripts Page
        By TransferType = By.CssSelector("");
        By TransactionType = By.CssSelector("");
        By TransferAccount = By.CssSelector("div:nth-of-type(1) > .col-lg-8 > .form-control.ng-empty.ng-invalid.ng-invalid-required.ng-pristine.ng-touched");
        By TransferGLCode = By.XPath("//input[@ng-model='newType.offsetDescription");
        By TransferAccountType = By.CssSelector("");
        By TransferDescription = By.XPath("");
        By TransferTransactionCode = By.CssSelector("");
        By TransferGLBranchCode = By.CssSelector("");
        By TransferGLCostCenter  = By.CssSelector("");
        By GLAccount = By.CssSelector("");
        By GLCode = By.CssSelector("");
        By GLTransactionCode = By.XPath("");
        By GLBranchCode = By.CssSelector("");
        By GLCostCenter = By.CssSelector("");
        By GLDescription= By.CssSelector("");
        By Reference = By.CssSelector("");
        By Workflow = By.CssSelector("");
        By Branch = By.CssSelector("");
        By CustomerType = By.CssSelector("");
        By CrossButton= By.CssSelector("#main .modal-header [data-dismiss]");
        By SaveButton = By.CssSelector("form[name='definitionForm'] .btn.btn-info");
        By CloseButton = By.CssSelector(".container .modal-footer [data-dismiss='modal']:nth-of-type(3)");
        By DeleteDefinition = By.CssSelector("button[title='Delete Definition']");
 
    }
}












