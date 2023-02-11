using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionTrackingEntities
{
    public class Checklists
    {
        public List<ExceptionLink> ExceptionLinks { get; set; }
        public List<ExceptionList> ExceptionList { get; set; }
        public Checklist Checklist { get; set; }
    }

    public partial class Checklist
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string CreatedOn { get; set; }
        public int CreatedBy { get; set; }
    }

    public partial class ExceptionLink
    {
        public int Id { get; set; }
        public int ChecklistId { get; set; }
        public int ExceptionDefinitionId { get; set; }
        public string CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public int Order { get; set; }
    }

    public partial class ExceptionList
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public bool Account { get; set; }
        public bool Customer { get; set; }
        public bool TrackExpiration { get; set; }
        public bool CustomerFacing { get; set; }
        public string DistributionList { get; set; }
        public string ProductList { get; set; }
        public bool Deactivate { get; set; }
    }

}
