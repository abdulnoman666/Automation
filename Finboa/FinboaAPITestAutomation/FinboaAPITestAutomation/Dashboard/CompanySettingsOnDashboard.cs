using System;
using System.Collections.Generic;
using System.Text;

namespace FinboaAPITestAutomation.Dashboard
{
    internal class CompanySettingsOnDashboard
    {
      public int Id { get; set; }
        public int CompanyId { get; set; }
        public int PcDays { get; set; }
        public string AuditStart { get; set; }
        public string AuditEnd { get; set; }
        public string DailyGLCutOff { get; set; }
        public Boolean HideAddress2 { get; set; }
        public Boolean HideAddress3 { get; set; }
        public Boolean HideAddress4 { get; set; }
        public Boolean HideCity { get; set; }
        public Boolean HideState { get; set; }
        public Boolean HideZip { get; set; }
        public Boolean PostOnSaturdays { get; set; }
        public Boolean Post7Days { get; set; }
        public Boolean UseLastBusinessDay { get; set; }
    }
}
