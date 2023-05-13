using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestAutomation.Pages.MyTasks
{
    internal partial class MyTasks : Selenium_Methods
    {
        public void ClickMyTasks()
        {
            ClickTheWebElement(MyTasks_Dropdown);
            WaitForWebElementDisplayed(Actions_Field);
        }
    }
}
