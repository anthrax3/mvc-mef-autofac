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
    
    public partial class RamApiLog
    {
        public int RamApiLogId { get; set; }
        public int OrderItemId { get; set; }
        public System.DateTime Timestamp { get; set; }
        public string RAMStatus { get; set; }
        public string RAMDescription { get; set; }
    
        public virtual OrderItem OrderItem { get; set; }
    }
}
