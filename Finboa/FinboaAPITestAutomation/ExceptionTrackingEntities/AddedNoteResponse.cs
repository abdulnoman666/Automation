using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionTrackingEntities
{
    public class AddedNoteResponse
    {
        public long Id { get; set; }
        public long CompanyId { get; set; }
        public string ObjectType { get; set; }
        public long ObjectId { get; set; }
        public string Description { get; set; }
        public string CreatedOn { get; set; }
        public long CreatedBy { get; set; }
    }
}
