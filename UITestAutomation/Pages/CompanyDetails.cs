﻿using OpenQA.Selenium;
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
        By CompanyDetailsOption = By.LinkText("Company Details");
        By BasicInfo = By.LinkText("Basic Info");
        By GeneralSettings = By.LinkText("General Settings");
        By LookupValues = By.LinkText("Lookup Values");
        By Style = By.LinkText("Style");
        By Save = By.CssSelector(".ng-scope > div:nth-of-type(3) .btn.btn-default");
        
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
        By Time = By.XPath("//select[@ng-model='company.timeZone']");
        By Questionnaires = By.XPath("//select[@ng-model='company.customerAppReadOnly']");

        //Fields of General Settings
        By SignaturePad = By.XPath("//select[@ng-model='company.signaturePad']");
        By Timeout = By.XPath("//input[@ng-model='company.idleTime']");
        By StatementCycle = By.CssSelector("div:nth-of-type(4) .col-lg-4 > div:nth-of-type(1) > label");
        By SelectFileOption = By.CssSelector("[ng-show] [ng-model='file']");


        //UI Controls on Lookup Values Page
        By CrossButton = By.CssSelector("#main .modal-header [data-dismiss]");
        By AddSubmissionStatus = By.CssSelector("button[title='Add Submission Status']");
        By EditSubmissionStatus = By.CssSelector("button[title='Edit Submission Status']");
        By DeleteSubmissionStatus = By.CssSelector("button[title='Delete Submission Status']");

        By AddSource = By.CssSelector("button[title='Add Source']");
        By EditSource = By.CssSelector("button[title='Edit Source']");
        By DeleteSource = By.CssSelector("button[title='Delete Source']");

        By AddAccountType = By.CssSelector("button[title='Add Account Type']");
        By EditAccountType = By.CssSelector("button[title='Edit Account Type']");
        By DeleteAccountType = By.CssSelector("button[title='Delete Account Type']");

        By AddDisputeDetail = By.CssSelector("button[title='Add Dispute Research Detail']");
        By EditDisputeDetail = By.CssSelector("button[title='Edit Dispute Research Detail']");
        By DeleteDisputeDetail = By.CssSelector("button[title='Delete Dispute Research Detail']");

        By AddBranch = By.CssSelector("button[title='Add Branch']");
        By EditBranch = By.CssSelector("button[title='Edit Branch']");
        By DeleteBranch = By.CssSelector("button[title='Delete Branch']");

        By AddCharter = By.CssSelector("button[title='Add Charter/Branding']");
        By EditCharter = By.CssSelector("button[title='Edit Charter/Branding']");
        By DeleteCharter = By.CssSelector("button[title='Delete Charter/Branding']");

        By AddContactsLookup = By.CssSelector("button[title='Contacts Lookup']");
        //By EditContactLookup = By.CssSelector("");//code not found
        //By DeleteContactLookup = By.CssSelector("");//code not found

        By AddTransactionDeclineReason = By.CssSelector("button[title='Transaction Decline Reason']");
        By EditTransactionDeclineReason = By.CssSelector("button[title='Edit Transaction Decline Reason']");
        By DeleteTransactionDeclineReason = By.CssSelector("button[title='Delete Transaction Decline Reason']");

        By AddBatchReportingReference = By.CssSelector("button[title='Batch Reporting Reference']");
        By EditBatchReportingReference = By.CssSelector("button[title='Edit Batch Reporting Reference']");
        By DeleteBatchReportingReference = By.CssSelector("button[title='Delete Batch Reporting Reference']");

        //Fields on Add Pages(the path is same for all)
        By TextArea = By.CssSelector("input[name='description']");
        By SaveButton = By.XPath("//button[@ng-click='saveLookupValue()']");
        By CloseButton = By.CssSelector(".modal-dialog .btn.btn-default");


        // Fields on Style
        By Primary = By.CssSelector("[ng-show] .fi-field:nth-child(2) .color-picker-input-swatch");
        By Secondary = By.CssSelector("[ng-show] .fi-field:nth-child(3) .color-picker-input-swatch");
        By PrimaryFont = By.XPath("//input[@ng-model='AngularColorPickerController.internalNgModel']");
        By SecondaryFont = By.CssSelector("[ng-show] .fi-field:nth-child(5) .color-picker-input-swatch");

        public void ClickCompanyDetailsOption()
        {
            WaitForWebElementDisplayed(CompanyDetailsOption);
            ClickOnWebElement(CompanyDetailsOption);
        }

        public void AssertUIControlsOnCompanyDetailsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Basic Info":
                        FluentWaitForWebElement(BasicInfo);
                        break;
                    case " General Settings":
                        FluentWaitForWebElement(GeneralSettings);
                        break;
                    case " Lookup Values":
                        FluentWaitForWebElement(LookupValues);
                        break;
                    case " Style":
                        FluentWaitForWebElement(Style);
                        break;
                    case " Save":
                        FluentWaitForWebElement(Save);
                        break;
                }
            }
        }

        public void ClickBasicInfoButtonn()
        {
            WaitForWebElementDisplayed(BasicInfo);
            ClickOnWebElement(BasicInfo);
        }

        public void AssertFieldsonBasicInfoPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Company Name ":
                        FluentWaitForWebElement(CompanyName);
                        break;
                    case "Address":
                        FluentWaitForWebElement(Address);
                        break;
                    case "City":
                        FluentWaitForWebElement(City);
                        break;
                    case "State":
                        FluentWaitForWebElement(State);
                        break;
                    case "Zip":
                        FluentWaitForWebElement(Zip);
                        break;
                    case "Phone":
                        FluentWaitForWebElement(Phone);
                        break;
                    case "E Mail":
                        FluentWaitForWebElement(Email);
                        break;
                    case "Response Email":
                        FluentWaitForWebElement(ResponseEmail);
                        break;
                    case "Email Distribution List":
                        FluentWaitForWebElement(EmailList);
                        break;
                    case "Time Zone":
                        FluentWaitForWebElement(Time);
                        break;
                    case "Read only Questionnaires":
                        FluentWaitForWebElement(Questionnaires);
                        break;
                }
            }
        }
        public void ClickGeneralSettingsButtonn()
        {
            WaitForWebElementDisplayed(GeneralSettings);
            ClickOnWebElement(GeneralSettings);
        }

        public void AssertFieldsonGeneralSettingsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Signature Pad":
                        FluentWaitForWebElement(SignaturePad);
                        break;
                    case "Enter max idle time in minutes":
                        FluentWaitForWebElement(Timeout);
                        break;
                    case "Statement Cycle":
                        FluentWaitForWebElement(StatementCycle);
                        break;
                    case "Select Logo File":
                        FluentWaitForWebElement(SelectFileOption);
                        break;
                }
            }
        }

        public void ClickLookupValuesButtonn()
        {
            WaitForWebElementDisplayed(LookupValues);
            ClickOnWebElement(LookupValues);
        }

        public void AssertUIControlsOnLookupValuesPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Cross Button":
                        FluentWaitForWebElement(CrossButton);
                        break;
                    case " Add Submission Status":
                        FluentWaitForWebElement(AddSubmissionStatus);
                        break;
                    case " Edit Submission Status":
                        FluentWaitForWebElement(EditSubmissionStatus);
                        break;
                    case " Delete Submission Status":
                        FluentWaitForWebElement(DeleteSubmissionStatus);
                        break;
                    case " Add Source":
                        FluentWaitForWebElement(AddSource);
                        break;
                    case " Edit Source":
                        FluentWaitForWebElement(EditSource);
                        break;
                    case " Delete Source":
                        FluentWaitForWebElement(DeleteSource);
                        break;
                    case " Add Account Type":
                        FluentWaitForWebElement(AddAccountType);
                        break;
                    case " Edit Account Type":
                        FluentWaitForWebElement(EditAccountType);
                        break;
                    case " Delete Account Type":
                        FluentWaitForWebElement(DeleteAccountType);
                        break;
                    case " Add Dispute Research Detail":
                        FluentWaitForWebElement(AddDisputeDetail);
                        break;
                    case " Edit Dispute Research Detail":
                        FluentWaitForWebElement(EditDisputeDetail);
                        break;
                    case " Delete Dispute Research Detail":
                        FluentWaitForWebElement(DeleteDisputeDetail);
                        break;
                    case " Add Branch":
                        FluentWaitForWebElement(AddBranch);
                        break;
                    case " Edit Branch":
                        FluentWaitForWebElement(EditBranch);
                        break;
                    case " Delete Branch":
                        FluentWaitForWebElement(DeleteBranch);
                        break;
                    case " Add Charter/Branding":
                        FluentWaitForWebElement(AddCharter);
                        break;
                    case " Edit Charter/Branding":
                        FluentWaitForWebElement(EditCharter);
                        break;
                    case " Delete Charter/Branding":
                        FluentWaitForWebElement(DeleteCharter);
                        break;
                    case " Transaction Decline Reason":
                        FluentWaitForWebElement(AddTransactionDeclineReason);
                        break;
                    case " Edit Transaction Decline Reason":
                        FluentWaitForWebElement(EditTransactionDeclineReason);
                        break;
                    case " Delete Transaction Decline Reason":
                        FluentWaitForWebElement(DeleteTransactionDeclineReason);
                        break;
                    case " Batch Reporting Reference":
                        FluentWaitForWebElement(AddBatchReportingReference);
                        break;
                    case " Edit Batch Reporting Reference":
                        FluentWaitForWebElement(EditBatchReportingReference);
                        break;
                    case " Delete Batch Reporting Reference":
                        FluentWaitForWebElement(DeleteBatchReportingReference);
                        break;
                }
            }
        }


        public void AssertFieldsonAddPagesofLookupValuesPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Text Area":
                        FluentWaitForWebElement(TextArea);
                        break;
                    case "Save":
                        FluentWaitForWebElement(SaveButton);
                        break;
                    case "Close":
                        FluentWaitForWebElement(CloseButton);
                        break;
                }
            }
        }

      public void ClickStyleButtonn()
        {
            WaitForWebElementDisplayed(Style);
            ClickOnWebElement(Style);
        }
        public void AssertUIControlsonStylePage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Primary Buttons Color":
                        FluentWaitForWebElement(Primary);
                        break;
                    case "Secondary Buttons Color":
                        FluentWaitForWebElement(Secondary);
                        break;
                    case "Primary Buttons Font Color":
                        FluentWaitForWebElement(PrimaryFont);
                        break;
                    case "Secondary Buttons Font Color":
                        FluentWaitForWebElement(SecondaryFont);
                        break;
                }
            }
        }
    }
}
