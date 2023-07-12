using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class FraudAlerts
    {
        //UI Controls on Fraud Alerts Page
        By FraudAlertsButton = By.XPath("//a[@href=\"#/cams\"]");
        By EntermanuallyButton= By.XPath("(//button[@class='btn btn-default'])[2]");
        By UploadAlertFileBtn = By.XPath("(//button[@class='btn btn-default'])[1]");
        By SearchSetDateRangeBtn = By.XPath("//button[@title='Search and set date range']");
       // By EnterAlertsBtn = By.XPath("//button[class='btn btn-default'][3]");
        By ShowSubmissions = By.XPath("//button[@ng-click='showSubmissions(cams)']");
        By DeleteCAMS = By.XPath("//button[@ng-click='deleteCAMS(cams)']");
        By Refresh = By.XPath("//button[@ng-click='refreshCAMS()']");
        By ActionsField = By.XPath("//th[2][1]");
        By CardNumber = By.XPath("//input[@ng-model='$.cardNumber']");
        By UploadedOn = By.XPath("//input[@ng-model='$.reportedOn']");
        By CaseNumber = By.XPath("//input[@ng-model='$.caseNumber']");
        By Entity = By.XPath("//input[@ng-model='$.entityName']");
        By Website = By.XPath("//input[@ng-model='$.email']");
        By Status = By.XPath("//select[@ng-model='$.status']");

        // Fields on Upload Alerts Page
        By DefaultCaseNumber = By.XPath("//input[@ng-model='defaultcase'][1]");
        By SelectUploadFile = By.XPath("//button[@ng-model='file']");
        By Close_upload = By.XPath("(//button[@class='btn btn-default'])[3]");


        // Fields on Enter Alerts Manually Page

        By DefaultCaseNumber2 = By.XPath("//input[@ng-model='defaultcase'][1]");
        By EnterCAMs = By.XPath("//textarea[@ng-model='camsnumbers']");
        By Save = By.XPath("//button[@ng-click='uploadcams()']");
        By CloseManual = By.XPath("(//button[@class='btn btn-default'])[4]");

        // Fields on Search and set date range Page
        By StartDate = By.XPath("//button[@ng-click='ctrl.openCalendarPane($event)'][1]");
        By EndDate = By.XPath("//button[@ng-click='ctrl.openCalendarPane($event)'][2]");
        By StatusField = By.XPath("//select[@ng-model='searchFilter.status']");
        By Search = By.XPath("//button[@ng-click='searchCams()']");
        By CloseSearch = By.XPath("(//button[@class=\"close\"])[4]");

        // Fields on Show Submission Page
        By ReportedOn = By.XPath("//th[1][2]");
        By Customer = By.XPath("//th[2][2]");
        By Case = By.XPath("//th[3][2]");
        By ThirdPartyBreach = By.XPath("//th[4][2]");
        By CrossButton = By.XPath("//button[class='close'][4]");
        By Close3 = By.XPath("(//button[text()=\"Close\"])[3]");
    }
}
