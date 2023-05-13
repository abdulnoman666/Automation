using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestAutomation.Pages.DeleteSubmission
{
    internal partial class DeleteSubmission : Selenium_Methods
    {
        public void ClickDeleteSubmission()
        {
            ClickTheWebElement(DeleteSubmission_Dropdown);
            WaitForWebElementDisplayed(Delete_Button);
        }
    }
}
