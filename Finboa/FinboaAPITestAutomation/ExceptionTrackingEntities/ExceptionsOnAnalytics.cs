using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionTrackingEntities
{
    public class ExceptionsOnAnalytics
    {
        public bool Cleared { get; set; }
        public string ClearedBy { get; set; }
        public string ClearedOn { get; set; }
        public int CompanyId { get; set; }
        public int CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string Customer { get; set; }
        public bool CustomerFacing { get; set; }
        public int CustomerId { get; set; }
        public AccountOfficer CustomerOfficer { get; set; }
        public AccountOfficer NewAccountRep { get; set; }
        public AccountOfficer BranchManager { get; set; }

        public string AssignedTo { get; set; }
        public AssignedToTeller assignedToTeller { get; set; }
        public string ExceptionContext { get; set; }

        public string ExceptionDefinition { get; set; }
        public int ExceptionDefinitionId { get; set; }
        public string ExceptionName { get; set; }
        public string ExceptionNotes { get; set; }
        public string ExceptionType { get; set; }
        public string ExpirationDate { get; set; }
        public int Id { get; set; }
        public string Account { get; set; }
        public string AccountCloseDate { get; set; }
        public int AccountId { get; set; }
        public string AccountNumber { get; set; }
        public AccountOfficer AccountOfficer { get; set; }
        public int OfficerId { get; set; }
        public string ProductName { get; set; }
        public bool TrackExpiration { get; set; }
        public bool Flagged { get; set; }
        public string FlaggedBy { get; set; }
        public string FlaggedOn { get; set; }
        public string AccountOpenDate { get; set; }
        public string RaisedBy { get; set; }
        public string RefNumber { get; set; }
        public string DateOpened { get; set; }
        public string CreatedDate { get; set; }
        public string LastNote { get; set; }
        public AccountBranch accountBranch { get; set; }
    }

    public  class AccountBranch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Reference { get; set; }
        public int ManagerId { get; set; }
        public int CompanyId { get; set; }
        public int CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string DateOpened { get; set; }
    }

    public partial class AccountOfficer
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

    public partial class AssignedToTeller
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
