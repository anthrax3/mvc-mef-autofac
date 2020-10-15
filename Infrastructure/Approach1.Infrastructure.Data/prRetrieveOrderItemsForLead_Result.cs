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
    
    public partial class prRetrieveOrderItemsForLead_Result
    {
        public int OrderItemID { get; set; }
        public int OrderId { get; set; }
        public int DealId { get; set; }
        public Nullable<int> DocumentId { get; set; }
        public int SMSSent { get; set; }
        public int FAXSent { get; set; }
        public int BuyOut { get; set; }
        public string SuspendCode { get; set; }
        public string DeliveryInstruction { get; set; }
        public int DocumentationCompleted { get; set; }
        public int RICAIndicator { get; set; }
        public string ItemEscalation { get; set; }
        public string ThirdPartyReference { get; set; }
        public Nullable<int> CustomerBankId { get; set; }
        public int OrderStatusDetailId { get; set; }
        public Nullable<int> OrderCancelReasonDetailId { get; set; }
        public int OrderTypeId { get; set; }
        public decimal Price { get; set; }
        public string OrderReference { get; set; }
        public int OrderItemNumber { get; set; }
        public Nullable<int> CancelStatusDetailId { get; set; }
        public Nullable<int> ProviderRef { get; set; }
        public Nullable<int> VasRef { get; set; }
        public Nullable<int> BankRef { get; set; }
        public Nullable<int> BundleID { get; set; }
        public Nullable<int> BundleRef { get; set; }
        public int PayMethodId { get; set; }
        public Nullable<int> FaisUserId { get; set; }
        public Nullable<System.DateTime> OperationDate { get; set; }
        public Nullable<int> MSOrderId { get; set; }
        public Nullable<int> EMOrderId { get; set; }
    }
}