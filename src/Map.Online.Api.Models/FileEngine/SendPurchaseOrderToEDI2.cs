﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.FileEngine.VPO
{
    public class SendPurchaseOrderToEDI
    {
        public string PurchaseOrderNumber { get; set; }
        public string CreatedDate { get; set; }
        public string OrderDate { get; set; }
        public string RequestedDeliveryDate { get; set; }
        public string RequestedShipDate { get; set; }
        public string ActualDeliveryDate { get; set; }
        public string ActualShipDate { get; set; }
        public string TotalQuantity { get; set; }
        public string TotalTax { get; set; }
        public string Amount { get; set; }
        public string Currency { get; set; }
        public string TermsId { get; set; }
        public string FreightStatusId { get; set; }
        public string OrderStatusId { get; set; }
        public string ProductTypeId { get; set; }
        public string PurchaseOrderHeaderId { get; set; }
        public string Action { get; set; }
        public string LineCount { get; set; }
        public string ExternalNote { get; set; }
        public string VendorId { get; set; }
        public Vendor Vendor { get; set; }
        public string ConceptId { get; set; }
        public Concept Concept { get; set; }
        public string AccountId { get; set; }
        public Account Account { get; set; }
        public PurchaseOrderHeaderReferences PurchaseOrderHeaderReferences { get; set; }
        public PurchaseOrderDetails PurchaseOrderDetails { get; set; }

    }

    public class VendorReferences
    {
        public string ReferenceName { get; set; }
        public string ReferenceValue { get; set; }

    }

    public class Vendor
    {
        public string Id { get; set; }
        public string VendorName { get; set; }
        public string VendorAddress1 { get; set; }
        public string VendorAddress2 { get; set; }
        public string VendorCity { get; set; }
        public string VendorState { get; set; }
        public string VendorZip { get; set; }
        public string VendorCountryCode { get; set; }
        public string VendorCustomerNumber { get; set; }
        public string VendorLocationNumber { get; set; }
        public VendorReferences VendorReferences { get; set; }

    }

    public class ConceptReferences
    {
        public List<string> Reference { get; set; }

    }

    public class Concept
    {
        public string Id { get; set; }
        public string ParentGroup { get; set; }
        public string ConceptName { get; set; }
        public string ShortName { get; set; }
        public string CustomerCode { get; set; }
        public string RollupId { get; set; }
        public ConceptReferences ConceptReferences { get; set; }

    }

    public class AccountReferences
    {
        public List<string> Reference { get; set; }

    }

    public class Account
    {
        public string Id { get; set; }
        public string AccountName { get; set; }
        public string AccountAddress1 { get; set; }
        public string AccountAddress2 { get; set; }
        public string AccountCity { get; set; }
        public string AccountState { get; set; }
        public string AccountZip { get; set; }
        public string AccountCountryCode { get; set; }
        public string StoreNumber { get; set; }
        public string LocationId { get; set; }
        public AccountReferences AccountReferences { get; set; }

    }

    public class PurchaseOrderHeaderReferences
    {
        public string ReferenceName { get; set; }
        public string ReferenceValue { get; set; }

    }

    public class PurchaseOrderDetailReferences
    {
        public string ReferenceName { get; set; }
        public string ReferenceValue { get; set; }

    }

    public class PurchaseOrderDetail
    {
        public string PurchaseOrderLineNumber { get; set; }
        public string ItemNumber { get; set; }
        public string Unit { get; set; }
        public string PackSize { get; set; }
        public string Description { get; set; }
        public string OGtin { get; set; }
        public string ConceptItemNumber { get; set; }
        public string ConceptDescription { get; set; }
        public string ConceptUnit { get; set; }
        public string Quantity { get; set; }
        public string NonSystemQuantityOrdered { get; set; }
        public string Price { get; set; }
        public string ExtendedPrice { get; set; }
        public string ExtendedTax { get; set; }
        public string ConversionFactor { get; set; }
        public string Catch { get; set; }
        public string CatchWeightItem { get; set; }
        public string LotNumber { get; set; }
        public string SubbedItem { get; set; }
        public string Weight { get; set; }
        public string LineNote { get; set; }
        public PurchaseOrderDetailReferences PurchaseOrderDetailReferences { get; set; }
        public string PoDetailId { get; set; }

    }

    public class PurchaseOrderDetails
    {
        public List<PurchaseOrderDetail> PurchaseOrderDetail { get; set; }

    }
}
