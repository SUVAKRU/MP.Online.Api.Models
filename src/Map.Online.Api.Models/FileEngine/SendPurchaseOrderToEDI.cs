using System.Xml.Serialization;
using System.Collections.Generic;

namespace MP.Online.Api.Models.FileEngine.PO
{

    // Xml Generation for Purchase Order
    [XmlRoot(ElementName = "SendPurchaseOrderToEDI")]
    public class SendPurchaseOrderToEDI
    {
        [XmlElement(ElementName = "PurchaseOrderNumber")]
        public string PurchaseOrderNumber { get; set; }
        [XmlElement(ElementName = "CreatedDate")]
        public string CreatedDate { get; set; }
        [XmlElement(ElementName = "OrderDate")]
        public string OrderDate { get; set; }
        [XmlElement(ElementName = "RequestedDeliveryDate")]
        public string RequestedDeliveryDate { get; set; }
        [XmlElement(ElementName = "RequestedShipDate")]
        public string RequestedShipDate { get; set; }
        [XmlElement(ElementName = "ActualDeliveryDate")]
        public string ActualDeliveryDate { get; set; }
        [XmlElement(ElementName = "ActualShipDate")]
        public string ActualShipDate { get; set; }
        [XmlElement(ElementName = "TotalQuantity")]
        public string TotalQuantity { get; set; }
        [XmlElement(ElementName = "TotalTax")]
        public string TotalTax { get; set; }
        [XmlElement(ElementName = "Amount")]
        public string Amount { get; set; }
        [XmlElement(ElementName = "Currency")]
        public string Currency { get; set; }
        [XmlElement(ElementName = "TermsId")]
        public string TermsId { get; set; }
        [XmlElement(ElementName = "FreightStatusId")]
        public string FreightStatusId { get; set; }
        [XmlElement(ElementName = "OrderStatusId")]
        public string OrderStatusId { get; set; }
        [XmlElement(ElementName = "ProductTypeId")]
        public string ProductTypeId { get; set; }
        [XmlElement(ElementName = "PurchaseOrderHeaderId")]
        public string PurchaseOrderHeaderId { get; set; }
        [XmlElement(ElementName = "Action")]
        public string Action { get; set; }
        [XmlElement(ElementName = "LineCount")]
        public string LineCount { get; set; }
        [XmlElement(ElementName = "ExternalNote")]
        public string ExternalNote { get; set; }
        [XmlElement(ElementName = "VendorId")]
        public string VendorId { get; set; }
        [XmlElement(ElementName = "Vendor")]
        public Vendor Vendor { get; set; }
        [XmlElement(ElementName = "ConceptId")]
        public string ConceptId { get; set; }
        [XmlElement(ElementName = "Concept")]
        public Concept Concept { get; set; }
        [XmlElement(ElementName = "AccountId")]
        public string AccountId { get; set; }
        [XmlElement(ElementName = "Account")]
        public Account Account { get; set; }
        [XmlElement(ElementName = "References")]
        public References References { get; set; }
        [XmlArray("PurchaseOrderDetails"), XmlArrayItem(typeof(PurchaseOrderDetail),ElementName = "PurchaseOrderDetail")]
        public List<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
    }
    public class Vendor
    {
        [XmlElement(ElementName = "Id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "VendorName")]
        public string VendorName { get; set; }
        [XmlElement(ElementName = "VendorAddress1")]
        public string VendorAddress1 { get; set; }
        [XmlElement(ElementName = "VendorAddress2")]
        public string VendorAddress2 { get; set; }
        [XmlElement(ElementName = "VendorCity")]
        public string VendorCity { get; set; }
        [XmlElement(ElementName = "VendorState")]
        public string VendorState { get; set; }
        [XmlElement(ElementName = "VendorZip")]
        public string VendorZip { get; set; }
        [XmlElement(ElementName = "VendorCountryCode")]
        public string VendorCountryCode { get; set; }
        [XmlElement(ElementName = "VendorCustomerNumber")]
        public string VendorCustomerNumber { get; set; }
        [XmlElement(ElementName = "VendorLocationNumber")]
        public string VendorLocationNumber { get; set; }
        [XmlElement(ElementName = "References")]
        public References References { get; set; }
    }
    public class Concept
    {
        [XmlElement(ElementName = "Id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "ParentGroup")]
        public string ParentGroup { get; set; }
        [XmlElement(ElementName = "ConceptName")]
        public string ConceptName { get; set; }
        [XmlElement(ElementName = "ShortName")]
        public string ShortName { get; set; }
        [XmlElement(ElementName = "CustomerCode")]
        public string CustomerCode { get; set; }
        [XmlElement(ElementName = "RollupId")]
        public string RollupId { get; set; }
        [XmlElement(ElementName = "References")]
        public References References { get; set; }
    }
    public class Account
    {
        [XmlElement(ElementName = "Id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "AccountName")]
        public string AccountName { get; set; }
        [XmlElement(ElementName = "AccountAddress1")]
        public string AccountAddress1 { get; set; }
        [XmlElement(ElementName = "AccountAddress2")]
        public string AccountAddress2 { get; set; }
        [XmlElement(ElementName = "AccountCity")]
        public string AccountCity { get; set; }
        [XmlElement(ElementName = "AccountState")]
        public string AccountState { get; set; }
        [XmlElement(ElementName = "AccountZip")]
        public string AccountZip { get; set; }
        [XmlElement(ElementName = "AccountCountryCode")]
        public string AccountCountryCode { get; set; }
        [XmlElement(ElementName = "StoreNumber")]
        public string StoreNumber { get; set; }
        [XmlElement(ElementName = "LocationId")]
        public string LocationId { get; set; }
        [XmlElement(ElementName = "References")]
        public References References { get; set; }
    }
    public class References
    {
        [XmlElement(ElementName = "ReferenceName")]
        public string ReferenceName { get; set; }
        [XmlElement(ElementName = "ReferenceValue")]
        public string ReferenceValue { get; set; }
    }
    public class PurchaseOrderDetail
    {
        [XmlElement(ElementName = "PurchaseOrderLineNumber")]
        public string PurchaseOrderLineNumber { get; set; }
        [XmlElement(ElementName = "ItemNumber")]
        public string ItemNumber { get; set; }
        [XmlElement(ElementName = "Unit")]
        public string Unit { get; set; }
        [XmlElement(ElementName = "PackSize")]
        public string PackSize { get; set; }
        [XmlElement(ElementName = "Description")]
        public string Description { get; set; }
        [XmlElement(ElementName = "OGtin")]
        public string OGtin { get; set; }
        [XmlElement(ElementName = "ConceptItemNumber")]
        public string ConceptItemNumber { get; set; }
        [XmlElement(ElementName = "ConceptDescription")]
        public string ConceptDescription { get; set; }
        [XmlElement(ElementName = "ConceptUnit")]
        public string ConceptUnit { get; set; }
        [XmlElement(ElementName = "Quantity")]
        public string Quantity { get; set; }
        [XmlElement(ElementName = "NonSystemQuantityOrdered")]
        public string NonSystemQuantityOrdered { get; set; }
        [XmlElement(ElementName = "Price")]
        public string Price { get; set; }
        [XmlElement(ElementName = "ExtendedPrice")]
        public string ExtendedPrice { get; set; }
        [XmlElement(ElementName = "ExtendedTax")]
        public string ExtendedTax { get; set; }
        [XmlElement(ElementName = "ConversionFactor")]
        public string ConversionFactor { get; set; }
        [XmlElement(ElementName = "Catch")]
        public string Catch { get; set; }
        [XmlElement(ElementName = "CatchWeightItem")]
        public string CatchWeightItem { get; set; }
        [XmlElement(ElementName = "LotNumber")]
        public string LotNumber { get; set; }
        [XmlElement(ElementName = "SubbedItem")]
        public string SubbedItem { get; set; }
        [XmlElement(ElementName = "Weight")]
        public string Weight { get; set; }
        [XmlElement(ElementName = "LineNote")]
        public string LineNote { get; set; }
        [XmlElement(ElementName = "References")]
        public References References { get; set; }
        [XmlElement(ElementName = "PoDetailId")]
        public string PoDetailId { get; set; }
    }

   
}
