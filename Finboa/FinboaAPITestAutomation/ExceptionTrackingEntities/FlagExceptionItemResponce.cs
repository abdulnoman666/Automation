using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionTrackingEntities
{
    public class FlagExceptionItemResponce
    {

        public bool Cleared { get; set; }

        public object ClearedBy { get; set; }

        public object ClearedOn { get; set; }

        public long CompanyId { get; set; }

        public long CreatedBy { get; set; }

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


        public Account account { get; set; }

        public object AccountCloseDate { get; set; }

        public int AccountId { get; set; }

        public string AccountNumber { get; set; }

        public object AccountOfficer { get; set; }

        public int OfficerId { get; set; }

        public object ProductName { get; set; }

        public bool TrackExpiration { get; set; }

        public bool Flagged { get; set; }

        public FlaggedBy FlaggedBy { get; set; }

        public string FlaggedOn { get; set; }

        public object AccountOpenDate { get; set; }

        public object RaisedBy { get; set; }

        public object RefNumber { get; set; }

        public object DateOpened { get; set; }

        public object CreatedDate { get; set; }

        public object LastNote { get; set; }

        public object AccountBranch { get; set; }
    }

    public partial class Account
    {
        
        public long Id { get; set; }
        public long CompanyId { get; set; }
        public string AccountNumber { get; set; }
        public object Category { get; set; }
        public long OfficerId { get; set; }
        public string ProductName { get; set; }
        public object ClosingDate { get; set; }
        public object ApplicationDate { get; set; }
        public object PassPhrase { get; set; }
        public long BranchId { get; set; }
        public long NewAccountRepId { get; set; }
        public object CifNumber { get; set; }
        public object DateOpened { get; set; }
        public bool AccountClosed { get; set; }
        public object DateClosed { get; set; }
        public long BranchManagerId { get; set; }
        public object ReviewComplete { get; set; }
        public long ReviewCompletedBy { get; set; }
        public long RegionalManagerId { get; set; }
        public object LastActivityDate { get; set; }
        public string CreatedOn { get; set; }
        public long CreatedBy { get; set; }
        public string UpdatedOn { get; set; }
        public long UpdatedBy { get; set; }
    }

    public partial class ExceptionDefinition
    {

        public long Id { get; set; }
        public long CompanyId { get; set; }
        public string Type { get; set; }
        public object Category { get; set; }
        public string Name { get; set; }
        public bool Account { get; set; }
        public bool Customer { get; set; }
        public bool TrackExpiration { get; set; }
        public bool CustomerFacing { get; set; }
        public string DistributionList { get; set; }
        public object ProductList { get; set; }
        public bool Deactivate { get; set; }
    }

    public partial class FlaggedBy
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
        public long CompanyId { get; set; }
        public string Role { get; set; }
        public bool IsDeleted { get; set; }
        public bool Status { get; set; }
        public bool HasAccount { get; set; }
        public bool ChangePassword { get; set; }
        public object Branch { get; set; }
        public bool SeeAllReadOnly { get; set; }
        public object CoreReference { get; set; }
    }

}
