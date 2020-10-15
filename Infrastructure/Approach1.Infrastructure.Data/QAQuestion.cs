//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Approach1.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class QAQuestion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QAQuestion()
        {
            this.QACampaignQuestions = new HashSet<QACampaignQuestion>();
            this.QAQuestionsFormTypeMappings = new HashSet<QAQuestionsFormTypeMapping>();
            this.QAResponses = new HashSet<QAResponse>();
        }
    
        public int QAQuestionId { get; set; }
        public int QASectionId { get; set; }
        public string QuestionText { get; set; }
        public decimal QuestionWeight { get; set; }
        public int QAQuestionTypeId { get; set; }
        public int QAQuestionCategory { get; set; }
        public int QAQuestionPriority { get; set; }
        public int QAQuestionReferralReasonId { get; set; }
        public int CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsPublished { get; set; }
        public Nullable<int> UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QACampaignQuestion> QACampaignQuestions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QAQuestionsFormTypeMapping> QAQuestionsFormTypeMappings { get; set; }
        public virtual QAQuestionType QAQuestionType { get; set; }
        public virtual QAReferralReason QAReferralReason { get; set; }
        public virtual QASection QASection { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QAResponse> QAResponses { get; set; }
    }
}