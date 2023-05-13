using OpenQA.Selenium.DevTools.V108.Debugger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestAutomation  
{
    internal partial class BankHolidays
    {
        public void AssertUIControlsBankHolidayPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Add Holiday":
                        FluentWaitForWebElement(AddNewBankHolidays);
                        break;
                    case "Delete":
                        FluentWaitForWebElement(DeleteBankHolidays);
                        break;
                    case "Edit":
                        FluentWaitForWebElement(EditBankHolidays);
                        break;
                    case "Action":
                        FluentWaitForWebElement(Action);
                        break;
                    case "Refresh":
                        FluentWaitForWebElement(RefreshIcon);
                        break;
                }
            }
        }
        public void AssertFieldsonAddHolidayDialog(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Holidays":
                        FluentWaitForWebElement(AddHoliday);
                        break;
                    case "Close":
                        FluentWaitForWebElement(CloseButton);
                        break;
                    case "Save":
                        FluentWaitForWebElement(SaveButton);
                        break;
                }
            }

        }
    }
}

