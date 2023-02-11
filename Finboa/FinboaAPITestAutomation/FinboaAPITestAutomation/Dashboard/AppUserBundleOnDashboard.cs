using System;
using System.Collections.Generic;
using System.Text;

namespace FinboaAPITestAutomation.Dashboard
{
    internal class AppUserBundleOnDashboard
    {
        public User bundle_user { get; set; }
        public Company bundle_company { get; set; }
        public CompanySetting bundle_companySetting { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
        public string Role { get; set; }
        public string SystemRole { get; set; }
        public Boolean IsDeleted { get; set; }
        public Boolean Status { get; set; }
        public Boolean HasAccount { get; set; }
        public Boolean ChangePassword { get; set; }
        public string UniqueId { get; set; }
        public string Title { get; set; }
        public Boolean RoleChanged { get; set; }
    }

    public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedOn { get; set; }
        public string Logo { get; set; }
        public string LogoStoragePath { get; set; }
        public string ResponseEmail { get; set; }
        public string StripeCustomerId { get; set; }
        public string ActiveUntil { get; set; }
        public string CreditCardExpires { get; set; }
        public string EmailDistributionList { get; set; }
        public Boolean DefaultMEStatement { get; set; }
        public int DefaultCycleDay { get; set; }
        public float MinClaim { get; set; }
        public Boolean CardValidation { get; set; }
        public Boolean NonFraudSubmission { get; set; }
        public Boolean Active { get; set; }
        public Boolean CustomerUploadInProgress { get; set; }
        public Boolean UsePrefix { get; set; }
        public int Processor { get; set; }
        public string Domain { get; set; }
        public int MasterCompanyId { get; set; }
        public int IdleTime { get; set; }
        public Boolean Integrated { get; set; }
        public string TimeZone { get; set; }
        public string Routing { get; set; }
        public string Ein { get; set; }
        public string CustomerAppLink { get; set; }
        public string CustomerAppReadOnly { get; set; }
        public string Redirect { get; set; }
        public int CardDigits { get; set; }
        public int AccountDigits { get; set; }
        public int CamsImportConfigurationId { get; set; }
        public int CustomersImportConfigurationId { get; set; }
        public int TransactionsImportConfigurationId { get; set; }
        public string ApiLink { get; set; }
        public string SignaturePad { get; set; }
        public string SoftwareVersion { get; set; }
        public string ReleaseVersion { get; set; }
        public string KeyVersion { get; set; }
        public string KeyGUID { get; set; }
        public string KeyVersionDR { get; set; }
    }

    public class CompanySetting
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int PcDays { get; set; }
        public string AuditStart { get; set; }
        public string AuditEnd { get; set; }
        public string DailyGLCutOff { get; set; }
        public Boolean HideAddress2 { get; set; }
        public Boolean HideAddress3 { get; set; }
        public Boolean HideAddress4 { get; set; }
        public Boolean HideCity { get; set; }
        public Boolean HideState { get; set; }
        public Boolean HideZip { get; set; }
        public Boolean PostOnSaturdays { get; set; }
        public Boolean Post7Days { get; set; }
        public Boolean UseLastBusinessDay { get; set; }
    }
}
