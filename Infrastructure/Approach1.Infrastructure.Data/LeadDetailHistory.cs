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
    
    public partial class LeadDetailHistory
    {
        public int LeadDetailHistoryId { get; set; }
        public int LeadStatusDetailId { get; set; }
        public int LeadCampaignId { get; set; }
        public string Comment { get; set; }
        public System.DateTime OccuredOn { get; set; }
        public int LoggedBy { get; set; }
    
        public virtual LeadStatusDetail LeadStatusDetail { get; set; }
    }
}
