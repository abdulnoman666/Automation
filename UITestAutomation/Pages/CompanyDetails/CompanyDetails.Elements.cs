using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class CompanyDetails
    {
        //UI Controls on Company Details Page
        By CompanyDetailsOption = By.XPath("//a[@href=\"#/editcompany\"]");
        By BasicInfo = By.XPath("//li/a[text()=\"Basic Info\"]");
        By GeneralSettings = By.XPath("//li/a[text()=\"General Settings\"]");
        By LookupValues = By.XPath("//li/a[text()=\"Lookup Values\"]");
        By Style = By.XPath("//li/a[text()=\"Style\"]");
        By Save = By.XPath("//button[@ng-click='updateCompany()']");

        //Fields of Basic Info
        By CompanyName = By.XPath("//input[@ng-model='company.companyName']");
        By Address = By.XPath("//input[@ng-model='company.address']");
        By City = By.XPath("//input[@ng-model='company.city']");
        By State = By.XPath("//input[@ng-model='company.state']");
        By Zip = By.XPath("//input[@ng-model='company.zip']");
        By Phone = By.XPath("//input[@ng-model='company.phone']");
        By Email = By.XPath("//input[@ng-model='company.email']");
        By ResponseEmail = By.XPath("//input[@ng-model='company.responseEmail']");
        By EmailList = By.XPath("//input[@ng-model='company.emailDistributionList']");
        By Time = By.XPath("//select[@ng-model='company.timeZone']");
        By Questionnaires = By.XPath("//select[@ng-model='company.customerAppReadOnly']");

        //Fields of General Settings
        By SignaturePad = By.XPath("//select[@ng-model='company.signaturePad']");
        By Timeout = By.XPath("//input[@ng-model='company.idleTime']");
        By StatementCycle = By.XPath("//input[@ng-model='company.defaultMEStatement']");
        By SelectFileOption = By.XPath("//div[@ng-model='file']");


        //UI Controls on Lookup Values Page
        By CrossButton = By.XPath("//button[class='close'][2]");
        By AddSubmissionStatus = By.XPath("//button[@ng-click='AddSubmissionStatus()']");
        By EditSubmissionStatus = By.XPath("//button[@ng-click='editLV(lvss)'][1]");
        By DeleteSubmissionStatus = By.XPath("//button[@ng-click='removeLV(lvss)'][1]");

        By AddSource = By.XPath("//button[@ng-click='AddThirdPartyBreach()']");
        By EditSource = By.XPath("//button[@ng-click='editLV(lv)'][1]");
        By DeleteSource = By.XPath("//button[@ng-click='removeLV(lv)'][1]");

        By AddAccountType = By.XPath("//button[@ng-click='AddAccountType()']");
        By EditAccountType = By.XPath("//button[@ng-click='editLV(lv)'][3]");
        By DeleteAccountType = By.XPath("//button[@ng-click='removeLV(lv)'][3]");

        By AddDisputeDetail = By.XPath("button[title='Add Dispute Research Detail']");
        By EditDisputeDetail = By.XPath("//button[@ng-click='editLV(lv)'][6]");
        By DeleteDisputeDetail = By.XPath("//button[@ng-click='removeLV(lv)'][6]");

        By AddBranch = By.XPath("button[title='Add Branch']");
        By EditBranch = By.XPath("//button[@ng-click='editLV(lv)'][9]");
        By DeleteBranch = By.XPath("//button[@ng-click='removeLV(lv)'][9]");

        By AddCharter = By.XPath("button[title='Add Charter/Branding']");
        By EditCharter = By.XPath("//button[@ng-click='editLV(lv)'][11]");
        By DeleteCharter = By.XPath("button[title='Delete Charter/Branding']");

        By AddContactsLookup = By.XPath("//button[@ng-click='AddContactLookup()']");
        By EditContactsLookup = By.XPath("//button[@ng-click='editLV(lv)'][12]");
        By DeleteContactsLookup = By.XPath("//button[@ng-click='removeLV(lv)'][12]");

        By AddTransactionDeclineReason = By.XPath("//button[@ng-click='AddTransactionDeclineReason()']");
        By EditTransactionDeclineReason = By.XPath("//button[@ng-click='editLV(lv)'][14]");
        By DeleteTransactionDeclineReason = By.XPath("//button[@ng-click='removeLV(lv)'][14]");

        By AddBatchReportingReference = By.XPath("//button[@ng-click='AddBatchReportingReference()']");
        By EditBatchReportingReference = By.XPath("//button[@ng-click='editLV(lv)'][21]");
        By DeleteBatchReportingReference = By.XPath("//button[@ng-click='removeLV(lv)'][21]");

        //Fields on Add Pages(the path is same for all)
        By AddSubmission_Button = By.XPath("//button[@ng-click=\"AddSubmissionStatus()\"]");
        By TextArea = By.XPath("//input[@ng-model='newlv.description']");
        By SaveButton = By.XPath("//button[@ng-click='saveLookupValue()']");
        By CloseButton = By.XPath("(//button[text()=\"Close\"])[1]");

        // Fields on Style
        By Primary = By.XPath("(//input[@ng-model='AngularColorPickerController.internalNgModel'])[1]");
        By Secondary = By.XPath("(//input[@ng-model='AngularColorPickerController.internalNgModel'])[2]");
        By PrimaryFont = By.XPath("(//input[@ng-model='AngularColorPickerController.internalNgModel'])[3]");
        By SecondaryFont = By.XPath("(//input[@ng-model='AngularColorPickerController.internalNgModel'])[4]");
    }
}
