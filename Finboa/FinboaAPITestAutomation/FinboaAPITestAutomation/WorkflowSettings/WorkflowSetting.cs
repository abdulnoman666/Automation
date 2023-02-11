using System;
using System.Collections.Generic;
using System.Text;

namespace FinboaAPITestAutomation.WorkflowSettings
{
    internal class WorkflowSetting
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Scope { get; set; }
        public string Conditions { get; set; }
        public string Reference { get; set; }
    }
}
