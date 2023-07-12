
namespace UITestAutomation
{
    internal partial class CycleCodeMaps
    {
        public void AssertUIControlsOnCycleCodeMapsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Add Cycle Code":
                        FluentWaitForWebElement(AddCycleCodeMaps_Button);
                        break;
                    case "Delete Cycle Code":
                        FluentWaitForWebElement(DeleteCycleCodeMaps_Button);
                        break;
                    case "Edit Cycle Code":
                        FluentWaitForWebElement(EditCycleCodeMaps_Button);
                        break;

                }
            }
        }
        public void AssertFieldssonAddCycleCodeMapsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Cycle Code":
                        WaitForWebElementDisplayed(CycleCode_Field);
                        FluentWaitForWebElement(CycleCode_Field);
                        break;
                    case "Mapped Vale":
                        FluentWaitForWebElement(MappedValue_Field);
                        break;
                    case "Save":
                        FluentWaitForWebElement(Save_Button);
                        break;
                    case "Close":
                        FluentWaitForWebElement(Close_Button);
                        break;
                }
            }
        }
    }
}
    
