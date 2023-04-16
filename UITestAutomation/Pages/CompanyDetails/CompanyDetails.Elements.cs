using OpenQA.Selenium;
namespace UITestAutomation.Pages.CompanyDetails
{
    internal partial class CompanyDetails
    {
        //UI Controls on Company Details Page
        By CompanyDetailsOption = By.LinkText("Company Details");
        By BasicInfo = By.LinkText("Basic Info");
        By GeneralSettings = By.LinkText("General Settings");
        By LookupValues = By.LinkText("Lookup Values");
        By Style = By.CssSelector(".nav.nav-tabs > li:nth-of-type(4) > a");
        By Save = By.CssSelector(".ng-scope > div:nth-of-type(3) .btn.btn-default");

        //Fields of Basic Info
        By CompanyName = By.CssSelector("input[name='companyName']");
        By Address = By.CssSelector("input[name='address']");
        By City = By.CssSelector("input[name='city']");
        By State = By.CssSelector("input[name='state']");
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
    }
}
