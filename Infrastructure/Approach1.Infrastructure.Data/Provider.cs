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
    
    public partial class Provider
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Provider()
        {
            this.ProviderStatusMappings = new HashSet<ProviderStatusMapping>();
            this.RuleMappings = new HashSet<RuleMapping>();
            this.ProviderRanges = new HashSet<ProviderRange>();
            this.ProviderSalesExclusions = new HashSet<ProviderSalesExclusion>();
            this.OrderProviderStatusCommsTemplates = new HashSet<OrderProviderStatusCommsTemplate>();
            this.ProviderCommsTemplates = new HashSet<ProviderCommsTemplate>();
            this.ProviderMandatoryFields = new HashSet<ProviderMandatoryField>();
            this.ProviderReserveds = new HashSet<ProviderReserved>();
            this.ProviderVouchers = new HashSet<ProviderVoucher>();
            this.Tariffs = new HashSet<Tariff>();
            this.VASExclusionHistories = new HashSet<VASExclusionHistory>();
            this.VASExclusions = new HashSet<VASExclusion>();
        }
    
        public int ProviderID { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string PhysicalAddress { get; set; }
        public string PostalAddress { get; set; }
        public string Telephone { get; set; }
        public string Facsimile { get; set; }
        public string VATNo { get; set; }
        public string RegNo { get; set; }
        public Nullable<int> EMId { get; set; }
        public Nullable<int> MsId { get; set; }
        public bool IsVAS { get; set; }
        public Nullable<bool> RequireSpecificData { get; set; }
        public Nullable<bool> RequireBankDetails { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> ProviderSpecificTypeId { get; set; }
        public string ExternalSpecificData { get; set; }
        public Nullable<bool> RequireQACheck { get; set; }
        public Nullable<int> ProviderTypeId { get; set; }
        public string QueueName { get; set; }
        public Nullable<int> BillingTypeId { get; set; }
    
        public virtual ProviderSpecificType ProviderSpecificType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProviderStatusMapping> ProviderStatusMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RuleMapping> RuleMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProviderRange> ProviderRanges { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProviderSalesExclusion> ProviderSalesExclusions { get; set; }
        public virtual ProviderType ProviderType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProviderStatusCommsTemplate> OrderProviderStatusCommsTemplates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProviderCommsTemplate> ProviderCommsTemplates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProviderMandatoryField> ProviderMandatoryFields { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProviderReserved> ProviderReserveds { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProviderVoucher> ProviderVouchers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tariff> Tariffs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VASExclusionHistory> VASExclusionHistories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VASExclusion> VASExclusions { get; set; }
    }
}