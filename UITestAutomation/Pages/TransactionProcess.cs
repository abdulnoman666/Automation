using OpenQA.Selenium;

namespace UITestAutomation
{
    public class TransactionProcess : Selenium_Methods
    {
        By AddTransactionProcesses_Button = By.CssSelector("button[title='Add Transaction Process']");
        By Name_Textbox = By.CssSelector("[ng-model='newSetup\\.description']");
        By Type_Dropdown = By.XPath("//select[@ng-model='newSetup.processType']");
        By GLReference_Dropdown = By.XPath("//select[@ng-model='newSetup.glReference']");
        By Workflows_Dropdown = By.XPath("//button[@ng-click='toggleSelect()']");
        By Workflow_Dropdown = By.XPath("(//li[@ng-repeat='i in items | filter:searchText'])");
        By SaveButtonElement = By.XPath("//button[@ng-click='addSetup()']");

        public void ClickAddTransactionProcessesElementOnTransactionProcessPage()
        {
            WaitForWebElementDisplayed(AddTransactionProcesses_Button);
            ClickOnWebElement(AddTransactionProcesses_Button);
        }


        public void PerformingActionsOnAddProcessTransactionSetupDialog(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Name":
                        WaitForWebElementDisplayed(Name_Textbox);
                        EnterValueinWebElement(Name_Textbox, item[1]);
                        break;
                    case "Type":
                        WaitForWebElementDisplayed(Type_Dropdown);
                        ElementToBeSelectedFromDropdown(Type_Dropdown, item[1]);
                        break;
                    case "GL Reference":
                        WaitForWebElementDisplayed(GLReference_Dropdown);
                        EnterValueinWebElement(GLReference_Dropdown, item[1]);
                        break;
                    case "Workflows":
                        WaitForWebElementDisplayed(Workflows_Dropdown);
                        ClickOnWebElement(Workflows_Dropdown);
                        var elements = GetElements(Workflow_Dropdown);
                        foreach (var element in elements)
                        {
                            var text = element.Text;
                            if (text.Trim() == item[1])
                            {
                                element.Click();
                            }
                        }
                        ClickOnWebElement(Name_Textbox);
                        break;
                }
            }
        }
        public void UserClicksSaveButtonOnAddProcessTransactionSetupDialog()
        {
            WaitForWebElementDisplayed(SaveButtonElement);
            ClickOnWebElement(SaveButtonElement);
        }
    }
}
