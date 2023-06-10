using OpenQA.Selenium;

namespace UITestAutomation
{
    internal partial class TransactionProcess
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

    }
}
