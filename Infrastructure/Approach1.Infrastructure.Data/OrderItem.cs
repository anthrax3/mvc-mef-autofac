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
    
    public partial class OrderItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderItem()
        {
            this.ApiLogs = new HashSet<ApiLog>();
            this.OperationsRecordings = new HashSet<OperationsRecording>();
            this.ProviderCommsQueues = new HashSet<ProviderCommsQueue>();
            this.ProviderSpecificChases = new HashSet<ProviderSpecificChase>();
            this.ProviderSpecificNetstars = new HashSet<ProviderSpecificNetstar>();
            this.ProviderSpecificOnAirs = new HashSet<ProviderSpecificOnAir>();
            this.RamApiLogs = new HashSet<RamApiLog>();
            this.RelatedOrderItems = new HashSet<RelatedOrderItem>();
            this.RelatedOrderItems1 = new HashSet<RelatedOrderItem>();
            this.SoMusicProviderSpecifics = new HashSet<SoMusicProviderSpecific>();
            this.ProviderVouchers = new HashSet<ProviderVoucher>();
            this.DealdepotProviderSpecifics = new HashSet<DealdepotProviderSpecific>();
            this.HotSpotterProviderSpecifics = new HashSet<HotSpotterProviderSpecific>();
            this.OrderAnnotations = new HashSet<OrderAnnotation>();
            this.OrderDeliveries = new HashSet<OrderDelivery>();
            this.RetensionsOrderStatusQueues = new HashSet<RetensionsOrderStatusQueue>();
            this.OrderItemDatas = new HashSet<OrderItemData>();
            this.OrderItemVettingResults = new HashSet<OrderItemVettingResult>();
            this.OrderRetentions = new HashSet<OrderRetention>();
            this.OrderStatusHistories = new HashSet<OrderStatusHistory>();
            this.PingdProviderSpecifics = new HashSet<PingdProviderSpecific>();
            this.VivalifeDisabilityProviderSpecifics = new HashSet<VivalifeDisabilityProviderSpecific>();
            this.VivalifeEducationProviderSpecifics = new HashSet<VivalifeEducationProviderSpecific>();
            this.VivalifeFamilyFuneralProviderSpecifics = new HashSet<VivalifeFamilyFuneralProviderSpecific>();
            this.VivaLifeProviderSpecifics = new HashSet<VivaLifeProviderSpecific>();
            this.VivaLifeGapCoverProviderSpecifics = new HashSet<VivaLifeGapCoverProviderSpecific>();
            this.PleexProviderSpecifics = new HashSet<PleexProviderSpecific>();
            this.PortingProviderSpecifics = new HashSet<PortingProviderSpecific>();
            this.RescueboxProviderSpecifics = new HashSet<RescueboxProviderSpecific>();
            this.SafetyBoxProviderSpecifics = new HashSet<SafetyBoxProviderSpecific>();
            this.StockItemOrderHistories = new HashSet<StockItemOrderHistory>();
            this.StockItems = new HashSet<StockItem>();
            this.TelkomSpecificProviders = new HashSet<TelkomSpecificProvider>();
            this.TrackingProviderSpecifics = new HashSet<TrackingProviderSpecific>();
            this.VASXProviderSpecifics = new HashSet<VASXProviderSpecific>();
            this.VehicleProviderSpecificDetails = new HashSet<VehicleProviderSpecificDetail>();
            this.Vouchers = new HashSet<Voucher>();
        }
    
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
    
        public virtual Document Document { get; set; }
        public virtual PayMethod PayMethod { get; set; }
        public virtual CustomerBank CustomerBank { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApiLog> ApiLogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationsRecording> OperationsRecordings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProviderCommsQueue> ProviderCommsQueues { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProviderSpecificChase> ProviderSpecificChases { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProviderSpecificNetstar> ProviderSpecificNetstars { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProviderSpecificOnAir> ProviderSpecificOnAirs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RamApiLog> RamApiLogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RelatedOrderItem> RelatedOrderItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RelatedOrderItem> RelatedOrderItems1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SoMusicProviderSpecific> SoMusicProviderSpecifics { get; set; }
        public virtual Bundle Bundle { get; set; }
        public virtual Deal Deal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProviderVoucher> ProviderVouchers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DealdepotProviderSpecific> DealdepotProviderSpecifics { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HotSpotterProviderSpecific> HotSpotterProviderSpecifics { get; set; }
        public virtual Order Order { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderAnnotation> OrderAnnotations { get; set; }
        public virtual OrderCancelReasonDetail OrderCancelReasonDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDelivery> OrderDeliveries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RetensionsOrderStatusQueue> RetensionsOrderStatusQueues { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItemData> OrderItemDatas { get; set; }
        public virtual OrderStatusDetail OrderStatusDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItemVettingResult> OrderItemVettingResults { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderRetention> OrderRetentions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderStatusHistory> OrderStatusHistories { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PingdProviderSpecific> PingdProviderSpecifics { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VivalifeDisabilityProviderSpecific> VivalifeDisabilityProviderSpecifics { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VivalifeEducationProviderSpecific> VivalifeEducationProviderSpecifics { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VivalifeFamilyFuneralProviderSpecific> VivalifeFamilyFuneralProviderSpecifics { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VivaLifeProviderSpecific> VivaLifeProviderSpecifics { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VivaLifeGapCoverProviderSpecific> VivaLifeGapCoverProviderSpecifics { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PleexProviderSpecific> PleexProviderSpecifics { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PortingProviderSpecific> PortingProviderSpecifics { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RescueboxProviderSpecific> RescueboxProviderSpecifics { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SafetyBoxProviderSpecific> SafetyBoxProviderSpecifics { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockItemOrderHistory> StockItemOrderHistories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockItem> StockItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TelkomSpecificProvider> TelkomSpecificProviders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackingProviderSpecific> TrackingProviderSpecifics { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VASXProviderSpecific> VASXProviderSpecifics { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehicleProviderSpecificDetail> VehicleProviderSpecificDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Voucher> Vouchers { get; set; }
    }
}
