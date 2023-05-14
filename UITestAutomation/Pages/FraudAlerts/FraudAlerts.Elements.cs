using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class FraudAlerts
    {
        //UI Controls on Fraud Alerts Page
        By UploadAlertFileBtn = By.CssSelector(".panel-heading > div:nth-of-type(2) > .btn.btn-default");
        By SearchSetDateRangeBtn = By.CssSelector("button[title = 'Search and set date range']");
        By EnterAlertsBtn = By.CssSelector(".panel-heading > div:nth-of-type(3) > .btn.btn-default"); 
        By ShowSubmissions = By.CssSelector("button[title='Show Submissions']");
        By PrintLetter = By.CssSelector("button[title='Print Letter']");
        By DeleteCAMS = By.CssSelector("button[title='Delete CAMS Alert']");
        By Refresh = By.CssSelector(".btn.btn-info.glyphicon.glyphicon-refresh");
        By CardNumber = By.XPath("//input[@ng-model='$.cardNumber']");
        By UploadedOn = By.XPath("//input[@ng-model='$.reportedOn']");
        By CaseNumber = By.XPath("//input[@ng-model='$.caseNumber']");
        By Entity = By.XPath("//input[@ng-model='$.entityName']");
        By Website = By.XPath("//input[@ng-model='$.email']");
        By Status = By.XPath("//select[@ng-model='$.status']");

        // Fields on Upload Alerts Page
        By DefaultCaseNumber = By.CssSelector("#main [role='dialog']:nth-child(3) input");
        By SelectUploadFile = By.CssSelector("#main [ng-model='file']");
        By Close = By.CssSelector("#main [role='dialog']:nth-child(3) .modal-footer [data-dismiss]");

        // Fields on Enter Alerts Manually Page
        By DefaultCaseNumber2 = By.CssSelector("#main [role='dialog']:nth-child(4) input");
        By EnterCAMs = By.CssSelector("textarea");
        By Save = By.CssSelector("#main .modal-footer [data-dismiss='modal']:nth-of-type(2)");
        By Close2 = By.CssSelector("div#enterCAMS > .modal-dialog .btn.btn-default");

        // Fields on Search and set date range Page
        By StartDate = By.CssSelector("#main .ng-valid.ng-empty:nth-child(2) > [type]");
        By EndDate = By.CssSelector("#main .ng-valid.ng-empty:nth-child(5) > [type]");
        By StatusField = By.CssSelector(".form-control.mb-3.ng-empty.ng-pristine.ng-touched.ng-valid");
        By Search = By.CssSelector("#main form [data-dismiss]");

        // Fields on Show Submission Page
        By ReportedOn = By.CssSelector("#main [role] tr th:nth-of-type(1)");
        By Customer = By.CssSelector("#main [role] tr th:nth-of-type(2)");
        By Case = By.CssSelector("#main [role] tr th:nth-of-type(3)");
        By ThirdPartyBreach = By.CssSelector("#main [role] tr th:nth-of-type(4)");
        //By Save2 = By.CssSelector("#main .ng-scope:nth-of-type(13) [ng-click='saveCaseNumber\(s\)']");
        //By Close3 = By.CssSelector("");
    }
}
