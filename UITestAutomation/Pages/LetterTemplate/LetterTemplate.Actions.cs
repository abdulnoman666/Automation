using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestAutomation
{
    internal partial class LetterTemplate : Selenium_Methods
    {
        public void ClickOnLetterTemplateButton()
        {
            WaitForWebElementDisplayed(LettterTemplateOption);
            ClickOnWebElement(LettterTemplateOption);

        }
        public void ClickOnAddLetterTemplateButton()
        {
            WaitForWebElementDisplayed(AddLetterTemplate);
            ClickOnWebElement(AddLetterTemplate);
        }
    }
}
