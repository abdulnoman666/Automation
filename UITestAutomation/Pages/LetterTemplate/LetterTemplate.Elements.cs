using FluentAssertions.Equivalency;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UITestAutomation
{
    internal partial class LetterTemplate : Selenium_Methods
    {
        //  UI Controls on Letter Template Page
        By LettterTemplateOption = By.LinkText("Letter Templates");
        By AddLetterTemplate = By.CssSelector("button[title='Add Letter Template']");
        By DeleteLettter = By.CssSelector("tr:nth-of-type(2)  button[title='Delete Letter']");
        By EditLetter = By.CssSelector("tr:nth-of-type(2)  a[title='Edit Letter']");
        By DownloadLetter = By.CssSelector("button[title='Download Letter']");
        By CopyLetter = By.CssSelector("tr:nth-of-type(2)  button[title='Copy Letter']");
        By Action = By.CssSelector(".panel-body tr [width='120px']:nth-of-type(1)");
        By Refresh = By.CssSelector("button[title='Refresh']");
        By ID = By.CssSelector("[ng-model='\\$\\.id']");
        By Title = By.CssSelector("[ng-model='\\$\\.title']");
        By TableModule = By.CssSelector("[ng-model='\\$\\.tableName']");
        By Reference = By.CssSelector("[ng-model='\\$\\.reference']");
        By EnterPage = By.CssSelector("[ng-hide] span .ng-untouched");
        // Letter info Dialog
        By LetterTitle = By.CssSelector(".form-control.ng-invalid-required");
        By LetterDescription = By.CssSelector("input#description");
        By Author = By.CssSelector("input#author");
        By FileNameToSaveLetter = By.CssSelector("input#fileName");
        By SubjectlineWhenSendingLetterViaEmail = By.CssSelector("[ng-show] .fi-field:nth-of-type(5) .ng-untouched");
        By TableName = By.CssSelector("select#tableName");
        By ReferenceLetter = By.CssSelector("[ng-show] .fi-field:nth-of-type(7) .ng-untouched");
        By Workflows = By.CssSelector("[ng-show] .fi-field:nth-of-type(8) .ng-untouched");
        By SQLCommandName = By.CssSelector("[ng-show] .fi-field:nth-of-type(9) .ng-untouched");
        By IsInputForm = By.CssSelector("select#questionnaire");
        By IsConsentNotice = By.CssSelector("div:nth-of-type(11) > select#questionnaire");
        By UseCutOffPrintDate = By.CssSelector("div:nth-of-type(12) > select#questionnaire");
        By EligibleforESignature = By.CssSelector("div:nth-of-type(13) > select#questionnaire");


        //Template Dialog
        By LetterTemplateForm = By.CssSelector(".form-group [dir] [dir]");

        // Style Sheet Dialog

        By StyleSheetTitle = By.CssSelector(".ng-valid.ng-touched");
        By StyleSheet = By.CssSelector(".ng-valid.ng-touched");
        By DeleteTemplateSheet = By.CssSelector("[ng-show='tab\\=\\=3'] [ng-click='delete\\(\\)']");
        By CopyTemplateSheet = By.CssSelector("[ng-show='tab\\=\\=3'] [ng-click='copy\\(\\)']");
        By SaveTemplateSheet = By.CssSelector("[ng-show='tab\\=\\=3'] [ng-click='save\\(\\)']");
        By CloseTemplateSheet = By.CssSelector("[ng-show='tab\\=\\=3'] [ng-click='cancel\\(\\)']");
    }
}
