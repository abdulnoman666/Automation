
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
