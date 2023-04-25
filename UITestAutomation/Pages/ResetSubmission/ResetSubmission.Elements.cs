using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestAutomation.Pages.ResetSubmission
{
    internal partial class ResetSubmission
    {
        By ResetSubmission_Dropdown = By.XPath("//a[@href='#/reversepc']");
        By Submission_ID = By.CssSelector("form[name='resetSubmissionForm'] > input[name='disputeid']");
        By Reset_Button = By.CssSelector(".btn-danger");
    }
}
