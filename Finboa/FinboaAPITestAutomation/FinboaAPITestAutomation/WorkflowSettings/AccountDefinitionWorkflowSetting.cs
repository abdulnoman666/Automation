using System;
using System.Collections.Generic;
using System.Text;

namespace FinboaAPITestAutomation.WorkflowSettings
{
    internal class AccountDefinitionWorkflowSetting
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int Account { get; set; }
        public int TransactionCode { get; set; }
        public int OffsetTransactionCode { get; set; }
        public string Description { get; set; }
        public string OffsetDescription { get; set; }
        public string Reference { get; set; }
        public string BranchCode { get; set; }
        public string Source { get; set; }
        public Boolean isDeleted { get; set; }
        public string Charter { get; set; }
        public string AccountType { get; set; }
        public string TransferAccount { get; set; }
        public string TransferAccountType { get; set; }
        public string TransferTransactionCode { get; set; }
        public string TransferDescription { get; set; }
        public int BaseAccountId { get; set; }
        public string AccountOwnershipType { get; set; }
        public string GlBranchCode { get; set; }
        public string GlCostCenter { get; set; }
        public string TransferGLBranchCode { get; set; }
        public string TransferCostCenter { get; set; }
    }
}
