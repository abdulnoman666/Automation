namespace UITestAutomation
{
    internal partial class AuditorLog: Selenium_Methods
    {
        public void AssertUIControlsOnAuditorLogPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Show Closed Submissions":
                        FluentWaitForWebElement(ShowClosedSubButton);
                        break;
                    case " Edit Dispute":
                        FluentWaitForWebElement(EditDispute);
                        break;
                    case " View Submission":
                        FluentWaitForWebElement(ViewSubmission);
                        break;
                    case " Links":
                        FluentWaitForWebElement(Links);
                        break;
                    case " Reported":
                        FluentWaitForWebElement(Reported);
                        break;
                    case " P/C":
                        FluentWaitForWebElement(PC);
                        break;
                    case " N/S":
                        FluentWaitForWebElement(NS);
                        break;
                    case " R/S":
                        FluentWaitForWebElement(RS);
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
                }
            }
        }
    }
}
