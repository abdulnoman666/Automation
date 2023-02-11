using System;
using System.Collections.Generic;
using System.Text;

namespace FinboaAPITestAutomation.LetterTemplates
{
    internal class LetterTemplate
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public string OnlineContent { get; set; }
        public string Reference { get; set; }
        public string CreatedOn { get; set; }
        public string PublishedOn { get; set; }
        public string UpdatedOn { get; set; }
        public string Subject { get; set; }
        public string TableName { get; set; }
        public string StyleSheet { get; set; }
        public string FileName { get; set; }
        public string Questionnaire { get; set; }
        public string Roles { get; set; }
        public string SubmissionSource { get; set; }
        public Boolean Consent { get; set; }
        public int createdBy { get; set; }
        public int UpdatedBy { get; set; }
        public Boolean UseCutOffDate { get; set; }
        public Boolean EligibleForESignature { get; set; }
    }
}
