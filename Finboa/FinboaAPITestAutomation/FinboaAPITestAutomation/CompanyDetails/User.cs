using System;
using System.Collections.Generic;
using System.Text;

namespace FinboaAPITestAutomation.CompanyDetails
{
    internal class User
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedOn { get; set; }
        public string Logo { get; set; }
        public string LogoStoragePath { get; set; }
        public string ResponseEmail { get; set; }
        public int StripeCustomerId { get; set; }
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
        public Boolean CustomerAppReadOnly { get; set; }
        public Boolean Redirect { get; set; }
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
}
