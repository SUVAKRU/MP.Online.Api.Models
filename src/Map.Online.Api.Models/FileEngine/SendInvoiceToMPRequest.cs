using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MP.Online.Api.Models.FileEngine.Invoice
{

    // XML generation for Invoice
    [XmlRoot("SendInvoiceToMPRequest")]
    public class SendInvoiceToMPRequest
    {
        [XmlElement("InvoiceHeader")]
        public List<InvoiceHeader> InvoiceHeader { get; set; }
    }
    public class InvoiceHeader
    {
        [XmlElement("InvoiceNumber")]
        public string InvoiceNumber { get; set; }
        [XmlElement("PurchaseOrderNumber")]
        public string PurchaseOrderNumber { get; set; }
        [XmlElement("OrderDate")]
        public DateTime OrderDate { get; set; }
        [XmlElement("OriginalInvoiceNumber")]
        public string OriginalInvoiceNumber { get; set; }
        [XmlElement("DeliveryDate")]
        public DateTime DeliveryDate { get; set; }
        [XmlElement("RequestedDeliveryDate")]
        public DateTime RequestedDeliveryDate { get; set; }
        [XmlElement("ShipDate")]
        public DateTime ShipDate { get; set; }
        [XmlElement("RequestedShipDate")]
        public DateTime RequestedShipDate { get; set; }
        [XmlElement("ConfirmedShipDate")]
        public DateTime ConfirmedShipDate { get; set; }
        [XmlElement("ConfirmedArrivalDate")]
        public DateTime ConfirmedArrivalDate { get; set; }
        [XmlElement("TotalQuantity")]
        public int TotalQuantity { get; set; }
        [XmlElement("TotalTax")]
        public double TotalTax { get; set; }
        [XmlElement("Amount")]
        public double Amount { get; set; }
        [XmlElement("Currency")]
        public string Currency { get; set; }
        [XmlElement("TermsId")]
        public int TermsId { get; set; }
        [XmlElement("FreightStatusId")]
        public int FreightStatusId { get; set; }
        [XmlElement("OrderStatusId")]
        public int OrderStatusId { get; set; }
        [XmlElement("ProductTypeId")]
        public int ProductTypeId { get; set; }
        [XmlElement("PurchaseOrderHeaderId")]
        public int PurchaseOrderHeaderId { get; set; }
        [XmlElement("Action")]
        public string Action { get; set; }
        [XmlElement("ExternalNote")]
        public string ExternalNote { get; set; }
        [XmlElement("Vendor")]


        public Vendor Vendor { get; set; }
        [XmlElement("Concept")]
        public Concept Concept { get; set; }
        [XmlElement("Account")]
        public Account Account { get; set; }
        [XmlElement("References")]
        public Reference Reference { get; set; }
        [XmlElement("InvoiceDetails")]
        public InvoiceDetails InvoiceDetails { get; set; }
    }
    public class InvoiceDetails
    {
        [XmlElement("InvoiceDetail")]
        public List<InvoiceDetail> InvoiceDetail { get; set; }
    }

    public class InvoiceDetail
    {
        [XmlElement("InvoiceLineNumber")]
        public string InvoiceLineNumber { get; set; }
        [XmlElement("ItemNumber")]
        public string ItemNumber { get; set; }
        [XmlElement("Unit")]
        public string Unit { get; set; }
        [XmlElement("Description")]
        public string Description { get; set; }
        [XmlElement("Quantity")]
        public string Quantity { get; set; }
        [XmlElement("QuantityShipped")]
        public string QunatityShipped { get; set; }
        [XmlElement("NonSystemQuantityOrdered")]
        public string NonSystemQunatityOrdered { get; set; }
        [XmlElement("Price")]
        public string Price { get; set; }
        [XmlElement("ExtendedPrice")]
        public string ExtendedPrice { get; set; }
        [XmlElement("ExtendedTax")]
        public string ExtendedTax { get; set; }
        [XmlElement("Catch")]
        public string Catch { get; set; }
        [XmlElement("SubbedItem")]
        public string SubBedItem { get; set; }
        [XmlElement("Weight")]
        public string Weight { get; set; }
        [XmlElement("References")]
        public DetailReferences DetailReferences { get; set; }

    }

    public class Vendor
    {
        [XmlElement("VendorId")]
        public string VendorId { get; set; }
        [XmlElement("VendorName")]
        public string VendorName { get; set; }
        [XmlElement("VendorAddress1")]
        public string VendorAddress1 { get; set; }
        [XmlElement("VendorAddress2")]
        public string VendorAddress2 { get; set; }
        [XmlElement("VendorCity")]
        public string VendorCity { get; set; }
        [XmlElement("VendorState")]
        public string VendorState { get; set; }
        [XmlElement("VendorZip")]
        public string VendorZip { get; set; }
        [XmlElement("VendorCountryCode")]
        public string VendorCountryCode { get; set; }
        [XmlElement("VendorCustomerNumber")]
        public string VendorCustomerNumber { get; set; }
        [XmlElement("VendorLocationNumber")]
        public string VendorLocationNumber { get; set; }
        [XmlElement("References")]
        public VendorReferences VendorReferences { get; set; }
    }
    public class Concept
    {

        [XmlElement("ParentGroup")]
        public string ParentGroup { get; set; }
        [XmlElement("ConceptName")]
        public string ConceptName { get; set; }
        [XmlElement("ShortName")]
        public string ShortName { get; set; }
        [XmlElement("CustomerCode")]
        public string CustomerCode { get; set; }
        [XmlElement("References")]
        public ConceptReferences ConceptReferences { get; set; }
    }
    public class Account
    {
        [XmlElement("AccountId")]
        public int AccountId { get; set; }
        [XmlElement("AccountName")]
        public string AccountName { get; set; }
        [XmlElement("AccountAddress1")]
        public string AccountAddress1 { get; set; }
        [XmlElement("AccountAddress2")]
        public string AccountAddress2 { get; set; }
        [XmlElement("AccountCity")]
        public string AccountCity { get; set; }
        [XmlElement("AccountState")]
        public string AccountState { get; set; }
        [XmlElement("AccountZip")]
        public int AccountZip { get; set; }
        [XmlElement("AccountCountryCode")]
        public string AccountCountryCode { get; set; }
        [XmlElement("References")]
        public AccountReferences AccountReferences { get; set; }
    }
    public class VendorReferences
    {
        [XmlElement("VendorReference")]
        public List<VendorReference> VendorReferenceList { get; set; }
    }
    public class AccountReferences
    {
        [XmlElement("AccountReference")]
        public List<AccountReference> AccountReferenceList { get; set; }
    }
    public class ConceptReferences
    {
        [XmlElement("ConceptReference")]
        public List<ConceptReference> ConceptReferenceList { get; set; }
    }
    public class DetailReferences
    {
        [XmlElement("DetailReference")]
        public List<DetailReference> DetailReferenceList { get; set; }
    }
    public class VendorReference
    {
        [XmlElement("ReferenceName")]
        public string ReferenceName { get; set; }
        [XmlElement("ReferenceValue")]
        public string ReferenceValue { get; set; }
    }
    public class DetailReference
    {
        [XmlElement("ReferenceName")]
        public string ReferenceName { get; set; }
        [XmlElement("ReferenceValue")]
        public string ReferenceValue { get; set; }
    }
    public class AccountReference
    {
        [XmlElement("ReferenceName")]
        public string ReferenceName { get; set; }
        [XmlElement("ReferenceValue")]
        public string ReferenceValue { get; set; }
    }
    public class ConceptReference
    {
        [XmlElement("ReferenceName")]
        public string ReferenceName { get; set; }
        [XmlElement("ReferenceValue")]
        public string ReferenceValue { get; set; }
    }
    public class Reference
    {
        [XmlElement("ReferenceName")]
        public string ReferenceName { get; set; }
        [XmlElement("ReferenceValue")]
        public string ReferenceValue { get; set; }
    }
    public class References
    {
        [XmlElement("Reference")]
        public List<Reference> ReferenceList { get; set; }
    }

}
