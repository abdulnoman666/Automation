using OpenQA.Selenium;

namespace UITestAutomation
{
    internal partial class Reconciliation
    {
        By Reconciliation_Dropdown = By.CssSelector("li:nth-of-type(4) > .dropdown-menu > li:nth-of-type(3) > a");
        By ReportedOn_Field = By.XPath("//th[.='Reported On']");
        By Customer_Field = By.XPath("//th[.='Customer']");
        By Customer_TextField = By.XPath("//input[@ng-model=\"search.customerName\"]");
        By Source_Field = By.XPath("//th[.='Source']");
        By Source_TextField = By.XPath("//input[@ng-model=\"search.source\"]");
        By Status_Field = By.XPath("//th[.='Status']");
        By Status_TextField = By.XPath("//input[@ng-model=\"search.status\"]");
        By DisputeType_Field = By.XPath("//th[.='Dispute Type']");
        By DisputeType_TextField = By.XPath("//select[@ng-model=\"search.disputeType\"]");
        By Total_Field = By.XPath("//th[.='Total']");
        By PCAmount_Field = By.XPath("//th[.='PC Amount']");
        By PCRevAmount_Field = By.XPath("//th[.='PC Rev Amount']");
        By MerchantCredit_Field = By.XPath("//th[.='Merchant Credit']");
        By FinalCredit_Field = By.XPath("//th[.='Final Credit']");
        By InsuranceAmount_Field = By.XPath("//th[.='Insurance Amount']");
        By ChargebackAmount_Field = By.XPath("//th[.='Chargeback Amount']");
        By OtherFees_Field = By.XPath("//th[.='Other Fees']");
        By Action_Field = By.XPath("//th[.='Action']");
        By Reset_Button = By.XPath("//button[@ng-click=\"search={}\"]");
        By Save_Button = By.XPath("//button[@ng-click=\"save(reconitem)\"]");

    }
}
