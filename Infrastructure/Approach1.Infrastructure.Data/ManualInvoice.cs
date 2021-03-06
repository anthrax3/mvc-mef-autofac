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
    
    public partial class ManualInvoice
    {
        public int ManualInvoiceID { get; set; }
        public int ManualInvoiceTypeId { get; set; }
        public Nullable<int> StockItemId { get; set; }
        public string CompanyName { get; set; }
        public string VatNumber { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IDNumber { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public string InternalNotes { get; set; }
        public string DispatchType { get; set; }
        public string Waybill { get; set; }
        public string OrigOrderRef { get; set; }
        public Nullable<int> StreetNumber { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public Nullable<System.DateTime> OrderPDT { get; set; }
        public Nullable<int> EmployeeNumber { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentTerm { get; set; }
    }
}
