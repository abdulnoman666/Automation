
namespace UITestAutomation
{
    internal partial class ActivityHistory : Selenium_Methods
    {
        public void ClickActivityHistory()
        {
            ClickTheWebElement(ActivityHistory_Dropdown);
            WaitForWebElementDisplayed(Action_Field);
        }
    }
}
