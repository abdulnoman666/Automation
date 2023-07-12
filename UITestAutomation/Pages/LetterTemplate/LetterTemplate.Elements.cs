using OpenQA.Selenium;

namespace UITestAutomation
{
    internal partial class LetterTemplate : Selenium_Methods
    {
        //  UI Controls on Letter Template Page
        By LettterTemplateOption = By.XPath("//div[@id='myNavbar']/ul[@class='nav navbar-nav navbar-right']/li[12]/ul[@class='dropdown-menu']//a[@href='#/letters']");
        By AddLetterTemplate = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//button[@title='Add Letter Template']");
        By DeleteLettter = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//div[@class='panel-body']/table/tbody/tr[2]//button[@title='Delete Letter']");
        By EditLetter = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//div[@class='panel-body']/table/tbody/tr[2]//a[@title='Edit Letter']");
        By DownloadLetter = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//button[@title='Download Letter']");
        By CopyLetter = By.XPath("//button[@title='Copy Letter']");
        By Action = By.XPath("/html//div[@id='main']/div[@class='container']/div[@class='ng-scope']//div[@class='panel-body']/table/tbody/tr[1]/td[1]");
        By Refresh = By.XPath("/html//div[@id='main']/div[@class='container']/div[@class='ng-scope']//button[@title='Refresh']");
        By ID = By.XPath("/html//div[@id='main']/div[@class='container']/div[@class='ng-scope']//div[@class='panel-body']/table/tbody/tr[1]/td[2]/input[@type='text']");
        By Title = By.XPath("/html//div[@id='main']/div[@class='container']/div[@class='ng-scope']//div[@class='panel-body']/table/tbody/tr[1]/td[3]/input[@type='text']");
        By TableModule = By.XPath("/html//div[@id='main']/div[@class='container']/div[@class='ng-scope']//div[@class='panel-body']/table/tbody/tr[1]/td[4]/input[@type='text']");
        By Reference = By.XPath("/html//div[@id='main']/div[@class='container']/div[@class='ng-scope']//div[@class='panel-body']/table/tbody/tr[1]/td[6]/input[@type='text']");
        By EnterPage = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//ul[@class='pagination']/li[15]//input[@type='text']");
        // Letter info Dialog
        By Letterinfoicon = By.XPath("//a[@ng-click=\"tab=1\"]");
        By LetterTitle = By.XPath("/html//input[@id='title']");
        By LetterDescription = By.XPath("/html//input[@id='description']");
        By Author = By.XPath("/html//input[@id='author']");
        By FileNameToSaveLetter = By.XPath("/html//input[@id='fileName']");
        By SubjectlineWhenSendingLetterViaEmail = By.XPath("/html//input[@id='subject']");
        By TableName = By.XPath("/html//select[@id='tableName']");
        By ReferenceLetter = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/form[@name='lettertTemplateForm']/div[@class='container']//div[@class='col-lg-6']/div[7]/input[@id='subject']");
        By Workflows = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/form[@name='lettertTemplateForm']/div[@class='container']//div[@class='col-lg-6']/div[8]/input[@id='subject']");
        By SQLCommandName = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/form[@name='lettertTemplateForm']/div[@class='container']//div[@class='col-lg-6']/div[9]/input[@id='subject']");
        By IsInputForm = By.XPath("/html//select[@id='questionnaire']");
        By IsConsentNotice = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/form[@name='lettertTemplateForm']/div[@class='container']//div[@class='col-lg-6']/div[11]/select[@id='questionnaire']");
        By UseCutOffPrintDate = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/form[@name='lettertTemplateForm']/div[@class='container']//div[@class='col-lg-6']/div[12]/select[@id='questionnaire']");
        By EligibleforESignature = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/form[@name='lettertTemplateForm']/div[@class='container']//div[@class='col-lg-6']/div[13]/select[@id='questionnaire']");


        //Template Dialog
        By LetterTemplateForm = By.XPath("//div[@id='main']//div[@class='ng-scope']/form[@name='lettertTemplateForm']/div[@class='container']//div[@role='application']//div[@class='fr-element fr-view']");

        // Style Sheet Dialog
        By Stylesheeticon = By.XPath("//a[@ng-click=\"tab=3\"]");
        By StyleSheetTitle = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']/form[@name='lettertTemplateForm']/div[@class='container']//input[@id='title']");
        By StyleSheet = By.XPath("/html//textarea[@id='styleSheet']");
        By DeleteTemplateSheet = By.XPath("//div[@id='main']//div[@class='ng-scope']/form[@name='lettertTemplateForm']/div[@class='container']//button[@title='Delete Template']");
        By CopyTemplateSheet = By.XPath("//div[@id='main']//div[@class='ng-scope']/form[@name='lettertTemplateForm']/div[@class='container']//button[@title='Copy Template']");
        By SaveTemplateSheet = By.XPath("//div[@id='main']//div[@class='ng-scope']/form[@name='lettertTemplateForm']/div[@class='container']//button[@title='Save Template']");
        By CloseTemplateSheet = By.XPath("//div[@id='main']//div[@class='ng-scope']/form[@name='lettertTemplateForm']/div[@class='container']//button[@title='Cancel']");
    }
}
