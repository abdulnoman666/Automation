namespace UITestAutomation.Pages.Disputes
{
    internal partial class Disputes: Selenium_Methods
    {
        public void AssertUIControlsOnDisputesPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Alerts":
                        FluentWaitForWebElement(AlertsButton);
                        break;
                    case " Search and set date range ":
                        FluentWaitForWebElement(SearchSetDateButton);
                        break;
                    case " Select User or Search in list...":
                        FluentWaitForWebElement(SearchUser);
                        break;
                    case " Refresh Submissions ":
                        FluentWaitForWebElement(RefreshSubmissions);
                        break;
                    case " Show Closed Disputes":
                        FluentWaitForWebElement(ShowClosedDisputesButton);
                        break;
                    case " 1":
                        FluentWaitForWebElement(One);
                        break;
                    case " 2":
                        FluentWaitForWebElement(Two);
                        break;
                    case " 3":
                        FluentWaitForWebElement(Three);
                        break;
                    case " 4":
                        FluentWaitForWebElement(Four);
                        break;
                    case " 5":
                        FluentWaitForWebElement(Five);
                        break;
                    case " 6":
                        FluentWaitForWebElement(Six);
                        break;
                    case " 7":
                        FluentWaitForWebElement(Seven);
                        break;
                    case " Links":
                        FluentWaitForWebElement(LinksField);
                        break;
                    case " Reported":
                        FluentWaitForWebElement(ReportedField);
                        break;                
                    case " Days":
                        FluentWaitForWebElement(DaysField);
                        break;
                    case " Status":
                        FluentWaitForWebElement(StatusField);
                        break;
                    case " Detail":
                        FluentWaitForWebElement(DetailField);
                        break;
                    case " Resolution":
                        FluentWaitForWebElement(ResolutionField);
                        break;
                    case " Amount":
                        FluentWaitForWebElement(AmountField);
                        break;
                    case " Recovered":
                        FluentWaitForWebElement(RecoveredField);
                        break;
                    case " Customer":
                        FluentWaitForWebElement(CustomerField);
                        break;
                    case " Assigned To":
                        FluentWaitForWebElement(AssignedToField);
                        break;
                    case " Status Field":
                        FluentWaitForWebElement(DisputeStatusField);
                        break;
                    case " Resolution Field":
                        FluentWaitForWebElement(DisputeResolutionField);
                        break;
                    case " Customer Field":
                        FluentWaitForWebElement(DisputeCustomerField);
                        break;
                    case " Edit Dispute":
                        FluentWaitForWebElement(EditDisputeButton);
                        break;
                    case " View Original Submission":
                        FluentWaitForWebElement(ViewSubmissionField);
                        break;
                }
            }
        }
        public void AssertFieldsOnAlertsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Customer":
                        FluentWaitForWebElement(Customer);
                        break;
                    case " Submission ID ":
                        FluentWaitForWebElement(SubmissionId);
                        break;
                    case " Status":
                        FluentWaitForWebElement(Status);
                        break;
                    case " Source":
                        FluentWaitForWebElement(Source);
                        break;
                    case " Alert":
                        FluentWaitForWebElement(Alert);
                        break;
                    case " Type":
                        FluentWaitForWebElement(Type);
                        break;
                    case " Deadline":
                        FluentWaitForWebElement(Deadline);
                        break;
                    case " Close":
                        FluentWaitForWebElement(CloseButton);
                        break;
                }
            }
        }
        public void AssertFieldsOnSearchPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Calendar":
                        FluentWaitForWebElement(Calendar);
                        break;
                    case " Search":
                        FluentWaitForWebElement(Search);
                        break;
                    case " Reset":
                        FluentWaitForWebElement(Reset);
                        break;
                    case " Status":
                        FluentWaitForWebElement(Status2);
                        break;
                    case " Full Card Number":
                        FluentWaitForWebElement(CardNumber);
                        break;
                    case " Full Account Number":
                        FluentWaitForWebElement(AccountNumber);
                        break;
                    case " * Search":
                        FluentWaitForWebElement(Search2);
                        break;
                    case " Reset 2":
                        FluentWaitForWebElement(Reset2);
                        break;
                    case " Close":
                        FluentWaitForWebElement(CloseButton2);
                        break;
                }
            }
        }
        public void AssertFieldsOnShowClosedDisputesPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " 8":
                        FluentWaitForWebElement(Eight);
                        break;
                    case " 9":
                        FluentWaitForWebElement(Nine);
                        break;
                    case " 10":
                        FluentWaitForWebElement(Ten);
                        break;
                    case " 11":
                        FluentWaitForWebElement(Eleven);
                        break;
                    case " 12":
                        FluentWaitForWebElement(Twelve);
                        break;
                    case " Enter Page":
                        FluentWaitForWebElement(EnterPageField);
                        break;
                    case " Go":
                        FluentWaitForWebElement(GoButton);
                        break;
                }
            }
        }
        public void AssertUIControlsOnEditDisputesPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Research Status":
                        FluentWaitForWebElement(ResearchStatus);
                        break;
                    case " Documents":
                        FluentWaitForWebElement(DocumentsButton);
                        break;
                    case " History":
                        FluentWaitForWebElement(HistoryButton);
                        break;
                    case " Refresh":
                        FluentWaitForWebElement(Refresh);
                        break;
                    case " Submission Disputes":
                        FluentWaitForWebElement(SubmissionDisputes);
                        break;
                    case " Save":
                        FluentWaitForWebElement(Save);
                        break;
                    case " View Submission":
                        FluentWaitForWebElement(ViewSubmission);
                        break;
                    case " Resolution Button":
                        FluentWaitForWebElement(ResolutionButton);
                        break;
                    case " Print Letter":
                        FluentWaitForWebElement(PrintLetter);
                        break;
                    case " Dispute Details":
                        FluentWaitForWebElement(DisputeDetails);
                        break;
                    case " POS":
                        FluentWaitForWebElement(POS);
                        break;
                    case " Foreign Transaction":
                        FluentWaitForWebElement(ForeignTransaction);
                        break;
                    case " Research":
                        FluentWaitForWebElement(Research);
                        break;
                    case " Detail":
                        FluentWaitForWebElement(Detail);
                        break;
                    case " Closed":
                        FluentWaitForWebElement(Closed);
                        break;
                    case " Close Date":
                        FluentWaitForWebElement(CloseDate);
                        break;
                    case " Pre-Arbitration":
                        FluentWaitForWebElement(PreArbitration);
                        break;
                    case " Final Resolution Date":
                        FluentWaitForWebElement(FinalResolutionDate);
                        break;
                    case " Notes":
                        FluentWaitForWebElement(Notes);
                        break;
                    case " Enter Notes":
                        FluentWaitForWebElement(EnterNotes);
                        break;
                    case " Customer Provisional Credit":
                        FluentWaitForWebElement(CustomerCredit);
                        break;
                    case " Transaction Amount":
                        FluentWaitForWebElement(TransactionAmount);
                        break;
                    case " Provisional Credit Amount":
                        FluentWaitForWebElement(CreditAmount);
                        break;
                    case " Consumer Liability":
                        FluentWaitForWebElement(ConsumerLiability);
                        break;
                    case " Denial Reason":
                        FluentWaitForWebElement(DenialReason);
                        break;
                    case " PC Reversal Date":
                        FluentWaitForWebElement(ReversalDate);
                        break;
                    case " Representment":
                        FluentWaitForWebElement(Representment);
                        break;
                    case " Settlement / Representment Date":
                        FluentWaitForWebElement(RepresentmentDate);
                        break;
                    case " Merchant Chargeback":
                        FluentWaitForWebElement(MerchantChargeback);
                        break;
                    case " Chargeback Date":
                        FluentWaitForWebElement(ChargebackDate);
                        break;
                    case " Merchant Response Date":
                        FluentWaitForWebElement(MerchantResponseDate);
                        break;
                    case " Pre-Arbitration Details ":
                        FluentWaitForWebElement(PreArbitrationDetails);
                        break;
                    case " Date Requested":
                        FluentWaitForWebElement(DateRequested);
                        break;
                    case " Resolution":
                        FluentWaitForWebElement(Resolution);
                        break;
                    case " Date Research Ended":
                        FluentWaitForWebElement(DateResearchEnded);
                        break;
                    case " Date Resolution Letter Sent":
                        FluentWaitForWebElement(ResolutionLetter);
                        break;
                    case " Processor Chargeback":
                        FluentWaitForWebElement(ProcessorChargeback);
                        break;
                    case " Amount Recovered ":
                        FluentWaitForWebElement(AmountRecovered);
                        break;
                    case " Provisional Date":
                        FluentWaitForWebElement(ProvisionalDate);
                        break;
                    case " Final Date":
                        FluentWaitForWebElement(FinalDate);
                        break;
                }
            }
        }
        public void AssertUIControlsOnDocumentsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Document List":
                        FluentWaitForWebElement(DocumentsList);
                        break;
                }
            }
        }
        public void AssertUIControlsOnHistoryPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Date":
                        FluentWaitForWebElement(Date);
                        break;
                    case " Description":
                        FluentWaitForWebElement(Description);
                        break;
                    case " By":
                        FluentWaitForWebElement(By);
                        break;
                    case " Type":
                        FluentWaitForWebElement(Type2);
                        break;
                }
            }
        }
        public void AssertFieldslsOnResolutionPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Pending":
                        FluentWaitForWebElement(Pending);
                        break;
                    case " Claim Approved":
                        FluentWaitForWebElement(ClaimApproved);
                        break;
                    case " Claim Declined":
                        FluentWaitForWebElement(ClaimDeclined);
                        break;
                    case " Merchant Credit":
                        FluentWaitForWebElement(MerchantCredit);
                        break;
                    case " Not Selected":
                        FluentWaitForWebElement(NotSelected);
                        break;
                    case " Bank Loss":
                        FluentWaitForWebElement(BankLoss);
                        break;
                    case " Merchant Loss":
                        FluentWaitForWebElement(MerchantLoss);
                        break;
                    case " Consumer Loss":
                        FluentWaitForWebElement(ConsumerLoss);
                        break;
                    case " Amount Recovered":
                        FluentWaitForWebElement(AmountRecovered2);
                        break;
                    case " Provisional Date":
                        FluentWaitForWebElement(ProvisionalDate2);
                        break;
                    case " Final Date":
                        FluentWaitForWebElement(FinalDate2);
                        break;
                    case " Credit Customer Account For":
                        FluentWaitForWebElement(DebitAccount);
                        break;
                    case " Debit  Customer Account For":
                        FluentWaitForWebElement(CreditAccount);
                        break;
                    case " Merchant Credited Customer For":
                        FluentWaitForWebElement(MerchantCreditedCustomer);
                        break;
                    case " Resolve and Post to GL ":
                        FluentWaitForWebElement(PosttoGL);
                        break;
                    case " Save":
                        FluentWaitForWebElement(Save2);
                        break;
                    case " Close":
                        FluentWaitForWebElement(Close);
                        break;
                }
            }
        }
    }
}
