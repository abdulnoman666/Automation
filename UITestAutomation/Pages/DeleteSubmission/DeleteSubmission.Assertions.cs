using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestAutomation.Pages.DeleteSubmission
{
    internal partial class DeleteSubmission
    {
        public void AssertFieldsonDeleteSubmissionPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Submission ID":
                        WaitForWebElementDisplayed(SubmissionID_Delete);
                        FluentWaitForWebElement(SubmissionID_Delete);
                        break;
                    case "Delete":
                        FluentWaitForWebElement(Delete_Button);
                        break;
                }
            }
        }
    }
}
