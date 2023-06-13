using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class ResetSubmission
    {
        By ResetSubmission_Dropdown = By.XPath("//a[@href='#/reversepc']");
        By Submission_ID = By.XPath("//input[@ng-model=\"disputeid\"]");
        By Reset_Button = By.XPath("//button[@type=\"submit\"]");
    }
}
