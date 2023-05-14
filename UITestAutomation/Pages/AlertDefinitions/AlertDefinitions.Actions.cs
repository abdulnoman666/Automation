using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestAutomation
{
    internal partial class AlertDefinitions : Selenium_Methods
    {
        public void ClickAlertDefinitionsButton()
        {
            WaitForWebElementDisplayed(AlertDefinitionButton);
            ClickOnWebElement(AlertDefinitionButton);
        }

        public void ClickAddAlertDefinitionButton()
        {
            WaitForWebElementDisplayed(AddAlertDefinitions_Button);
            ClickOnWebElement(AddAlertDefinitions_Button);
        }
    }
}
