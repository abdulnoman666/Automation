using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestAutomation
{
    internal partial class ErrorLogs : Selenium_Methods
    {
        public void ClickErrorLogsButton()
        {
            WaitForWebElementDisplayed(ErrorLogsOption);
            ClickOnWebElement(ErrorLogsOption);
        }
        public void ClickSearchandsetdateRangeButton()
        {
            WaitForWebElementDisplayed(SearchandsetdateRange_Button);
            ClickOnWebElement(SearchandsetdateRange_Button);
        }

        }
    }
}
