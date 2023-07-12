
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

        public void ClickCloseButtononAddFormDependancyList()
        {
            WaitForWebElementDisplayed(CloseButton);
            ClickOnWebElement(CloseButton);
        }
    }
}
