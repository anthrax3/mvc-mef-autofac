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
    
    public partial class BulkStatusFileUploadContent
    {
        public int BulkStatusFileUploadContentsId { get; set; }
        public int BulkStatusFileUploadId { get; set; }
        public string OrderReference { get; set; }
        public Nullable<int> OrderNum { get; set; }
        public string IDNumber { get; set; }
        public Nullable<int> ActivationNumber { get; set; }
        public string ChangeStatus { get; set; }
        public string Reason { get; set; }
        public bool Execute { get; set; }
    
        public virtual BulkStatusFileUpload BulkStatusFileUpload { get; set; }
    }
}
