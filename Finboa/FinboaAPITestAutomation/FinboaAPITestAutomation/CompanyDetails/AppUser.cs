using System;
using System.Collections.Generic;
using System.Text;

namespace FinboaAPITestAutomation.CompanyDetails
{
    internal class AppUser
    {
        public int Id { get; set; }
        public string CompanyId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public string MobilePhone { get; set; }
        public string Role { get; set; }
        public string SystemRole { get; set; }
        public Boolean IsDeleted { get; set; }
        public Boolean Status { get; set; }
        public Boolean HasAccount { get; set; }
        public Boolean ChangePassword { get; set; }
        public int UniqueId { get; set; }
        public string Title { get; set; }
        public Boolean RoleChanged { get; set; }

    }
}
