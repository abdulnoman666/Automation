namespace UITestAutomation
{
    internal partial class Reconciliation  : Selenium_Methods
    {
        public void AssertFieldsonReconciliationPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Reported On":
                        WaitForWebElementDisplayed(Save_Button);
                        FluentWaitForWebElement(ReportedOn_Field);
                        break;
                    case "Customer":
                        FluentWaitForWebElement(Customer_Field);
                        FluentWaitForWebElement(Customer_TextField);
                        break;
                    case "Source":
                        FluentWaitForWebElement(Source_Field);
                        FluentWaitForWebElement(Source_TextField);
                        break;
                    case "Status":
                        FluentWaitForWebElement(Status_Field);
                        FluentWaitForWebElement(Status_TextField);
                        break;
                    case "Dispute Type":
                        FluentWaitForWebElement(DisputeType_Field);
                        FluentWaitForWebElement(DisputeType_TextField);
                        break;
                    case "Total":
                        FluentWaitForWebElement(Total_Field);
                        break;
                    case "PC Amount":
                        FluentWaitForWebElement(PCAmount_Field);
                        break;
                    case "PC Rev Amount":
                        FluentWaitForWebElement(PCRevAmount_Field);
                        break;
                    case "Merchant Credit":
                        FluentWaitForWebElement(MerchantCredit_Field);
                        break;
                    case "Final Credit":
                        FluentWaitForWebElement(FinalCredit_Field);
                        break;
                    case "Insurance Amount":
                        FluentWaitForWebElement(InsuranceAmount_Field);
                        break;
                    case "Chargeback Amount":
                        FluentWaitForWebElement(ChargebackAmount_Field);
                        break;
                    case "Other Fees":
                        FluentWaitForWebElement(OtherFees_Field);
                        break;
                    case "Action":
                        FluentWaitForWebElement(Action_Field);
                        break;
                    case "Reset":
                        FluentWaitForWebElement(Reset_Button);
                        break;
                    case "Save":
                        FluentWaitForWebElement(Save_Button);
                        break;
                }
            }
        }
    }
}
