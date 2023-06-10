namespace UITestAutomation
{
    internal partial class ProvisionalCreditLog: Selenium_Methods
    {
        public void AssertUIControlsOnProvisionalCreditLogPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Refresh Submissions":
                        FluentWaitForWebElement(RefreshSubmissions);
                        break;
                    case " Links":
                        FluentWaitForWebElement(Links);
                        break;
                    case " Reported":
                        FluentWaitForWebElement(Reported);
                        break;
                    case " P/C Date":
                        FluentWaitForWebElement(PCDate);
                        break;
                    case " P/C Amount":
                        FluentWaitForWebElement(PCAmount);
                        break;
                    case " C/L Amount":
                        FluentWaitForWebElement(CLAmount);
                        break;
                    case " Denial Reason":
                        FluentWaitForWebElement(DenialReason);
                        break;
                    case " Status":
                        FluentWaitForWebElement(Status);
                        break;
                    case " Resolution":
                        FluentWaitForWebElement(Resolution);
                        break;
                    case " Amount":
                        FluentWaitForWebElement(Amount);
                        break;
                    case " Type":
                        FluentWaitForWebElement(Type);
                        break;
                    case " Customer":
                        FluentWaitForWebElement(Customer);
                        break;
                    case " View Original Submission":
                        FluentWaitForWebElement(ViewSubmission);
                        break;
                    case " Edit Dispute Research":
                        FluentWaitForWebElement(EditDisputeResearch);
                        break;
                }
            }
        }
    }
}
