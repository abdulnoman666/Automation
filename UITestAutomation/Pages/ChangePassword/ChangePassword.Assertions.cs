
namespace UITestAutomation
{
    internal partial class ChangePassword
    {
        public void AssertUIControlsOnChangePasswordPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Change Password":
                        FluentWaitForWebElement(ChangePassword_Control);
                        break;
                    case "Submit":
                        FluentWaitForWebElement(Submit_Button);
                        break;
                }
            }
        }
        public void AssertFieldsOnChangePasswordPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Current Password":
                        FluentWaitForWebElement(CurrentPassword_Field);
                        break;
                    case "New Password":
                        FluentWaitForWebElement(NewPassword_Field);
                        break;
                    case "Confirm Password":
                        FluentWaitForWebElement(ConfirmPassword_Field);
                        break;
                }
            }
        }
    }
}
