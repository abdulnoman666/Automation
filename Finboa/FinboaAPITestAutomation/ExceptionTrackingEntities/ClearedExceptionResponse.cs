using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionTrackingEntities
{
    public class ClearedExceptionResponse
    {

        public bool Cleared { get; set; }
        public ClearedBy ClearedBy { get; set; }

        public string ClearedOn { get; set; }
        public int CompanyId { get; set; }

        public int CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public object Customer { get; set; }
        public bool CustomerFacing { get; set; }
        public int CustomerId { get; set; }
        public object CustomerOfficer { get; set; }
        public object NewAccountRep { get; set; }
        public object BranchManager { get; set; }
        public object AssignedTo { get; set; }
        public object AssignedToTeller { get; set; }
        public string ExceptionContext { get; set; }
        public ExceptionDefinition ExceptionDefinition { get; set; }
        public int ExceptionDefinitionId { get; set; }
        public string ExceptionName { get; set; }
        public object ExceptionNotes { get; set; }
        public string ExceptionType { get; set; }
        public object ExpirationDate { get; set; }
        public int Id { get; set; }
        public Account Account { get; set; }
        public object AccountCloseDate { get; set; }
        public int AccountId { get; set; }
        public string AccountNumber { get; set; }
        public object AccountOfficer { get; set; }
        public int OfficerId { get; set; }
        public object ProductName { get; set; }
        public bool TrackExpiration { get; set; }
        public bool Flagged { get; set; }
        public object FlaggedBy { get; set; }
        public object FlaggedOn { get; set; }
        public object AccountOpenDate { get; set; }
        public object RaisedBy { get; set; }
        public object RefNumber { get; set; }
        public object DateOpened { get; set; }
        public object CreatedDate { get; set; }
        public LastNote LastNote { get; set; }
        public object AccountBranch { get; set; }
    }

    public partial class ClearedBy
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
        public object Branch { get; set; }
        public bool SeeAllReadOnly { get; set; }
        public object CoreReference { get; set; }
    }


    public partial class LastNote
    {

        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string ObjectType { get; set; }
        public int ObjectId { get; set; }
        public string Description { get; set; }
        public string CreatedOn { get; set; }
        public int CreatedBy { get; set; }
    }

}
