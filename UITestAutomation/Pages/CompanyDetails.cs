using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestAutomation.Pages
{
    public class CompanyDetails : Selenium_Methods
    {
        //UI Controls on Company Details Page
        By BasicInfo = By.LinkText("Basic Info");
        By GeneralSettings = By.LinkText("General Settings");
        By LookupValues = By.LinkText("Lookup Values");
        By Style = By.LinkText("Style");
        By SaveButton = By.CssSelector(".ng-scope > div:nth-of-type(3) .btn.btn-default");

        //Fields of Basic Info
        By CompanyName = By.CssSelector("input[name='companyName']");
        By Address = By.CssSelector("input[name='address']");
        By City = By.CssSelector("input[name='city']");
        By State  = By.CssSelector("input[name='state']");
        By Zip = By.CssSelector("input[name='zip']");
        By Phone = By.CssSelector("input[name='phone']");
        By Email = By.CssSelector("input[name='email']");
        By ResponseEmail = By.CssSelector("input[name='responseEmail']");
        By EmailList = By.CssSelector("input[name='emailDistributionList']");
        By Time = By.CssSelector("[ng-show] .fi-field:nth-child(11) option");
        By Questionnaires = By.XPath("//select[@ng-model='company.customerAppReadOnly']");

        //Fields of General Settings
        By SignaturePad = By.CssSelector("[ng-model] option[value='topaz-signature'][selected='selected']");
        By Timeout = By.XPath("//input[@ng-model='company.idleTime']");
        By StatementCycle = By.CssSelector("div:nth-of-type(4) .col-lg-4 > div:nth-of-type(1) > label");
        By CompanyLogo = By.CssSelector("[ng-show] [ng-model='file']");
        
        
        // Fields on Style
        By Primary = By.CssSelector(".color-picker-input-swatch.ng-touched");
        By Secondary = By.CssSelector("[ng-show] .fi-field:nth-child(3) .color-picker-input-swatch");
        By PrimaryFont = By.CssSelector(".color-picker-input-swatch.ng-empty.ng-touched");
        By SecondaryFont = By.CssSelector("[ng-show] .fi-field:nth-child(5) .color-picker-input-swatch");
       
        
        By AddSubmissionStatus = By.CssSelector("button[title='Add Submission Status']");
        By AddSource = By.CssSelector("button[title='Add Source']");
        By AddAccountType = By.CssSelector("button[title='Add Account Type']");
        By AddDisputeDetail = By.CssSelector("button[title='Add Dispute Research Detail']"); 
        By AddBranch = By.CssSelector("button[title='Add Branch']");
        By AddCharer = By.CssSelector("button[title='Add Charter/Branding']");
        By AddContacts = By.CssSelector("button[title='Contacts Lookup']");
        By AddTransactionDeclineReason = By.CssSelector("button[title='Transaction Decline Reason']");
        By AddBatchReporting = By.CssSelector("button[title='Batch Reporting Reference']");
       
        By DisputeStatus = By.XPath("//input[@ng-model='newlv.description']");
        By BreachSource = By.CssSelector("input[name='description']"); 
        By AccountType = By.CssSelector("input[name='description']");
        By DisplayName = By.CssSelector(".ng-scope > input[name='description']");
        By DisputeDetail = By.CssSelector("input[name='description']");
        By Branch = By.CssSelector(".form-control.ng-invalid-required");
        By Charter = By.CssSelector("");
        By ContactLookup = By.CssSelector("");
        By Reference = By.CssSelector("");
        By TransactionDeclineReason = By.CssSelector("");
        By BatchReportingReference = By.CssSelector("");
    }
}
