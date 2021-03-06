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
    
    public partial class AvsrSetting
    {
        public int AvsrSettingId { get; set; }
        public int CampaignID { get; set; }
        public bool Required { get; set; }
        public bool Archive { get; set; }
        public int ArchiveDays { get; set; }
        public bool AllowFailedCountOverride { get; set; }
        public int FailedCountAttempts { get; set; }
        public int AVSRPendingWaitTime { get; set; }
        public Nullable<int> CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual Campaign Campaign { get; set; }
    }
}
