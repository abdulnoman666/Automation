using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestAutomation.Pages.ResetSubmission
{
    internal  partial class ResetSubmission
    {
        public void AssertFieldsonResetSubmissionPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Submission ID":
                        WaitForWebElementDisplayed(Submission_ID);
                        FluentWaitForWebElement(Submission_ID);
                        break;
                    case "Reset":
                        FluentWaitForWebElement(Reset_Button);
                        break;
                }
            }
        }
    }
}
