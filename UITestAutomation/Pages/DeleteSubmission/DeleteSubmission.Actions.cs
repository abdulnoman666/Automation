
namespace UITestAutomation
{
    internal partial class DeleteSubmission : Selenium_Methods
    {
        public void ClickDeleteSubmission()
        {
            ClickTheWebElement(DeleteSubmission_Dropdown);
            WaitForWebElementDisplayed(Delete_Button);
        }
    }
}
