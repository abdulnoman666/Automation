using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionTrackingAPITestAutomation.OpenItems
{
    internal class ActiveUser
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
        public int CompanyId { get; set; }
        public string Role { get; set; }
        public bool IsDeleted { get; set; }
        public bool Status { get; set; }
        public bool HasAccount { get; set; }
        public bool ChangePassword { get; set; }
        public string Branch { get; set; }
        public bool SeeAllReadOnly { get; set; }
        public string CoreReference { get; set; }
    }
}
