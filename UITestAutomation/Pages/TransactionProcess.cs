using OpenQA.Selenium;

namespace UITestAutomation
{
    public class TransactionProcess : Selenium_Methods
    {
        //transaction page UI
        By AddTransactionProcesses_Button = By.CssSelector("button[title='Add Transaction Process']");
        By EditTransaction_Button = By.CssSelector("button[title=\"Edit Submission\"]");
        By DeleteTransaction_Button = By.CssSelector("button[title=\"Delete Submission\"]");
        By Action_Field = By.XPath("//table//th[.='Action']");
        By Name_Field = By.XPath("//table//th[.='Name']");
        By GLReference_Field = By.XPath("//table//th[.='Process']");
        By Process_Field = By.XPath("//table//th[.='GL Reference']");
        By Workflow_Field = By.XPath("//table//th[.='Workflows']");
        By Refresh_Button = By.XPath("//button[@ng-click=\"refreshSetup()\"]");
        By TransactionProcess_Dropdown = By.XPath("//a[@href='#/processsubmissionsetup']");

        //add
        By Name_Textbox = By.CssSelector("[ng-model='newSetup\\.description']");
        By Type_Dropdown = By.XPath("//select[@ng-model='newSetup.processType']");
        By GLReference_Dropdown = By.XPath("//select[@ng-model='newSetup.glReference']");
        By Workflows_Dropdown = By.XPath("//button[@ng-click='toggleSelect()']");
        By Save_Button = By.XPath("//button[@ng-click='addSetup()']");
        By Close_Button = By.CssSelector("#main .modal-footer [data-dismiss='modal']:nth-of-type(1)");

        ////edit
        //By Update_Button = By.XPath("//div[@class='modal-footer']/button[2]/span[.='Update']");

        ////delete
        //By No_Button = By.XPath("//button[@ng-click=\"dialog.abort()\"]");
        //By Yes_Button = By.XPath("//button[@ng-click=\"dialog.hide()\"]");

        public void ClickTransactionProcesses()
        {
            ClickTheWebElement(TransactionProcess_Dropdown);
            WaitForWebElementDisplayed(EditTransaction_Button);
        }

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

        public void ClickAddTransactionProcessesButton()
        {
            ClickOnWebElement(AddTransactionProcesses_Button);
            WaitForWebElementDisplayed(Name_Textbox);
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
