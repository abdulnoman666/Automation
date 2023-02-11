using NUnit.Framework;
using RestSharp;
using System;

namespace FinboaAPITestAutomation
{
    internal static class RequestHelper
    {
        public static RestRequest CreateCustomerRequest(RestRequest request, string account, string accountOwnership, string accountStatus, string accountType, string address, string branch,
            string cardnumber, string charter, string cifNumber, string city, int cycleDay, string cycleDayString, string email, string hPhone, string name, bool nextBusinessDayStatement,
            string oPhone, string phone, string state, string zip)
        {
            request.AddJsonBody(new
            {
                account,
                accountOwnership,
                accountStatus,
                accountType,
                address,
                branch,
                cardnumber,
                charter,
                cifNumber,
                city,
                cycleDay,
                cycleDayString,
                email,
                hPhone,
                name,
                nextBusinessDayStatement,
                oPhone,
                phone,
                state,
                zip
            });

            return request;
        }

        internal static RestRequest CreateAddGLLedgerDefinitionRequest(RestRequest request, string transferType, string transactionType, string customerTransactionCode, string customerLedgerDescription, string glAccount, string glCode, string glTransactionCode, string glBranchCode, string glCostCenter, string glDescription, string reference, string workflow, string branch, string customerType)
        {
            request.AddJsonBody(new
            {
                transferType = transferType,
                transactionType = transactionType,
                customerTransactionCode = customerTransactionCode,
                customerLedgerDescription = customerLedgerDescription,
                glAccount = glAccount,
                glCode = glCode,
                glTransactionCode = glTransactionCode,
                glBranchCode = glBranchCode,
                glCostCenter = glCostCenter,
                glDescription = glDescription,
                reference = reference,
                workflow = workflow,
                branch = branch,
                customerType = customerType,
            });

            return request;
        }

        internal static RestRequest AddNotesRequest(RestRequest request, string customerDisputeId, int customerId, bool isBackoffice, string notes)
        {
            request.AddJsonBody(new
            {
                customerDisputeId,
                customerId,
                isBackoffice,
                notes
            });
            return request;
        }

        internal static RestRequest CreateAlertDefinitionRequest(RestRequest request, string alertName, string alertTypeString, bool businessDays, bool calculateTheLastBusinessDay, string days, string deadlineReference, string reference, string sourceList, string tableName)
        {
            request.AddJsonBody(new
            {
                alertName,
                alertTypeString,
                businessDays,
                calculateTheLastBusinessDay,
                days,
                deadlineReference,
                reference,
                sourceList,
                tableName
            });

            return request;
        }

        internal static RestRequest CreateClaimResearchRequest(RestRequest request, int accountType, int amountPreventedByFDS, int amountReceived, string amountRecoveredCDC, string amountRecoveredProvisionalDate, int assignedBy, string assignedOn, int assignedTo, string assignedToName, int batchNumber,
            string camsCaseNumber, string camsReportDate, bool cardPresent, string caseReference, string chargeBackDate, int claimResult, string closedOn, string comments, int companyId, string companyResponseDate, int consumerLiability, string createdOn, int creditAmount, string creditDate, string customerDisputeDescription,
            int customerDisputeId, string customerEmail, int customerID, string customerName, string dateCaseFiled, string dateDNFraudFiled, string dateLostStolen, string dateRecovered, string dateResarchEnded, int ddaCreditAmount, int ddaDebitAmount, int debitAmount, string declineAmount, string declineDate,
            string denialReason, int disputeResolution, int disputeStatus, int disputeType, string finalChargeback, string finalDenialReason, string finalResolutionDate, bool foreignTransaction, int id, bool isaFee, string location, int merchantCreditAmount, string merchantCreditDate, string merchantName, string merchantResponseDate,
            bool pos, string preArbCredit, string preArbDate, int prearbCredit2, string prearbDate, string provisionalChargeBackDate, string provisionalChargeBackRemovedDate, string provisionalChargebackRecieved, string provisionalChargebackRemoved, string provisionalCredit, int provisionalCreditAmount, string reportedOn, string representmentDocumentsReceviedFromProcessor,
            string representmentDocumentsSenttoCardholder, string representmentRebuttalSenttoProcessor, string researchStatus, string resolutionDeadline, string resolutionNoticeSent, string reversalDate, string reverseAmount, string settlementDate, string source, string statementDate, int transactionAmount, string transactionDate, int transactionId, int workflowId, string workflowName)
        {
            request.AddJsonBody(new
            {
                accountType,
                amountPreventedByFDS,
                amountReceived,
                amountRecoveredCDC,
                amountRecoveredProvisionalDate,
                assignedBy,
                assignedOn,
                assignedTo,
                assignedToName,
                batchNumber,
                camsCaseNumber,
                camsReportDate,
                cardPresent,
                caseReference,
                chargeBackDate,
                claimResult,
                closedOn,
                comments,
                companyId,
                companyResponseDate,
                consumerLiability,
                createdOn,
                creditAmount,
                creditDate,
                customerDisputeDescription,
                customerDisputeId,
                customerEmail,
                customerID,
                customerName,
                dateCaseFiled,
                dateDNFraudFiled,
                dateLostStolen,
                dateRecovered,
                dateResarchEnded,
                ddaCreditAmount,
                ddaDebitAmount,
                debitAmount,
                declineAmount,
                declineDate,
                denialReason,
                disputeResolution,
                disputeStatus,
                disputeType,
                finalChargeback,
                finalDenialReason,
                finalResolutionDate,
                foreignTransaction,
                id,
                isaFee,
                location,
                merchantCreditAmount,
                merchantCreditDate,
                merchantName,
                merchantResponseDate,
                pos,
                preArbCredit,
                preArbDate,
                prearbCredit2,
                prearbDate,
                provisionalChargeBackDate,
                provisionalChargeBackRemovedDate,
                provisionalChargebackRecieved,
                provisionalChargebackRemoved,
                provisionalCredit,
                provisionalCreditAmount,
                reportedOn,
                representmentDocumentsReceviedFromProcessor,
                representmentDocumentsSenttoCardholder,
                representmentRebuttalSenttoProcessor,
                researchStatus,
                resolutionDeadline,
                resolutionNoticeSent,
                reversalDate,
                reverseAmount,
                settlementDate,
                source,
                statementDate,
                transactionAmount,
                transactionDate,
                transactionId,
                workflowId,
                workflowName
            });

            return request;
        }

