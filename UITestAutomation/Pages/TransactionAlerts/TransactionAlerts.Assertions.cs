﻿namespace UITestAutomation { 
    internal partial class TransactionAlerts
    {
        public void AssertUIControlsOnTransactionAlertsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {   
                    case " Actions":
                        WaitForWebElementDisplayed(ActionField);
                        FluentWaitForWebElement(ActionField);
                        break;
                    case " ID":
                        FluentWaitForWebElement(IDField);
                        break;
                    case " Transaction Alert":
                        FluentWaitForWebElement(TransactionAlertField);
                        break;
                    case " Workflows":
                        FluentWaitForWebElement(WorkflowsField);
                        break;
                    case " Reference":
                        FluentWaitForWebElement(ReferenceField);
                        break;
                    case " Refresh":
                        FluentWaitForWebElement(RefreshIcon);
                        break;
                }
            }
        }

        public void AssertFieldslsOnAddTransactionAlertsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Name":
                        WaitForWebElementDisplayed(Name);
                        FluentWaitForWebElement(Name);
                        break;
                    case " Workflows":
                        FluentWaitForWebElement(Workflows);
                        break;
                    case " Reference":
                        FluentWaitForWebElement(Reference);
                        break;
                    case " Condition":
                        FluentWaitForWebElement(Condition);
                        break;
                    case " Action":
                        FluentWaitForWebElement(Action);
                        break;
                    case " Tooltip":
                        FluentWaitForWebElement(Tooltip);
                        break;
                    case " Save":
                        FluentWaitForWebElement(SaveButton);
                        break;
                    case " Close":
                        FluentWaitForWebElement(CloseButton);
                        break;
                    case " Save Condition":
                        FluentWaitForWebElement(SaveCondition);
                        break;
                    case " Cross":
                        FluentWaitForWebElement(CrossButton);
                        break;
                }
            }
         }
        
    }
}
