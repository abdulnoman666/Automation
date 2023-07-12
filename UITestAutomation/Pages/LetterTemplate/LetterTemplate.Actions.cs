
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
            WaitForWebElementDisplayed(SaveTemplateSheet);
        }

        public void ClickOnStyleinfoButton()
        {
            WaitForWebElementDisplayed(Stylesheeticon);
            ClickOnWebElement(Stylesheeticon);
        }

        public void ClickOnLetterinfoButton()
        {
            WaitForWebElementDisplayed(Letterinfoicon);
            ClickOnWebElement(Letterinfoicon);
        }
    }
}
