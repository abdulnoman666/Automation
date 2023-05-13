using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestAutomation.Pages.ResetSubmission
{
    internal partial class ResetSubmission :Selenium_Methods
    {
        public void ClickResetSubmission()
        {
            ClickTheWebElement(ResetSubmission_Dropdown);
            WaitForWebElementDisplayed(Reset_Button);
        }
    }
}
