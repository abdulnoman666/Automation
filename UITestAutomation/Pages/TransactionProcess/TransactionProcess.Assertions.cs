
using OpenQA.Selenium;

namespace UITestAutomation
{
    internal partial class TransactionProcess
    {
        int count;
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
                        count = GetElements(DeleteTransaction_Button).Count();
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

        public void AdddatatoFieldsOnAddTransactionProcessesDialog(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Name":
                        EnterValueinWebElement(Name_Textbox, item[1]);
                        break;
                    case "Type":
                        ClickOnWebElement(Type_Dropdown);
                        ElementToBeSelectedFromDropdown(Type_Dropdown, item[1]);
                        ClickOnWebElement(Type_Dropdown);
                        break;
                    case "GL Reference":
                        ClickOnWebElement(GLReference_Dropdown);
                        ElementToBeSelectedFromDropdown(GLReference_Dropdown, item[1]);
                        ClickOnWebElement(GLReference_Dropdown);
                        break;
                    case "Workflows":
                        ClickOnWebElement(Workflows_Dropdown);
                        Thread.Sleep(5000);
                        var workflows = GetElements(workflows_Links);
                        foreach (var workflow in workflows)
                        {
                            var element = workflow.Text;
                            if (element.Trim() == item[1])
                            {
                                workflow.Click();
                                ClickOnWebElement(Name_Textbox);
                                break;
                            }
                           
                        }
                        break;
                }
            }
        }

        public void validateActionfieldsonTransactionProcessPage()
        {
            Thread.Sleep(5000);
            int afteradd = GetElements(DeleteTransaction_Button).Count();
            for (int i = 1; i <= afteradd; i++)
            {
                if (i > count)
                {
                    Thread.Sleep(5000);
                    var value = driver.FindElement(By.XPath("(//button[@ng-click=\"removeLookup($event,t)\"])[" + i + "]"));
                    value.Click();
                    Thread.Sleep(5000);
                    ClickOnWebElement(Yes_Button);
                }
            }

        }
    }
}
