
namespace UITestAutomation
{
    internal partial class Users
    {
        public void AssertUIControlsonUsersPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Add":
                        FluentWaitForWebElement(AddUser_Button);
                        break;
                    case "Refresh":
                        FluentWaitForWebElement(Refresh_Button);
                        break;
                    case "Edit":
                        WaitForWebElementDisplayed(Edit_Button);
                        FluentWaitForWebElement(Edit_Button);
                        break;
                    case "Delete":
                        FluentWaitForWebElement(Delete_Button);
                        break;
                    case "Show Deleted Users":
                        FluentWaitForWebElement(ShowDeletedUsers_Button);
                        break;
                    case "Go":
                        FluentWaitForWebElement(Go_Button);
                        break;
                    case "Enter Page":
                        FluentWaitForWebElement(EnterPage_Textbox);
                        break;
                    case "Action":
                        FluentWaitForWebElement(Action_Field);
                        break;
                    case "Name":
                        FluentWaitForWebElement(Name_Field);
                        FluentWaitForWebElement(Name_Textbox);
                        break;
                    case "Email":
                        FluentWaitForWebElement(Email_Field);
                        FluentWaitForWebElement(Email_Textbox);
                        break;
                    case "Phone":
                        FluentWaitForWebElement(Phone_Field);
                        break;
                    case "Role":
                        FluentWaitForWebElement(Role_Field);
                        FluentWaitForWebElement(Role_Textbox);
                        break;
                    case "Deleted":
                        FluentWaitForWebElement(Deleted_Field);
                        break;
                    case "Has Login":
                        FluentWaitForWebElement(HasLogin_Field);
                        break;
                    case "Branch":
                        FluentWaitForWebElement(Branch_Field);
                        break;
                    case "More":
                        FluentWaitForWebElement(More_Field);
                        break;
                    case "setpageDirect":
                        FluentWaitForWebElement(SetPage_Button);
                        break;
                    case "prevpage":
                        FluentWaitForWebElement(PrevPage_Button);
                        break;
                    case "nextpage":
                        FluentWaitForWebElement(NextPage_Button);
                        break;
                    case "setpageDirect(pages.length)":
                        FluentWaitForWebElement(SetPageDirect_Button);
                        break;
                }
            }
        }

        public void AssertFieldsonAddUsersDialog(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "First Name":
                        WaitForWebElementDisplayed(FirstName_Textbox);
                        FluentWaitForWebElement(FirstName_Textbox);
                        break;
                    case "Last Name":
                        FluentWaitForWebElement(LastName_Textbox);
                        break;
                    case "Email":
                        FluentWaitForWebElement(EmailAddUser_Textbox);
                        break;
                    case "Phone":
                        FluentWaitForWebElement(Phone_Textbox);
                        break;
                    case "Role":
                        FluentWaitForWebElement(Role_Dropdown);
                        break;
                    case "Close":
                        FluentWaitForWebElement(CloseAddUser_Button);
                        break;
                    case "Save":
                        FluentWaitForWebElement(SaveAddUser_Button);
                        break;
                }
            }
        }
    }
}
