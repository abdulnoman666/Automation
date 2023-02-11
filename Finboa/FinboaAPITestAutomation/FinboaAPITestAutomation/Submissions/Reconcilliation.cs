using System;
using System.Collections.Generic;
using System.Text;

namespace FinboaAPITestAutomation.Submissions
{
    internal class Reconcilliation
    {
        public int DisputeId { get; set; }
        public int CompanyId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Status { get; set; }
        public string Source { get; set; }
        public int DisputeType { get; set; }
        public float Total { get; set; }
        public float ProvisionalCredit { get; set; }
        public string ProvisionalCreditDate { get; set; }
        public float ProvisionalCreditReverseAmount { get; set; }
        public float MerchantCredit { get; set; }
        public string MerchantCreditDate { get; set; }
        public float FinalCredit { get; set; }
        public string FinalCreditDate { get; set; }
        public float InsuranceAmount { get; set; }
        public float ChargebackAmount { get; set; }
        public float OtherFees { get; set; }
        public string ReportedOn { get; set; }
    }
}
