using System;
using System.Collections.Generic;
using System.Text;

namespace FinboaAPITestAutomation.Dashboard
{
    internal class TrendsOnDashboard
    {
        public string Period { get; set; }
        public float TotalDisputes { get; set; }
        public float BankLosses { get; set; }
        public float MerchantLosses { get; set; }
        public float CustomerLoss { get; set; }
        public float Pending { get; set; }
    }
}
