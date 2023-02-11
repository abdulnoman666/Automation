using System;
using System.Collections.Generic;
using System.Text;

namespace FinboaAPITestAutomation.WorkflowAutomations
{
    internal class WorkflowAutomation
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Scope { get; set; }
        public string Conditions { get; set; }
        public string Reference { get; set; }
        public List<WorkflowSteps> workflowSteps { get; set; }
    }

    public class WorkflowSteps
    {
        public string charter { get; set; }
        public string distributionList { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int order { get; set; }
        public int parentStepId { get; set; }
        public string tableName { get; set; }
        public string value { get; set; }
        public string value2 { get; set; }
        public int workflowId { get; set; }

    }
}
