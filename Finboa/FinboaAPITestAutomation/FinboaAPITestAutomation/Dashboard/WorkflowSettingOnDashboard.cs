using System;
using System.Collections.Generic;
using System.Text;

namespace FinboaAPITestAutomation.Dashboard
{
    internal class WorkflowSettingOnDashboard
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Source { get; set; }
        public string CustomerDescription { get; set; }
        public Boolean CustomerAccess { get; set; }
        public Boolean FraudNonFraud { get; set; }
        public Boolean AddTransactions { get; set; }
        public string SearchBy { get; set; }
        public string TransactionType { get; set; }
        public Boolean HasQuestionnaire { get; set; }
        public string DisputeScreenType { get; set; }
        public string DistributionList { get; set; }
        public string TransactionSearchCondition { get; set; }
        public string TransactionNotAllowedCondition { get; set; }
        public string AccountSearchCondition { get; set; }
        public string StatusList { get; set; }
        public Boolean ProvisionalCreditCalc { get; set; }
        public string ComplianceRegulationScreen { get; set; }
        public string EmailTemplateReference { get; set; }
        public string ConfirmationEmailTemplateReference { get; set; }
        public string ConfirmationAutomationReference { get; set; }
        public Boolean CustomerType { get; set; }
        public int PcDays { get; set; }
        public Boolean PcBusinessDays { get; set; }
        public int ResolutionDays { get; set; }
        public int AltResolutionDays { get; set; }
        public Boolean ResolutionBusinessDays { get; set; }
        public Boolean AllowManualTransactions { get; set; }
        public Boolean PopulateMerchantField { get; set; }
        public Boolean CopyTransactions { get; set; }
        public string ClosedAccountCondition { get; set; }
        public string EventNotifications { get; set; }
        public Boolean AutoFeeReimbursement { get; set; }
        public string FeeTransactionCode { get; set; }
        public string FeeGLReference { get; set; }
        public int LetterId { get; set; }
        public int ElectronicConsentLetterId { get; set; }
        public string LetterDataCondition { get; set; }
        public Boolean UseOnlineContent { get; set; }
        public Boolean ByTransaction { get; set; }
        public Boolean UseCardHolderNameforBusiness { get; set; }
        public Boolean ReadOnlyQuestionnaire { get; set; }
        public Boolean HideSendToCustomer { get; set; }
        public Boolean HideCustomerAcknowledgementForm { get; set; }
        public Boolean DisableCustomerNameEdit { get; set; }
        public Boolean EnableCloseScreenMessage { get; set; }
        public string MerchantCopySource { get; set; }
        public string InterestPostingGLReference { get; set; }
        public Boolean HideCommentsAndResolutionField { get; set; }
        public string VerbiageFraud { get; set; }
        public string VerbiageNonFraud { get; set; }
    }
}
