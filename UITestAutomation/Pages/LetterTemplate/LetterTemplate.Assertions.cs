
namespace UITestAutomation
{
    internal partial class LetterTemplate : Selenium_Methods
    {
        public void AssertUIControlsOnLetterTemplatePage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Add Letter Template":
                        FluentWaitForWebElement(AddLetterTemplate);
                        break;
                    case "Delete Letter Template":
                        FluentWaitForWebElement(DeleteLettter);
                        break;
                    case "Edit Letter Template":
                        FluentWaitForWebElement(EditLetter);
                        break;
                    case "Download From Library":
                        FluentWaitForWebElement(DownloadLetter);
                        break;
                    case "Copy Letter":
                        FluentWaitForWebElement(CopyLetter);
                        break;
                    case "Action":
                        FluentWaitForWebElement(Action);
                        break;
                    case "Refresh":
                        FluentWaitForWebElement(Refresh);
                        break;
                    case "ID":
                        FluentWaitForWebElement(ID);
                        break;
                    case "Title":
                        FluentWaitForWebElement(Title);
                        break;
                    case "Table Module":
                        FluentWaitForWebElement(TableModule);
                        break;
                    case "Refrence":
                        FluentWaitForWebElement(Reference);
                        break;
                    case "Enter Page":
                        FluentWaitForWebElement(EnterPage);
                        break;
                }
            }
        }
        public void AssertFieldssOnLetterInfoDialog(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Letter Title":
                        FluentWaitForWebElement(LetterTitle);
                        break;
                    case "Description":
                        FluentWaitForWebElement(LetterDescription);
                        break;
                    case "Author":
                        FluentWaitForWebElement(Author);
                        break;
                    case "File Name to Save":
                        FluentWaitForWebElement(FileNameToSaveLetter);
                        break;
                    case "Subject Line":
                        FluentWaitForWebElement(SubjectlineWhenSendingLetterViaEmail);
                        break;
                    case "Table Name":
                        FluentWaitForWebElement(TableName);
                        break;
                    case "Refrence":
                        FluentWaitForWebElement(ReferenceLetter);
                        break;
                    case "Workflows":
                        FluentWaitForWebElement(Workflows);
                        break;
                    case "Sql Command":
                        FluentWaitForWebElement(SQLCommandName);
                        break;
                    case "Input form":
                        FluentWaitForWebElement(IsInputForm);
                        break;
                    case "Consent Notice":
                        FluentWaitForWebElement(IsConsentNotice);
                        break;
                    case "Cut Off Date":
                        FluentWaitForWebElement(UseCutOffPrintDate);
                        break;
                    case "Eligible for E signature":
                        FluentWaitForWebElement(EligibleforESignature);
                        break;
                }
            }
        }
        public void AssertFieldssOnTemplateDialog(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Letter Template":
                        FluentWaitForWebElement(LetterTemplateForm);
                        break;
                }
            }
        }
        public void AssertFieldssOnStyleSheetDialog(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Title":
                        FluentWaitForWebElement(StyleSheetTitle);
                        break;
                    case "Style Sheet TextBox":
                        FluentWaitForWebElement(StyleSheet);
                        break;
                    case "Delete Template Sheet":
                        FluentWaitForWebElement(DeleteTemplateSheet);
                        break;
                    case "Copy Template Sheet":
                        FluentWaitForWebElement(CopyTemplateSheet);
                        break;
                    case "Save Template Sheet":
                        FluentWaitForWebElement(SaveTemplateSheet);
                        break;
                    case "Close Template Sheet":
                        FluentWaitForWebElement(CloseTemplateSheet);
                        break;
                }
            }
        }
    }
}

