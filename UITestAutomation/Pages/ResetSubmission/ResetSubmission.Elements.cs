using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class ResetSubmission
    {
        By ResetSubmission_Dropdown = By.XPath("//a[@href='#/reversepc']");
        By Submission_ID = By.CssSelector("form[name='resetSubmissionForm'] > input[name='disputeid']");
        By Reset_Button = By.CssSelector(".btn-danger");
    }
}
