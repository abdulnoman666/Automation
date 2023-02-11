using System;
using System.Collections.Generic;
using System.Text;

namespace FinboaAPITestAutomation.FieldUpdateScripts
{
    internal class FieldUpdate
    {
        public int Id { get; set; }
        public List<UpdateRecords> updateRecords { get; set; }
        public string AutomationName { get; set; }
        public string Reference { get; set; }
        public int CompanyId { get; set; }
    }

    public class UpdateRecords
    {
        public int id { get; set; }
        public int AutomationScriptId { get; set; }
        public string Field { get; set; }
        public string OperatorAction { get; set; }
        public string Value { get; set; }
        public string TableName { get; set; }
    }

}
