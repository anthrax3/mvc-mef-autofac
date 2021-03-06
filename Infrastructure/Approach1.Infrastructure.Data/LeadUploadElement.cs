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
    
    public partial class LeadUploadElement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LeadUploadElement()
        {
            this.LeadFields = new HashSet<LeadField>();
            this.LeadUploadFormatElements = new HashSet<LeadUploadFormatElement>();
        }
    
        public int LeadUploadElementID { get; set; }
        public string Element { get; set; }
        public int FieldTypeId { get; set; }
        public string Description { get; set; }
    
        public virtual FieldType FieldType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeadField> LeadFields { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeadUploadFormatElement> LeadUploadFormatElements { get; set; }
    }
}
