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
    
    public partial class StockTake
    {
        public int StockTakeId { get; set; }
        public Nullable<int> BrandId { get; set; }
        public string Type { get; set; }
        public Nullable<int> Active { get; set; }
        public Nullable<int> Complete { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
    }
}