        internal static RestRequest CreateDeleteCustomerGLDefintionRequest(RestRequest request, string account, string accountOwnershipType, string accountType, string baseAccountId, string branchCode, string companyId, string description, string glBranchCode, string glCode, string glCostCenter, string id, string isDeleted, string offsetDescription, string offsetTransactionCode, string reference, string source, string transactionCode, string transactionType)
        {
            request.AddJsonBody(new
            {
                account,
                accountOwnershipType,
                accountType,
                baseAccountId,
                branchCode,
                companyId,
                description,
                glBranchCode,
                glCode,
                glCostCenter,
                id,
                isDeleted,
                offsetDescription,
                offsetTransactionCode,
                reference,
                source,
                transactionCode,
                transactionType
            });

            return request;
        }

        internal static RestRequest DeleteAlertDefinitionRequest(RestRequest request, string alertCriteria, string alertName, string alertType, string alertTypeString, string businessDays, string calculateTheLastBusinessDay, string companyId, string createdOn, string days, string deadlineReference, string explanation, string id, string reference, string sourceList, string tableName)
        {
            request.AddJsonBody(new
            {
                alertCriteria,
                alertName,
                alertType,
                alertTypeString,
                businessDays,
                calculateTheLastBusinessDay,
                companyId,
                createdOn,
                days,
                deadlineReference,
                explanation,
                id,
                reference,
                sourceList,
                tableName
            });

            return request;
        }

        internal static RestRequest CreateUpdateAlertDefinitionRequest(RestRequest request, string aAlertCriteria, string uAlertName, string aAlertType, string uAlertTypeString, bool uBusinessDays, bool uCalculateTheLastBusinessDay, string aCompanyId, string aCreatedOn, string uDays, string uDeadlineReference, string aExplanation, string aId, string uReference, string uSourceList, string uTableName)
        {
            request.AddJsonBody(new
            {
                aAlertCriteria,
                uAlertName,
                aAlertType,
                uAlertTypeString,
                uBusinessDays,
                uCalculateTheLastBusinessDay,
                aCompanyId,
                aCreatedOn,
                uDays,
                uDeadlineReference,
                aExplanation,
                aId,
                uSourceList,
                uTableName
            });

            return request;
        }

        internal static RestRequest CreateReconRequest(RestRequest request, int chargebackAmount, int companyId, string customerName,
            int disputeId, int disputeType, int finalCredit, int insuranceAmount, int merchantCredit, int otherFees,
            int provisionalCredit, string reportedOn, string source, string status, int total)
        {
            request.AddJsonBody(new
            {
                chargebackAmount,
                companyId,
                customerName,
                disputeId,
                disputeType,
                finalCredit,
                insuranceAmount,
                merchantCredit,
                otherFees,
                provisionalCredit,
                reportedOn,
                source,
                status,
                total,
            });

            return request;
        }

