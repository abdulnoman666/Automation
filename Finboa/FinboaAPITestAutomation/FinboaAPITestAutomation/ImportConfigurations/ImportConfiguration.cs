using System;
using System.Collections.Generic;
using System.Text;

namespace FinboaAPITestAutomation.ImportConfigurations
{
    internal class ImportConfiguration
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Description { get; set; }
        public int Delimiter { get; set; }
        public Boolean HasHeaderRow { get; set; }
        public string FieldListName { get; set; }
    }
}
