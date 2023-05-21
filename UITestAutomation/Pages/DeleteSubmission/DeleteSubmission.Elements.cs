using OpenQA.Selenium;

namespace UITestAutomation { 
    internal partial class DeleteSubmission
    {
        By DeleteSubmission_Dropdown = By.XPath("//a[@href=\"#/deletesubmission\"]");
        By SubmissionID_Delete = By.XPath("//input[@ng-model=\"disputeid\"]");
        By Delete_Button = By.XPath("//button[@type=\"submit\"]");
       
    }
}
