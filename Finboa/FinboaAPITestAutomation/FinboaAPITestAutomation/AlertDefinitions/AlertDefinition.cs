using System;
using System.Collections.Generic;
using System.Text;

namespace FinboaAPITestAutomation.AlertDefinitions
{
    internal class AlertDefinition
    {
        public int Id { get; set; }
        public string AlertName { get; set; }
        public long AlertType { get; set; }
        public string TableName { get; set; }
        public int CompanyId { get; set; }
        public string CreatedOn { get; set; }
        public string AlertTypeString { get; set; }
        public string DeadlineReference { get; set; }
        public bool BusinessDays { get; set; }
        public bool CalculateTheLastBusinessDay { get; set; }
        public int Days { get; set; }
        public string Explanation { get; set; }
        public string Reference { get; set; }
        public string SourceList { get; set; }
        public AlertCriteria Criteria { get; set; }
    }

    public class AlertCriteria
    {
        public string ComparisonValue { get; set; }
        public long DefinitionId { get; set; }
        public string FieldName { get; set; }
        public long FieldType { get; set; }
        public string FieldTypeString { get; set; }
        public long Id { get; set; }
        public string logicalOperator { get; set; }
        public string Operator { get; set; }
        public long Order { get; set; }
    }
}
