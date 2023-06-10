namespace UITestAutomation
{
    internal partial class QuestionnaireDependencySetup
    {
        public void AssertUIControlsOnQuestionareDPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Add Form":
                        FluentWaitForWebElement(AddFormDependancyList);
                        break;
                    case "Delete List":
                        FluentWaitForWebElement(DeleteList);
                        break;
                    case "Edit Form":
                        FluentWaitForWebElement(EditFormDependencySetup);
                        break;
                    case "Copy Form":
                        FluentWaitForWebElement(CopyForm);
                        break;
                    case "Refresh":
                        FluentWaitForWebElement(RefreshIcon);
                        break;
                    case "Condition Search":
                        FluentWaitForWebElement(ConditionSearchText);
                        break;

                }
            }
        }
        public void AssertFieldssOnAddQuestionareDPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Workflow Name":
                        FluentWaitForWebElement(WorkFlowName);
                        break;
                    case "Save":
                        FluentWaitForWebElement(SaveButton);
                        break;
                    case "Close":
                        FluentWaitForWebElement(CloseButton);
                        break;
                }
            }
        }
    }
}

