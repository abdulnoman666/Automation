
namespace UITestAutomation
{
    internal partial class AlertDefinitions
    {
        public void AssertUIControlsonAlertDefinitionsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {

                    case "Add Alert Definition":
                        FluentWaitForWebElement(AddAlertDefinitions_Button);
                        break;
                    case "Delete Alert Definition":
                        FluentWaitForWebElement(DeleteAlertDefinitions_Button);
                        break;
                    case "Edit Alert Definition":
                        FluentWaitForWebElement(EditAlertDefinition_Button);
                        break;
                    case "Copy Alert Definition":
                        FluentWaitForWebElement(CopyAlertDefinition_Button);
                        break;
                    case "Create Alert Definition":
                        FluentWaitForWebElement(CreateAlertDefinitons_Button);
                        break;
                    case "Download From Library":
                        FluentWaitForWebElement(DownloadFromLibrary_Button);
                        break;
                }
            }
        }
        public void AssertFieldssOnAddDefinitionDailog(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Definition Name":
                        FluentWaitForWebElement(DefinitionName_Field);
                        break;
                    case "Alert Type":
                        FluentWaitForWebElement(AlertType_Field);
                        break;
                    case "Table Name":
                        FluentWaitForWebElement(TableName_Field);
                        break;
                    case "Deadline Refrence":
                        FluentWaitForWebElement(DeadlineRefrence_Field);
                        break;
                    case "Business Days":
                        FluentWaitForWebElement(BusinessDays_CheckBox);
                        break;
                    case "Calculate The Last Business Day":
                        FluentWaitForWebElement(CalculateTheLastBusinessDay_CheckBox);
                        break;
                    case "Days":
                        FluentWaitForWebElement(Days_Field);
                        break;
                    case "Refrence":
                        FluentWaitForWebElement(Reference_Field);
                        break;
                    case "Source List":
                        FluentWaitForWebElement(SourceList_Field);
                        break;
                    case "Save":
                        FluentWaitForWebElement(Save_Button);
                        break;
                    case "Close":
                        FluentWaitForWebElement(Close_Button);
                        break;
                    case "Explanation":
                        FluentWaitForWebElement(Explanation_Form);
                        break;
                }
            }
        }
    }
}
    