        internal static RestRequest CreateUpdateReportedOnDate(RestRequest request, string date)
        {
            request.AddJsonBody(new
            {
                date
            });
            return request;
        }
        internal static RestRequest CreateReassignDisputeRequest(RestRequest request, int accountType, int assignedBy, string assignedOn,
            int assignedTo, string caseReference, int companyId, string companyName, bool converted, string convertedOn, int createdBy,
            string createdOn, int customerID, string customerName, int customerReferenceClaims, int customerReferenceDisputes, string disputeList,
            int disputeOption, int disputeType, string documentList, int id, int past, int pastClaims, int pendingTransactions, string reportedOn,
            string source, string status, string thirdPartyBreach, int total, int transactionCount, int transaction, string workflowName)
        {
            request.AddJsonBody(new
            {
                accountType,
                assignedBy,
                assignedOn,
                assignedTo,
                caseReference,
                companyId,
                companyName,
                converted,
                convertedOn,
                createdBy,
                createdOn,
                customerID,
                customerName,
                customerReferenceClaims,
                customerReferenceDisputes,
                disputeList,
                disputeOption,
                disputeType,
                documentList,
                id,
                past,
                pastClaims,
                pendingTransactions,
                reportedOn,
                source,
                status,
                thirdPartyBreach,
                total,
                transactionCount,
                transaction,
                workflowName
            });

            return request;
        }

        internal static RestRequest CreateSubmitDisputeRequest(RestRequest request, int accountType, int cardId, int customerId, string customerName, string disputeReason, int disputeType, string email, int letterWorkflowId, string phone, string source, int amount, string merchant, string transactionDate)
        {
            request.AddJsonBody(new
            {
                accountType,
                cardId,
                customerId,
                customerName,
                disputeReason,
                disputeType,
                email,
                letterWorkflowId,
                phone,
                source,
                amount,
                merchant,
                transactionDate
            });

            return request;
        }

        internal static RestRequest CreateManualTransactionRequest(RestRequest request, int amount, string merchant, string transactionDate)
        {
            request.AddJsonBody(new
            {
                amount,
                merchant,
                transactionDate
            });

            return request;
        }

        internal static RestRequest CreateFieldUpdateSciptRequest(RestRequest request, string automationName, string reference)
        {
            request.AddJsonBody(new
            {
                automationName,
                reference
            });

            return request;
        }

        internal static RestRequest DeleteFieldUpdateScriptRequest(RestRequest request, string automationName, int companyId, int id, string automationReference)
        {
            request.AddJsonBody(new
            {
                automationName,
                companyId,
                id,
                automationReference
            });

            return request;
        }

        internal static RestRequest CreateSaveFieldUpdateScriptRequest(RestRequest request, string field, string operatorAction, string tableName, string value)
        {
            request.AddJsonBody(new
            {
                field,
                operatorAction,
                tableName,
                value
            });

            return request;
        }

        internal static RestRequest CreateLetterTemplateRequest(RestRequest request, string author, bool consent, string description, bool eligibleForSignature, string filename, bool questionnaire, string reference, string subject, string tableName, string title, bool useCutOffDate)
        {
            request.AddJsonBody(new
            {
                author,
                consent,
                description,
                eligibleForSignature,
                filename,
                questionnaire,
                reference,
                subject,
                tableName,
                title,
                useCutOffDate
            });

            return request;
        }

        internal static RestRequest CreateTriggerRequest(RestRequest request, string accountTypeRestriction, bool addAccountTypeRestriction, bool additionalCondition, string automationReference, bool automationReferenceFlag, string emailDistributionList, bool emailNotificationFlag, string emailTemplateReference, string glReference, bool glReferenceFlag, bool runAutomationFlag, string runAutomationReference, string templateReference, bool templateReferenceFlag, string triggerEventType, string triggerName, string workflow)
        {
            request.AddJsonBody(new
            {
                accountTypeRestriction,
                addAccountTypeRestriction,
                additionalCondition,
                automationReference,
                automationReferenceFlag,
                emailDistributionList,
                emailNotificationFlag,
                emailTemplateReference,
                glReference,
                glReferenceFlag,
                runAutomationFlag,
                runAutomationReference,
                templateReference,
                triggerEventType,
                templateReferenceFlag,
                triggerName,
                workflow
            });

            return request;
        }
    }
}
