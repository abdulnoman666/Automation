using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class AuditorLog
    {
        By AuditorLogButton = By.XPath("//a[text='Auditor Log']");
        By ShowClosedSubButton = By.XPath("//input[@ng-model='showClosed']");
        By EditDispute = By.XPath("//button[@ng-click='disputeDocs($event, dispute.id)']");
        By ViewSubmission = By.XPath("//button[@ng-click='customerDispute($event, dispute.batchNumber);']");
        By Links = By.XPath("(//th[1])");
        By Reported = By.XPath("(//th[2])");
        By PC = By.XPath("(//th[3])");
        By NS = By.XPath("(//th[4])");
        By RS = By.XPath("(//th[5])");
        By Status = By.XPath("(//th[6])");
        By Resolution = By.XPath("(//th[7])");
        By Amount = By.XPath("(//th[8])");
        By Type = By.XPath("(//th[9])");
        By Customer = By.XPath("(//th[10])");
    }
}
