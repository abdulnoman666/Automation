
namespace UITestAutomation
{
    internal partial class ErrorLogs
    {
        public void AssertFieldsonErrorLogsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Search and set date Range":
                        WaitForWebElementDisplayed(SearchandsetdateRange_Button);
                        FluentWaitForWebElement(SearchandsetdateRange_Button);
                        break;
                    case "CreatedOn":
                        FluentWaitForWebElement(CreatedOn_Field);
                        break;
                    case "ErrorMessage":
                        FluentWaitForWebElement(ErrorMessage_Field);
                        break;
                    case "URL":
                        FluentWaitForWebElement(URL_Field);
                        break;
                    case "Start Date":
                        FluentWaitForWebElement(StartDate_Button);
                        break;
                    case "End Date":
                        FluentWaitForWebElement(EndDate_Button);
                        break;
                    case "Close":
                        FluentWaitForWebElement(Close_Button);
                        break;
                }
            }
        }

        public void AssertFieldsonSearchPopupPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Start Date":
                        WaitForWebElementDisplayed(StartDate_Button);
                        FluentWaitForWebElement(StartDate_Button);
                        break;
                    case "End Date":
                        FluentWaitForWebElement(EndDate_Button);
                        break;
                    case "Close":
                        WaitForWebElementDisplayed(Close_Button);
                        FluentWaitForWebElement(Close_Button);
                        break;
                }
            }
        }
    }
}
