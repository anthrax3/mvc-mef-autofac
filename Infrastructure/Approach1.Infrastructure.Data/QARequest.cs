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
    
    public partial class QARequest
    {
        public int QARequestID { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> OrderMasterId { get; set; }
        public Nullable<System.DateTime> RequestDate { get; set; }
        public string Comment { get; set; }
        public string Reason { get; set; }
    }
}