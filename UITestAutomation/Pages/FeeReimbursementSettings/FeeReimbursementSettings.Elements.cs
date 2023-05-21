using OpenQA.Selenium;

namespace UITestAutomation
{
    internal partial class FeeReimbursementSettings
    {
        By FeeReimbursementsOption = By.XPath("//div[@id='myNavbar']/ul[@class='nav navbar-nav navbar-right']/li[12]/ul[@class='dropdown-menu']//a[@href='#/feereimbursements']");
        By AddFeeReimbursementSettings_Button = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//button[@title='Add Fee Reimbursement Setting']");
        By DeleteFeeReimbursementSettings_Button = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//table/tbody/tr[1]//button[@title='Delete Fee Reimbursement']");
        By EditFeeReimbursementSettings_Button = By.XPath("//div[@id='main']/div[@class='container']/div[@class='ng-scope']//table/tbody/tr[1]//button[@title='Edit Fee Reimbursement']");

        // on ADD Page
        By Reference_Field = By.XPath("/html//div[@id='addFeeReimbursement']//form[@name='workflowsettingform']//input[@name='reference']");
        By Description_Field = By.XPath("/html//div[@id='addFeeReimbursement']//form[@name='workflowsettingform']//textarea[@name='alertName']");
        By AutoGenerateGL_CheckBox = By.XPath("/html//div[@id='addFeeReimbursement']//form[@name='workflowsettingform']//input[@name='autoGenerateGl']");
        By AutoFeeGLReference_DropDown = By.XPath("/html//div[@id='addFeeReimbursement']//form[@name='workflowsettingform']//select[@name='autoFeeGLReference']");
        By ShowOnDisputeForm_CheckBox = By.XPath("/html//div[@id='addFeeReimbursement']//form[@name='workflowsettingform']//input[@name='showOnDsputeForm']");
        By CreateDisputes_CheckBox = By.XPath("/html//div[@id='addFeeReimbursement']//form[@name='workflowsettingform']//input[@name='createDispute']");
        By IncludeInClaimTotal_CheckBox = By.XPath("/html//div[@id='addFeeReimbursement']//form[@name='workflowsettingform']//input[@name='includeInClaimTotal']");
        By Save_Button = By.XPath("/html//div[@id='addFeeReimbursement']//form[@name='workflowsettingform']//div[@class='modal-footer']/button[2]");
        By Close_Button = By.XPath("/html//div[@id='addFeeReimbursement']//form[@name='workflowsettingform']//div[@class='modal-footer']/button[1]");

    }
}
