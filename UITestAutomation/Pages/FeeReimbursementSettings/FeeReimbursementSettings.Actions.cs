
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
            WaitForWebElementDisplayed(Description_Field);
        
        }

        public void ClickCloseButtononAddReimbursement()
        {
            WaitForWebElementDisplayed(Close_Button);
            ClickOnWebElement(Close_Button);

        }
    }
}
