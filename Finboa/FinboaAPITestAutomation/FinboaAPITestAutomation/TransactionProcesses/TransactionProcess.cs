using System;
using System.Collections.Generic;
using System.Text;

namespace FinboaAPITestAutomation.TransactionProcesses
{
    internal class TransactionProcess
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Description { get; set; }
        public string GLReference { get; set; }
        public string ProcessType { get; set; }
        public string[] WorkflowIds { get; set; }
    }
}
