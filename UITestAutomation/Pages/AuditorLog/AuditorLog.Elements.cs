using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class AuditorLog
    {
        By AuditorLogButton = By.LinkText("Auditor Log");
        By ShowClosedSubButton = By.CssSelector(".pagination  span");
        By EditDispute = By.CssSelector("button[title='Edit Dispute']");
        By ViewSubmission = By.CssSelector("button[title='View Submission']");
        By Links = By.CssSelector("tr > th:nth-of-type(1)");
        By Reported = By.CssSelector("th:nth-of-type(2) > a");
        By PC = By.CssSelector("th:nth-of-type(3) > a");
        By NS = By.CssSelector("th:nth-of-type(4) > a");
        By RS = By.CssSelector("th:nth-of-type(5) > a");
        By Resolution = By.CssSelector("th:nth-of-type(7) > a");
        By Amount = By.CssSelector("th:nth-of-type(8) > a");
        By Type = By.CssSelector("th:nth-of-type(9) > a");
        By Customer = By.CssSelector("tr > th:nth-of-type(10)");
    }
}
