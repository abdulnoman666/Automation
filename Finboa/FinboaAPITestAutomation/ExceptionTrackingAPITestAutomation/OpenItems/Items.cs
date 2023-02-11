using System.Collections.Generic;

namespace ExceptionTrackingAPITestAutomation.OpenItems
{
    public class Items
    {
        public int TotalCount { get; set; }
        public List<ItemDetails> items { get; set; }
    }

    public class ItemDetails
    {
        public int RowNumber { get; set; }
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string AccountNumber { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string ExceptionName { get; set; }
        public string ProductName { get; set; }
        public string CreatedOn { get; set; }
        public string RaisedOn { get; set; }
        public string ExpirationDate { get; set; }
        public int AssignToId { get; set; }
        //public Dictionary<int, AssignedToDetails> AssignedTo { get; set; }
        public AssignedToDetails AssignedTo { get; set; }

        public string assignedToTellerId { get; set; }
        public AssignedToTeller assignedToTeller { get; set; }

        public string AccountNARId { get; set; }
        public string CustomerNARId { get; set; }
        public NewAccountRepDetails NewAccountRep { get; set; }
        public string AccountOfficerId { get; set; }
        public string CustomerOfficerId { get; set; }
        public OfficerDetails Officer { get; set; }
        public string AccountBMId { get; set; }
        public string CustomerBMId { get; set; }
        public BranchManagerDetails BranchManager { get; set; }
        public int AccountRMId { get; set; }
        public string CustomerRMId { get; set; }
        public RegionalManager regionalManager { get; set; }
        public string PrimaryCustomerId { get; set; }
        public string PrimaryCustomerName { get; set; }
        public string DistributionList { get; set; }
        public string LastNote { get; set; }
        public int ExceptionDefinitionId { get; set; }
        public bool Flagged { get; set; }
        public bool TrackExpiration { get; set; }
    }

    public class AssignedToDetails
    {
        public string id { get; set; }
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
        public string Correfference { get; set; }
    }


    public class NewAccountRepDetails
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
        public bool CoreReference { get; set; }
    }

    public class RegionalManager
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

    public class AssignedToTeller
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


    public class OfficerDetails
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


    
    public class BranchManagerDetails
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
