using OpenQA.Selenium;

namespace UITestAutomation
{
    internal partial class FeeReimbursementSettings
    {
        By FeeReimbursementsOption = By.LinkText("Fee Reimbursement Settings");
        By AddFeeReimbursementSettings_Button = By.CssSelector("button[title='Add Fee Reimbursement Setting']");
        By DeleteFeeReimbursementSettings_Button = By.CssSelector("tr:nth-of-type(1)  button[title='Delete Fee Reimbursement']");
        By EditFeeReimbursementSettings_Button = By.CssSelector("tr:nth-of-type(1)  button[title='Edit Fee Reimbursement']");

        // on ADD Page
        By Reference_Field = By.CssSelector("input[name='reference']");
        By Description_Field = By.CssSelector("textarea[name='alertName']");
        By AutoGenerateGL_CheckBox = By.CssSelector("input[name='autoGenerateGl']");
        By AutoFeeGLReference_DropDown = By.CssSelector("select[name='autoFeeGLReference']");
        By ShowOnDisputeForm_CheckBox = By.CssSelector("input[name='showOnDsputeForm']");
        By CreateDisputes_CheckBox = By.CssSelector("input[name='createDispute']");
        By IncludeInClaimTotal_CheckBox = By.CssSelector("input[name='includeInClaimTotal']");
        By Save_Button = By.CssSelector(".btn.btn-info");
        By Close_Button = By.CssSelector("form[name='workflowsettingform'] .btn.btn-default");

    }
}
