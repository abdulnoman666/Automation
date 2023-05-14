using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestAutomation
{
    internal partial class QuestionnaireDependencySetup : Selenium_Methods
    {
        public void ClickQuestionnaireDependencySetupButton()
        {
            WaitForWebElementDisplayed(QuestionnaireDependencySetupOption);
            ClickOnWebElement(QuestionnaireDependencySetupOption);
        }

        public void AddFormDependancyListButton()
        {
            WaitForWebElementDisplayed(AddFormDependancyList);
            ClickOnWebElement(AddFormDependancyList);
        }
    }
}
