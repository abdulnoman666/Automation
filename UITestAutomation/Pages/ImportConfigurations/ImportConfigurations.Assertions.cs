namespace UITestAutomation.Pages.ImportConfigurations
{
    internal partial class ImportConfigurations
    {
        public void AssertUIControlsonImportConfigurationsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Add Configuration":
                        FluentWaitForWebElement(AddConfiguration);
                        break;
                    case "Edit Configuration":
                        FluentWaitForWebElement(EditConfiguration);
                        break;
                    case "Refresh":
                        FluentWaitForWebElement(RefreshIcon);
                        break;
                    case "Action Field":
                        FluentWaitForWebElement(ActionField);
                        break;
                    case "ID Field":
                        FluentWaitForWebElement(IDField);
                        break;
                    case "Name Field":
                        FluentWaitForWebElement(NameField);
                        break;
                }
            }
        }

        public void AssertFieldsonAddConfigurationonImportConfigurationsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Cross Button":
                        FluentWaitForWebElement(CrossButton);
                        break;
                    case "Name ":
                        FluentWaitForWebElement(Name);
                        break;
                    case "Delimiter":
                        FluentWaitForWebElement(Delimiter);
                        break;
                    case "FieldList":
                        FluentWaitForWebElement(FieldList);
                        break;
                    case "Chechbox":
                        FluentWaitForWebElement(Chechbox);
                        break;
                    case "Close Button":
                        FluentWaitForWebElement(CloseButton);
                        break;
                    case "Save Button":
                        FluentWaitForWebElement(SaveButton);
                        break;
                }
            }
        }
    }
}
