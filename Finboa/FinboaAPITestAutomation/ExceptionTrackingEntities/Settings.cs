using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionTrackingEntities
{
    public class Settings
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public bool ShowAfterReviewed { get; set; }

        public bool SendExceptionEmails { get; set; }

        public bool BranchManagerOverrideAccountCsr { get; set; }

        public bool EnableCases { get; set; }
    }
}
