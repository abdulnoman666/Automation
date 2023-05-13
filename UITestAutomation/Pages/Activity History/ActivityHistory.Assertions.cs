
namespace UITestAutomation
{
    internal partial class ActivityHistory
    {
        public void AssertFieldsonActivityHistoryPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Download History":
                        WaitForWebElementDisplayed(DownloadHistory_Button);
                        FluentWaitForWebElement(DownloadHistory_Button);
                        break;
                    case "Refresh":
                        FluentWaitForWebElement(Refresh_Button);
                        break;
                    case "Start Date":
                        FluentWaitForWebElement(StartDate_TextField);
                        break;
                    case "End Date":
                        FluentWaitForWebElement(EndDate_TextField);
                        break;
                    case "Event Type (select one or more event types)":
                        FluentWaitForWebElement(EventType_Dropdown);
                        break;
                    case "Users (select one or more users)":
                        FluentWaitForWebElement(Users_Dropdown);
                        break;
                    case "Reset":
                        FluentWaitForWebElement(Reset_Button);
                        break;
                    case "Search":
                        FluentWaitForWebElement(Search_Button);
                        break;
                    case "Action":
                        FluentWaitForWebElement(Action_Field);
                        break;
                    case "ID":
                        FluentWaitForWebElement(ID_Field);
                        break;
                    case "Sub Case":
                        FluentWaitForWebElement(SubCase_Field);
                        break;
                    case "Workflow":
                        FluentWaitForWebElement(Workflow_Field);
                        break;
                    case "User Name":
                        FluentWaitForWebElement(UserName_Field);
                        break;
                    case "Type":
                        FluentWaitForWebElement(Type_Field);
                        break;
                    case "Automation":
                        FluentWaitForWebElement(Automation_Field);
                        break;
                    case "Created":
                        FluentWaitForWebElement(Created_Field);
                        break;
                }
            }
        }
    }
}
