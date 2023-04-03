
namespace UITestAutomation.Pages.TransactionProcess
{
    internal partial class TransactionProcess
    {
        public void AssertUIControlsonTransactionProcessesPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Add":
                        FluentWaitForWebElement(AddTransactionProcesses_Button);
                        break;
                    case "Edit":
                        FluentWaitForWebElement(EditTransaction_Button);
                        break;
                    case "Delete":
                        FluentWaitForWebElement(DeleteTransaction_Button);
                        break;
                    case "Action":
                        FluentWaitForWebElement(Action_Field);
                        break;
                    case "Name":
                        FluentWaitForWebElement(Name_Field);
                        break;
                    case "Process":
                        FluentWaitForWebElement(Process_Field);
                        break;
                    case "GL Reference":
                        FluentWaitForWebElement(GLReference_Field);
                        break;
                    case "Workflows":
                        FluentWaitForWebElement(Workflow_Field);
                        break;
                    case "Refresh":
                        FluentWaitForWebElement(Refresh_Button);
                        break;
                }
            }
        }

        public void AssertFieldsOnAddTransactionProcessesDialog(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Name":
                        FluentWaitForWebElement(Name_Textbox);
                        break;
                    case "Type":
                        FluentWaitForWebElement(Type_Dropdown);
                        break;
                    case "GL Reference":
                        FluentWaitForWebElement(GLReference_Dropdown);
                        break;
                    case "Workflows":
                        FluentWaitForWebElement(Workflows_Dropdown);
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
