using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestAutomation
{
    internal partial class FeeReimbursementSettings : Selenium_Methods
    {
        public void ClickFeeReimbursementSButton()

        {
            WaitForWebElementDisplayed(FeeReimbursementsOption);
            ClickOnWebElement(FeeReimbursementsOption);
        }
        public void ClickAddReimbursementSButton()
        {
            WaitForWebElementDisplayed(AddFeeReimbursementSettings_Button);
            ClickOnWebElement(AddFeeReimbursementSettings_Button);
        
        }
    }
}
