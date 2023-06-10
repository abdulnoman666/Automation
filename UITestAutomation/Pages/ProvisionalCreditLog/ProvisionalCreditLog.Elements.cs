using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class ProvisionalCreditLog
    {
        By ProvisionalCreditLogBtn = By.LinkText("Provisional Credit Log");
        By RefreshSubmissions = By.CssSelector("button[title='Refresh Submissions']");
        By Links = By.CssSelector("tr > th:nth-of-type(1)");
        By Reported = By.CssSelector("th:nth-of-type(2) > a");
        By PCDate = By.CssSelector("th:nth-of-type(3) > a");
        By PCAmount = By.CssSelector("th:nth-of-type(4) > a");
        By CLAmount = By.CssSelector("th:nth-of-type(5) > a");
        By DenialReason = By.CssSelector("th:nth-of-type(6) > a");
        By Status = By.CssSelector("th:nth-of-type(7) > a");
        By Resolution = By.CssSelector("th:nth-of-type(8) > a");
        By Amount = By.CssSelector("th:nth-of-type(9) > a");
        By Type = By.CssSelector("th:nth-of-type(10) > a");
        By Customer = By.CssSelector("th:nth-of-type(11) > a");
        By ViewSubmission = By.CssSelector("button[title='View Submission']");
        By EditDisputeResearch = By.CssSelector("tr:nth-of-type(1)  span[role='button']");
    }
}
