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
    
    public partial class RELComissionOwnerCompany
    {
        public int ComissionOwnerCompanyId { get; set; }
        public int ExergyCommissionOwnerId { get; set; }
        public int CompanyId { get; set; }
        public Nullable<int> CampaignId { get; set; }
        public int CreatedByUserId { get; set; }
        public System.DateTime CreatedOnDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsPublished { get; set; }
        public Nullable<int> UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
    
        public virtual ExergyCommissionOwner ExergyCommissionOwner { get; set; }
        public virtual Campaign Campaign { get; set; }
        public virtual Company Company { get; set; }
    }
}
