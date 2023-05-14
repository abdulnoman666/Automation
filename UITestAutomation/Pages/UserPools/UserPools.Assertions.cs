
namespace UITestAutomation
{
    internal partial class UserPools
    {
        public void AssertUIControlsonUserPoolsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Add":
                        FluentWaitForWebElement(AddPool_Button);
                        break;
                    case "Refresh":
                        FluentWaitForWebElement(Refresh_Button);
                        break;
                    case "Reference Search":
                        FluentWaitForWebElement(ReferenceSearch_TextBox);
                        break;
                    case "Edit":
                        FluentWaitForWebElement(EditPool_Button);
                        break;
                    case "Delete":
                        FluentWaitForWebElement(DeletePool_Button);
                        break;
                    case "Action":
                        FluentWaitForWebElement(Action_Field);
                        break;
                    case "ID":
                        FluentWaitForWebElement(ID_Field);
                        break;
                    case "Group Name":
                        FluentWaitForWebElement(GroupName_Field);
                        break;
                    case "Reference":
                        FluentWaitForWebElement(Rerefernce_Field);
                        break;
                    case "Users":
                        FluentWaitForWebElement(User_Field);
                        break;
                    case "Show":
                        FluentWaitForWebElement(show_Button);
                        break;
                }
            }
        }

        public void AssertFieldsOnAddPoolDialog(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Pool Name":
                        FluentWaitForWebElement(PoolName_Field);
                        break;
                    case "Pool Reference":
                        FluentWaitForWebElement(PoolReference_Field);
                        break;
                    case "Pool Users Email List":
                        FluentWaitForWebElement(PoolUserEmaillist_Field);
                        break;
                    case "Close":
                        FluentWaitForWebElement(Close_Button);
                        break;
                    case "Save":
                        FluentWaitForWebElement(Save_Button);
                        break;
                }
            }
        }
    }
}
