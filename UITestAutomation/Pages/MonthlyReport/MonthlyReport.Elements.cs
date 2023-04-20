using OpenQA.Selenium;
namespace UITestAutomation.Pages.MonthlyReport
{
    internal partial class MonthlyReport
    {
        //UI Controls on Monthly Disputes Report Page
        By MonthlyReportOption = By.LinkText("Monthly Report");
        By ReportedOn  = By.XPath("//select[@ng-model='searchField']");
        By DateRange = By.XPath("//select[@ng-model='dateRange']");
        By Workflows = By.XPath("//select[@ng-model='source']");
        By CalendarButton = By.CssSelector(".panel-body .fi-field:nth-of-type(1) ._md-datepicker-has-triangle-icon > [type]");
        By TraingleOption = By.CssSelector(".panel-body .fi-field:nth-of-type(1) .md-datepicker-expand-triangle");
        By PrintReport = By.CssSelector("button[title='Print Letter']");
        By SummaryButton = By.CssSelector(".col-lg-12 > button:nth-of-type(1)");
        By Charts = By.CssSelector(".col-lg-12 > button:nth-of-type(2)");
        By ListButton = By.CssSelector(".col-lg-12 > button:nth-of-type(3)");
        By ExportDisputes = By.CssSelector(".col-lg-12 > button:nth-of-type(4)");

        //Fields on Summary Page
        By SubmissionCount  = By.CssSelector("tr:nth-of-type(1) > td:nth-of-type(1)");
        By TotalClaimed  = By.CssSelector("tr:nth-of-type(2) > td:nth-of-type(1)");
        By TotalDisputed = By.CssSelector("tr:nth-of-type(3) > td:nth-of-type(1)");
        By BankLoss = By.CssSelector("tr:nth-of-type(4) > td:nth-of-type(1)");
        By MerchantLoss = By.CssSelector("tr:nth-of-type(6) > td:nth-of-type(1)");
        By ConsumerLoss = By.CssSelector("tr:nth-of-type(7) > td:nth-of-type(1)");
        By Recovered = By.CssSelector("tr:nth-of-type(8) > td:nth-of-type(1)");
        By ProvisionalCredit = By.CssSelector("tr:nth-of-type(9) > td:nth-of-type(1)");
        By Export = By.CssSelector(".layout-row > button:nth-of-type(1)");
        By Close = By.CssSelector(".layout-row > button:nth-of-type(2)");

        //Fields on Lists Page
        By Reported = By.CssSelector("th:nth-of-type(1) > a");
        By Days = By.CssSelector("tr > th:nth-of-type(2)");
        By PC = By.CssSelector("th:nth-of-type(3) > a");
        By RS = By.CssSelector("th:nth-of-type(4) > a");
        By CA = By.CssSelector("th:nth-of-type(5) > a");
        By Status = By.CssSelector("th:nth-of-type(6) > a");
        By Detail = By.CssSelector("th:nth-of-type(7) > a");
        By Resolution = By.CssSelector("th:nth-of-type(8) > a");
        By Amount = By.CssSelector("th:nth-of-type(9) > a");
        By Recovered2 = By.CssSelector("th:nth-of-type(10) > a");
        By Type = By.CssSelector("th:nth-of-type(11) > a");
        By Customer = By.CssSelector("th:nth-of-type(12) > a");
        By AssignedTo = By.CssSelector("th:nth-of-type(13) > a");
        By Close2 = By.CssSelector(".layout-row [type]");
    }
}

