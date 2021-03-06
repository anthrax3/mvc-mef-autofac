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
    
    public partial class ProviderVoucher
    {
        public int ProviderVouchersId { get; set; }
        public string VoucherCode { get; set; }
        public int ProvIderId { get; set; }
        public System.DateTime UploadDate { get; set; }
        public System.DateTime ExpiryDate { get; set; }
        public int UploadUserId { get; set; }
        public string Language { get; set; }
        public Nullable<bool> Redeemed { get; set; }
        public Nullable<int> OrderItemId { get; set; }
        public Nullable<System.DateTime> RedeemedDate { get; set; }
        public Nullable<System.DateTime> AssignedDate { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual Provider Provider { get; set; }
        public virtual OrderItem OrderItem { get; set; }
        public virtual User User { get; set; }
    }
}
