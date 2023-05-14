namespace UITestAutomation
{
    internal partial class FieldUpdateScripts
    {
        public void AssertUIControlsonFieldUpdateScriptsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Add Field Update Script":
                        FluentWaitForWebElement(AddFieldUpdateScript);
                        break;
                    case " Edit Script":
                        FluentWaitForWebElement(EditScript);
                        break;
                    case " Delete Script":
                        FluentWaitForWebElement(DeleteScript);
                        break;
                    case " Copy Script":
                        FluentWaitForWebElement(CopyScript);
                        break;
                    case " Refresh":
                        FluentWaitForWebElement(RefreshIcon);
                        break;
                    case " Download from Library":
                        FluentWaitForWebElement(DownloadfromLibraryButton);
                        break;
                    case " Action":
                        FluentWaitForWebElement(ActionField);
                        break;
                    case " Reference":
                        FluentWaitForWebElement(ReferenceField);
                        break;
                    case " Name":
                        FluentWaitForWebElement(NameField);
                        break;
                }
            }
        }

        public void AssertFieldsonAddFieldUpdateScriptPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Cross Button":
                        FluentWaitForWebElement(CrossButton);
                        break;
                    case " Script Name":
                        FluentWaitForWebElement(ScriptName);
                        break;
                    case " Unique Reference":
                        FluentWaitForWebElement(UniqueReference);
                        break;
                    case " Table":
                        FluentWaitForWebElement(Table);
                        break;
                    case " Field":
                        FluentWaitForWebElement(Field);
                        break;
                    case " Operator":
                        FluentWaitForWebElement(Operator);
                        break;
                    case " Value":
                        FluentWaitForWebElement(Value);
                        break;
                    case " Add Update to Script":
                        FluentWaitForWebElement(AddUpdateButton);
                        break;
                    case " Upload to Library":
                        FluentWaitForWebElement(UploadLibrary);
                        break;
                    case " Close":
                        FluentWaitForWebElement(CloseButton);
                        break;
                    case " Save":
                        FluentWaitForWebElement(SaveButton);
                        break;
                }
            }
        }

        public void AssertFieldsonDownloadfromlibraryPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Cross Button":
                        FluentWaitForWebElement(CrossButton2);
                        break;
                    case " Search Bar":
                        FluentWaitForWebElement(SearchBar);
                        break;
                    case " Search Button":
                        FluentWaitForWebElement(SearchButton);
                        break;
                    case " Action":
                        FluentWaitForWebElement(ActionField2);
                        break;
                    case " Reference":
                        FluentWaitForWebElement(ReferenceField2);
                        break;
                    case " Name":
                        FluentWaitForWebElement(NameField2);
                        break;
                    case " Close":
                        FluentWaitForWebElement(CloseButton2);
                        break;
                    case " Download Template":
                        FluentWaitForWebElement(DownloadTemplate);
                        break;
                }
            }
        }
    }
}
