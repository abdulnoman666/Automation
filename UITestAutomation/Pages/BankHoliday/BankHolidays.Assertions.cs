
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

