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
    
    public partial class BankCDV
    {
        public int BankCDVID { get; set; }
        public int BankID { get; set; }
        public Nullable<int> BranchCodeBegin { get; set; }
        public Nullable<int> BranchCodeEnd { get; set; }
        public string AccountTypes { get; set; }
        public Nullable<int> AccountIndication { get; set; }
        public string WeightingDigits { get; set; }
        public Nullable<int> FudgeFactor { get; set; }
        public Nullable<int> Modulus { get; set; }
        public string DropDigits { get; set; }
        public string RequiredDigits { get; set; }
        public string Result { get; set; }
        public Nullable<bool> ZeroFill { get; set; }
        public Nullable<long> AccountNumberBegin { get; set; }
        public Nullable<long> AccountNumberEnd { get; set; }
        public string DigitConditions { get; set; }
        public string ConditionValues { get; set; }
        public Nullable<int> Step { get; set; }
        public Nullable<int> CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsPublished { get; set; }
        public Nullable<int> UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
    }
}