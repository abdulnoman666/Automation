using OpenQA.Selenium;

namespace UITestAutomation { 
    internal partial class DeleteSubmission
    {
        By DeleteSubmission_Dropdown = By.CssSelector(" li:nth-of-type(4) > .dropdown-menu > li:nth-of-type(7) > a");
        By SubmissionID_Delete = By.XPath("//form[@name='deletesubmissionform']/input[@name='disputeid']");
        By Delete_Button = By.CssSelector("form[name='deletesubmissionform'] > .btn.btn-danger");
       
    }
}
