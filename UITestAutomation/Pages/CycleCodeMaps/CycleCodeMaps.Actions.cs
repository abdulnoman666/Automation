using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestAutomation
{
    internal partial class CycleCodeMaps :Selenium_Methods
    {
        public void ClickCycleCodeMapsButton()
        {
            WaitForWebElementDisplayed(CycleCodeMapsOption);
            ClickOnWebElement(CycleCodeMapsOption);

        }
        public void ClickAddCycleCodeMapsButton()
        {
            WaitForWebElementDisplayed(AddCycleCodeMaps_Button);
            ClickOnWebElement(AddCycleCodeMaps_Button);
        }
    }
}
