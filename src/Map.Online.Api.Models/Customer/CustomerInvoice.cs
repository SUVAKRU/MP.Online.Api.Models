using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Customer
{
    public class CustomerInvoice
    {
        public Account account { get; set; }
        public Concept concept { get; set; }
        public Vendor vendor { get; set; }
        public PurchaseOrderHeader purchaseOrderHeader { get; set; }
        public string InvoiceNumber { get; set; }
        public string TCode { get; set; }
        public double Amount { get; set; }
        public string CustomerReferenceCode { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public bool ProcessedFlag { get; set; }
        public bool EDI810Flag { get; set; }
        public bool EDI856Flag { get; set; }
        public bool ErrorFlag { get; set; }
        public bool ExportErrorFlag { get; set; }
        public bool VoidFlag { get; set; }
        public bool HoldFlag { get; set; }
        public bool PriceAdjustmentFlag { get; set; }
        public int InvoiceID { get; set; }
        public double TotalTax { get; set; }
        public DateTime ReqDeliveryDate { get; set; }
        public DateTime ConfArrDate { get; set; }
        public DateTime ShipDate { get; set; }
        public DateTime ReqShipDate { get; set; }
        public DateTime ConfShipDate { get; set; }
        public int OrderStatusId { get; set; }
        public int FreightStatusId { get; set; }
        public int Terms { get; set; }
        public int OrderTypeId { get; set; }
        public double TotalQty { get; set; }
        public List<InvoiceDetailList> invoiceDetailList { get; set; }
        public List<ReferenceNumber> ReferenceNumbers { get; set; }
        public DateTime DtCreated { get; set; }
        public string ConceptVendorMappingAlternateId { get; set; }
        public string FinancialTransactionId { get; set; }
        public string ExternalNotes { get; set; }
        public string FreightTermType { get; set; }
        public DateTime ActualShipDate { get; set; }
        public DateTime OrderPlacedTime { get; set; }
        public DateTime OrderPlacedDate { get; set; }
        public DateTime DeliveryStartDate { get; set; }
        public DateTime DeliveryEndDate { get; set; }
        public MPData MPData { get; set; }
        public PaymentTerms PaymentTerms { get; set; }
        public Contacts Contacts { get; set; }
        public FreightTerms FreightTerms { get; set; }
        public Carrier Carrier { get; set; }
        public Sourcing Sourcing { get; set; }
        public Tax Tax { get; set; }
        public Notes Notes { get; set; }
        public MonetaryAmounts MonetaryAmounts { get; set; }
    }


    public class Account
    {
        public string AccountName { get; set; }
        public string AccountAddress { get; set; }
        public string AccountCity { get; set; }
        public string AccountState { get; set; }
        public string AccountZip { get; set; }
        public string AccountCountryCode { get; set; }
        public string StoreNumber { get; set; }
        public string LocationId { get; set; }
        public string shipperCode { get; set; }
    }

    public class Concept
    {
        public string ConceptId { get; set; }
        public string ConceptName { get; set; }
        public string ShortName { get; set; }
        public string parentGroup { get; set; }
        public string CustomerCode { get; set; }
        public string RollUp { get; set; }
        public string Branch { get; set; }
    }

    public class Vendor
    {
        public string VendorName { get; set; }
        public string vendorAddress { get; set; }
        public string VendorCity { get; set; }
        public string VendorState { get; set; }
        public string VendorZip { get; set; }
        public string VendorCountryCode { get; set; }
        public string WCode { get; set; }
    }

    public class PurchaseOrderHeader
    {
        public int POHeaderId { get; set; }
        public string PONum { get; set; }
        public string OrderNote { get; set; }
    }

    public class InvoiceDetailList
    {
        public string itemNo { get; set; }
        public bool isVisible { get; set; }
        public string oGtin { get; set; }
        public List<object> referenceNumbers { get; set; }
        public double totalBuyPrice { get; set; }
        public int invoiceDetailId { get; set; }
        public int vendorId { get; set; }
        public int invoiceId { get; set; }
        public string invoiceLineNumber { get; set; }
        public string description { get; set; }
        public string unit { get; set; }
        public double quantity { get; set; }
        public double price { get; set; }
        public double priceOrdered { get; set; }
        public double quantityOrdered { get; set; }
        public double quantityShipped { get; set; }
        public bool @catch { get; set; }
        public int weight { get; set; }
        public int extendedTax { get; set; }
        public string ogtin { get; set; }
        public double margin { get; set; }
        public int productionMargin { get; set; }
        public DateTime createDate { get; set; }
        public int masterRecordId { get; set; }
        public bool visible { get; set; }
        public bool subbedItem { get; set; }
        public int buyPrice { get; set; }
        public int nonSystemQuantityOrdered { get; set; }
        public int extendedPrice { get; set; }
        public double totalMargin { get; set; }
        public List<object> references { get; set; }
        public string brand { get; set; }
        public string lot { get; set; }
        public int totalAmount { get; set; }
    }

    public class ReferenceNumber
    {
        public string ReferenceName { get; set; }
        public string ReferenceValue { get; set; }
    }

    public class MPData
    {
        public int senderUniqueId { get; set; }
        public int receiverUniqueId { get; set; }
        public int groupControlId { get; set; }
        public int documentControlId { get; set; }
        public int interchangeSenderId { get; set; }
        public int interchangeReceiverId { get; set; }
        public int groupSenderId { get; set; }
        public int groupReceiverId { get; set; }
    }

    public class PaymentTerms
    {
        public string paymentTermType { get; set; }
        public int paymentTermsDiscountPercentage { get; set; }
        public int paymentTermsDiscountAmount { get; set; }
        public int paymentTermsDeferredAmountDue { get; set; }
        public int paymentMethodId { get; set; }
    }

    public class Contacts
    {
        public int contactId { get; set; }
        public string contactType { get; set; }
        public List<object> locations { get; set; }
    }

    public class FreightTerms
    {
        public string freightTermType { get; set; }
    }

    public class Carrier
    {
        public int carrierId { get; set; }
        public string equipmentType { get; set; }
    }

    public class Sourcing
    {
    }

    public class Tax
    {
        public int taxAmount { get; set; }
        public int taxId { get; set; }
        public int assignedId { get; set; }
    }

    public class Notes
    {
    }

    public class MonetaryAmounts
    {
        public int monetaryAmountId { get; set; }
        public int monetaryAmount { get; set; }
    }


}
