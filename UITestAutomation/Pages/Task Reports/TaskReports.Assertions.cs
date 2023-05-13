using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestAutomation.Pages.Task_Reports
{
    internal partial class TaskReports
    {
        public void AssertFieldsonTaskReportPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Workflow":
                        WaitForWebElementDisplayed(Workflow_Dropdown);
                        FluentWaitForWebElement(Workflow_Dropdown);
                        break;
                    case "From":
                        FluentWaitForWebElement(From_Date);
                        break;
                    case "To":
                        FluentWaitForWebElement(To_Date);
                        break;
                    case "Export Tasks":
                        FluentWaitForWebElement(ExportTasks_Button);
                        break;
                }
            }
        }
    }
}
