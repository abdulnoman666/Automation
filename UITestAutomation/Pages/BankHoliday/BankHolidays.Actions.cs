
namespace UITestAutomation
{
    internal partial class BankHolidays:Selenium_Methods
    {
        public void ClickAddHolidayButton()
        {
            ClickOnWebElement(AddNewBankHolidays);
            WaitForWebElementDisplayed(AddHoliday);
        }
public void ClickCloseAddHolidayButton()
        {
            ClickOnWebElement(CloseButton);
     
        }
        public void ClickEditHolidayButton()
        {
            ClickOnWebElement(EditBankHolidays);
            WaitForWebElementDisplayed(AddHoliday);
        }
        public void ClickCloseButtonOnEditHolidayDialog()
        {
            ClickOnWebElement(CloseButton);
        }
    public void ClickDeleteHolidayButton()
        {
            ClickOnWebElement(DeleteBankHolidays);
        }
    }
}
