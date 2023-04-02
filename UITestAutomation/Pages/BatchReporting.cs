using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestAutomation.Pages
{
    public class BatchReporting : Selenium_Methods
    {
        By BatchReportingOption = By.LinkText("Batch Reporting"); 
        By BatchReference = By.CssSelector("[ng-model] option[label]");
        By DateRange = By.CssSelector("[ng-model='dateRange'] option");
        By CalendarIcon = By.XPath("//button[@ng-click='ctrl.openCalendarPane($event)']");
        By DownArrowIcon = By.CssSelector(".panel-body .fi-field:nth-of-type(1) .md-datepicker-expand-triangle");
        By PrintReport= By.CssSelector(".glyphicon-file");
        By ExportDisputes = By.XPath("//button[@ng-click='exportDisputes($event)']");

        public void ClickBatchReportingOption()
        {
            WaitForWebElementDisplayed(BatchReportingOption);
            ClickOnWebElement(BatchReportingOption);
        }
        public void AssertUIControlsOnBatchReportingPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Batch Reference":
                        FluentWaitForWebElement(BatchReference);
                        break;
                    case " Date Range":
                        FluentWaitForWebElement(DateRange);
                        break;
                    case " Calendar Icon":
                        FluentWaitForWebElement(CalendarIcon);
                        break;
                    case " Down Arrow Icon":
                        FluentWaitForWebElement(DownArrowIcon);
                        break;
                    case " Print Report":
                        FluentWaitForWebElement(PrintReport);
                        break;
                    case " Export Disputes":
                        FluentWaitForWebElement(ExportDisputes);
                        break;
                }
            }
        }
    }
}
