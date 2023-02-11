using System;
using System.Collections.Generic;
using System.Text;

namespace FinboaAPITestAutomation.Dashboard
{
    internal class BankLossTotalByYearOnDashboard
    {
        public int Period { get; set; }
        public float BankLossTotal { get; set; }
        public float MerchantLossTotal { get; set; }
        public float CustomerLossTotal { get; set; }
        public float PendingTotal { get; set; }
        public float BankLossPC { get; set; }
        public float BankLossRecovered { get; set; }
        public float MerchantLossPC { get; set; }
        public float MerchantLossRecovered { get; set; }
    }
}
