using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class CycleCodeMaps
    {
        By AddCycleCodeMaps_Button = By.CssSelector("button[title='Add Cycle Code Map']");
        By DeleteCycleCodeMaps_Button = By.CssSelector("tr:nth-of-type(1)  button[title='Delete Cycle Code Map']");
        By EditCycleCodeMaps_Button = By.CssSelector("tr:nth-of-type(1)  button[title='Edit Cycle Code Map']");

        //ADD PAGE
        By CycleCode_Field = By.CssSelector("[ng-model='cyclecodemap\\.cycleCodeString']");
        By MappedValue_Field = By.CssSelector("[ng-model='cyclecodemap\\.cycleCode']");
        By Save_Button = By.CssSelector(".btn.btn-info");
        By Close_Button = By.CssSelector(".modal-dialog .btn.btn-default");





    }
}
