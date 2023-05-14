using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestAutomation
{
    internal partial class AlertDefinitions
    {
        By AlertDefinitionButton = By.LinkText("Alert Definitions");
        By AddAlertDefinitions_Button = By.CssSelector("button[title='Add Alert Definition']");
        By DeleteAlertDefinitions_Button = By.CssSelector("tr:nth-of-type(1) button[title='Delete Alert Definition']");
        By EditAlertDefinition_Button = By.CssSelector("tr:nth-of-type(1) button[title='Edit Alert Definition']");
        By CopyAlertDefinition_Button = By.CssSelector("tr:nth-of-type(1) button[title='Copy Alert Definition']");
        By CreateAlertDefinitons_Button = By.CssSelector("[ng-click='createDefaultDefinitions\\(\\)']");
        By DownloadFromLibrary_Button = By.CssSelector("button[title='Download alert']");

        // Add Definition Dialog
        By DefinitionName_Field = By.XPath(".ng-invalid-required .ng-scope:nth-child(2) input");
        By AlertType_Field = By.XPath("div:nth-of-type(2) > select[name='delimiter']");
        By TableName_Field = By.CssSelector("div:nth-of-type(1) > div:nth-of-type(3) > select[name='delimiter']");
        By DeadlineRefrence_Field = By.CssSelector("div:nth-of-type(4) > input[name='deadlineReference']");
        By BusinessDays_CheckBox = By.CssSelector("[class='col-md-4'] .ng-valid-parse");
        By CalculateTheLastBusinessDay_CheckBox = By.CssSelector("[class='col-md-4'] .ng-valid-parse");
        By Days_Field = By.CssSelector("div:nth-of-type(6) > input[name='deadlineReference']");
        By Reference_Field = By.CssSelector("input[name='reference']");
        By SourceList_Field = By.CssSelector("form[name='configform']  .modal-body  .tab-content > div:nth-of-type(1)  input[name='sourceList']");
        By Save_Button = By.CssSelector("form[name='configform'] .btn.btn-info");
        By Close_Button = By.CssSelector("form[name='configform'] .btn.btn-default");
        //Explanation page
        By Explanation_Form = By.CssSelector(".ng-invalid-required [heading='Explanation'] .ng-binding");




    }
}
