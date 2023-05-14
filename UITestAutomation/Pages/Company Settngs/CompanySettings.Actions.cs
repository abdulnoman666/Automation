using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestAutomation
{
    internal partial class CompanySettings : Selenium_Methods
    {
        public void ClickOnCompanySettingsButton()
        {
            WaitForWebElementDisplayed(CompanySettingsOption);
            ClickOnWebElement(CompanySettingsOption);
        }

        public void ClickOnCompanySettingsSaveButton()
        {
            WaitForWebElementDisplayed(Save_Button);
            ClickOnWebElement(Save_Button);
        }
    }
}
