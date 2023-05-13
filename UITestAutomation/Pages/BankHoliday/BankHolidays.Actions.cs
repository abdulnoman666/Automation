using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
