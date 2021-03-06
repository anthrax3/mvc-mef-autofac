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
    
    public partial class ProviderCommsTemplate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProviderCommsTemplate()
        {
            this.ProviderCommsQueues = new HashSet<ProviderCommsQueue>();
        }
    
        public int ProviderCommsTemplatesId { get; set; }
        public int ProvIderId { get; set; }
        public string EmailTemplateURL { get; set; }
        public string SMSTemplateText { get; set; }
        public string EmailSubject { get; set; }
        public string EmailSourceAddress { get; set; }
        public string ViewEmailSourceAddress { get; set; }
        public int TemplateType { get; set; }
        public bool Active { get; set; }
        public Nullable<int> CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }
        public string EmailTemplateName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProviderCommsQueue> ProviderCommsQueues { get; set; }
        public virtual Provider Provider { get; set; }
        public virtual ProviderCommsTemplateType ProviderCommsTemplateType { get; set; }
    }
}
