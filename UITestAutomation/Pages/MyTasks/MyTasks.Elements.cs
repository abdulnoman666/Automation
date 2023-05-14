using OpenQA.Selenium;

namespace UITestAutomation
{
    internal partial class MyTasks
    {
        By MyTasks_Dropdown = By.XPath("//a[@href='../backoffice/#/assignedtasks']");
        By ShowClosedTasks_Button = By.CssSelector(".page-link");
        By Actions_Field = By.XPath("//table//th[.='Actions']");
        By Status_Field = By.XPath("//table//th[.='Status']");
        By Task_Field = By.XPath("//table//th[.='Task']");
        By CaseID_Field = By.XPath("//table//th[.='Case ID']");
        By CreatedOn_Field = By.XPath("//table//th[.='Created On']");
        By AssignedOn_Field = By.XPath("//table//th[.='Assigned On']");

    }
}
