
namespace UITestAutomation
{
    internal partial class BankHolidays : Selenium_Methods
    {
        public void ClickBankHolidayButton()
        {
            WaitForWebElementDisplayed(Bankholiday_Button);
            ClickOnWebElement(Bankholiday_Button);
        }
        public void ClickAddHolidayButton()
        {
            ClickOnWebElement(AddNewBankHolidays);
            WaitForWebElementDisplayed(AddHoliday);
        }
        public void ClickCloseAddHolidayButton()
        {
            ClickOnWebElement(CloseButton);

        }
       
    }
}
