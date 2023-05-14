namespace UITestAutomation
{
    internal partial class FraudAlerts: Selenium_Methods
    {
        public void AssertUIControlsOnFraudAlertsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                { 
                    case " Upload Alert File":
                        FluentWaitForWebElement(UploadAlertFileBtn);
                        break;
                    case " Enter Alerts Manually":
                        FluentWaitForWebElement(EnterAlertsBtn);
                        break;
                    case " Search and set date range":
                        FluentWaitForWebElement(SearchSetDateRangeBtn);
                        break;
                    case " Show Submission":
                        FluentWaitForWebElement(ShowSubmissions);
                        break;
                    case " Print Letter":
                        FluentWaitForWebElement(PrintLetter);
                        break;
                    case " Delete CAMS Alert":
                        FluentWaitForWebElement(DeleteCAMS);
                        break;
                    case " Refresh":
                        FluentWaitForWebElement(Refresh);
                        break;
                    case " Card Number":
                        FluentWaitForWebElement(CardNumber);
                        break;
                    case " Uploaded On":
                        FluentWaitForWebElement(UploadedOn);
                        break;
                    case " Case Number":
                        FluentWaitForWebElement(CaseNumber);
                        break;
                    case " Entity":
                        FluentWaitForWebElement(Entity);
                        break;
                    case " Website":
                        FluentWaitForWebElement(Website);
                        break;
                    case " Status":
                        FluentWaitForWebElement(Status);
                        break;
                }
            }
        }
        public void AssertFieldsOnUploadFraudAlertsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Default Case Number":
                        FluentWaitForWebElement(DefaultCaseNumber);
                        break;
                    case " Select and Upload File":
                        FluentWaitForWebElement(SelectUploadFile);
                        break;
                    case " Close":
                        FluentWaitForWebElement(Close);
                        break;
                }
            }
        }
        public void AssertFieldsOnEnterAlertsManuallyPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Default Case Number":
                        FluentWaitForWebElement(DefaultCaseNumber2);
                        break;
                    case " Enter CAMs Numbers":
                        FluentWaitForWebElement(EnterCAMs);
                        break;
                    case " Save":
                        FluentWaitForWebElement(Save);
                        break;
                    case " Close":
                        FluentWaitForWebElement(Close2);
                        break;
                }
            }
        }
        public void AssertFieldsOnSearchandsetDateRangePage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Start Date":
                        FluentWaitForWebElement(StartDate);
                        break;
                    case " End Date":
                        FluentWaitForWebElement(EndDate);
                        break;
                    case " Status":
                        FluentWaitForWebElement(StatusField);
                        break;
                    case " Search":
                        FluentWaitForWebElement(Search);
                        break;
                }
            }
        }
        public void AssertFieldsOnShowSubmissionPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Reported On":
                        FluentWaitForWebElement(ReportedOn);
                        break;
                    case " Customer":
                        FluentWaitForWebElement(Customer);
                        break;
                    case " Case #":
                        FluentWaitForWebElement(Case);
                        break;
                    case " Third Party Breach Source":
                        FluentWaitForWebElement(ThirdPartyBreach);
                        break;
                    case " Save":
                        //FluentWaitForWebElement(Save2);
                        break;
                    case " Close":
                    //    FluentWaitForWebElement(Close3);
                        break;
                }
            }
        }
    }
}
