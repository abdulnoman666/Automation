﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestAutomation.Pages.ErrorLogs
{
    internal partial class ErrorLogs
    {
        public void AssertFieldsonErrorLogsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim ())
                {
                    case "Search ans set date Range":
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
    }
}