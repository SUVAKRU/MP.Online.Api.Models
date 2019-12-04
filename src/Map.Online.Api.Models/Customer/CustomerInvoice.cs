
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Customer
{
    public class CustomerInvoice
    {
        public Invoice Invoice { get; set; }
    }
    public class Invoice
    {
        public InvoiceHeader InvoiceHeader { get; set; }
        public List<InvoiceDetail> InvoiceDetails { get; set; }
    }
    public class InvoiceHeader
    {
        public string InvoiceId { get; set; }
        public string PurchaseOrderHeaderId { get; set; }
        public string VendorId { get; set; }
        public string AccountId { get; set; }
        public string VendorCustomerNumber { get; set; }
        public string VendorLocationNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public string DeliveryDate { get; set; }
        public decimal Amount { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public int TotalTax { get; set; }
        public bool Processed { get; set; }
        public string DateProcessed { get; set; }
        public bool EDI_856Sent { get; set; }
        public string EDI_856SentDate { get; set; }
        public bool EDI_810Sent { get; set; }
        public string EDI_810SentDate { get; set; }
        public bool HasError { get; set; }
        public string LastNotes { get; set; }
        public bool Void { get; set; }
        public bool Hold { get; set; }
        public bool HasPriceAdjustment { get; set; }
        public string CustomerReferenceCode { get; set; }
        public string LoadNumber { get; set; }
        public bool FinSent { get; set; }
        public string FinSentDate { get; set; }
        public bool CognosSent { get; set; }
        public string CognosSentDate { get; set; }
        public bool Cognos { get; set; }
        public bool Fin { get; set; }
        public bool Fin_Edi810Sent { get; set; }
        public string Fin_Edi810SentDate { get; set; }
        public bool NonSystemInv { get; set; }
        public int TotalQuantity { get; set; }
        public string DateCreated { get; set; }
        public string OrderDate { get; set; }
        public string ShipDate { get; set; }
        public string RequestedShipDate { get; set; }
        public string RequestedDeliveryDate { get; set; }
        public string OrderStatusId { get; set; }
        public string FreightStatusId { get; set; }
        public string TermsId { get; set; }
        public string OrderTypeId { get; set; }
        public decimal TotalMargin { get; set; }
        public string ConfirmedShipDate { get; set; }
        public string ConfirmedArrivalDate { get; set; }
        public bool ExportError { get; set; }
        public string ExportErrorMsg { get; set; }
        public string ExportErrorTypeId { get; set; }
        public string POMatch { get; set; }
        public string InternalNotes { get; set; }
        public string POMatchTypeId { get; set; }
        public string OriginalInvoiceNumber { get; set; }
        public string ExternalNote { get; set; }
        public string FinancialTransactionId { get; set; }
        public string FreightTerm { get; set; }
        public string PickupNumber { get; set; }
        public string DeliveryNumber { get; set; }
        public string PickupLocation { get; set; }
        public string PickupLocationName { get; set; }
        public string ActualShipDate { get; set; }
        public string Currency { get; set; }
        public string ProductTypeId { get; set; }
        public decimal TotalBuyAmount { get; set; }
        public decimal TotalMarginAmount { get; set; }
        public Vendor Vendor { get; set; }
        public Concept Concept { get; set; }
        public Account Account { get; set; }
        public List<Reference> References { get; set; }
        public List<InvoiceDetail> InvoiceDetails { get; set; }
        public string PurchaseOrderMatchTypeId { get; set; }
        public MPData MPData { get; set; }
        public PaymentTerms PaymentTerms { get; set; }
        public Contacts Contacts { get; set; }
        public FreightTerms FreightTerms { get; set; }
        public Packaging Packaging { get; set; }
        public Carrier Carrier { get; set; }
        public Sourcing Sourcing { get; set; }
        public Tax Tax { get; set; }
        public ChargeAllowances ChargeAllowances { get; set; }
        public Notes Notes { get; set; }
        public MonetaryAmounts MonetaryAmounts { get; set; }
        public Workflow Workflow { get; set; }
    }
    public class Reference
    {
        public string ReferenceName { get; set; }
        public string ReferenceValue { get; set; }
    }

    public class PhysicalAddress
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string Country { get; set; }
        public string County { get; set; }
        public string PostalCode { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public string FormattedAddress { get; set; }
        public string AddressNumber { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string ValidationText { get; set; }
        public string Dba { get; set; }
        public string GeocodeProvider { get; set; }
    }

    public class GeneralAddress
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string Country { get; set; }
        public string County { get; set; }
        public string PostalCode { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public string FormattedAddress { get; set; }
        public string AddressNumber { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string ValidationText { get; set; }
        public string Dba { get; set; }
        public string GeocodeProvider { get; set; }
    }

    public class DryReceivingHours
    {
        public string MondayOpenTime { get; set; }
        public string MondayCloseTime { get; set; }
        public bool MondayClosed { get; set; }
        public string TuesdayOpenTime { get; set; }
        public string TuesdayCloseTime { get; set; }
        public bool TuesdayClosed { get; set; }
        public string WednesdayOpenTime { get; set; }
        public string WednesdayCloseTime { get; set; }
        public bool WednesdayClosed { get; set; }
        public string ThursdayOpenTime { get; set; }
        public string ThursdayCloseTime { get; set; }
        public bool ThursdayClosed { get; set; }
        public string FridayOpenTime { get; set; }
        public string FridayCloseTime { get; set; }
        public bool FridayClosed { get; set; }
        public string SaturdayOpenTime { get; set; }
        public string SaturdayCloseTime { get; set; }
        public bool SaturdayClosed { get; set; }
        public string SundayOpenTime { get; set; }
        public string SundayCloseTime { get; set; }
        public bool SundayClosed { get; set; }
    }

    public class DryShippingHours
    {
        public string MondayOpenTime { get; set; }
        public string MondayCloseTime { get; set; }
        public bool MondayClosed { get; set; }
        public string TuesdayOpenTime { get; set; }
        public string TuesdayCloseTime { get; set; }
        public bool TuesdayClosed { get; set; }
        public string WednesdayOpenTime { get; set; }
        public string WednesdayCloseTime { get; set; }
        public bool WednesdayClosed { get; set; }
        public string ThursdayOpenTime { get; set; }
        public string ThursdayCloseTime { get; set; }
        public bool ThursdayClosed { get; set; }
        public string FridayOpenTime { get; set; }
        public string FridayCloseTime { get; set; }
        public bool FridayClosed { get; set; }
        public string SaturdayOpenTime { get; set; }
        public string SaturdayCloseTime { get; set; }
        public bool SaturdayClosed { get; set; }
        public string SundayOpenTime { get; set; }
        public string SundayCloseTime { get; set; }
        public bool SundayClosed { get; set; }
    }

    public class CustomAddress
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string Country { get; set; }
        public string County { get; set; }
        public string PostalCode { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public string FormattedAddress { get; set; }
        public string AddressNumber { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string ValidationText { get; set; }
        public string Dba { get; set; }
        public string GeocodeProvider { get; set; }
    }

    public class UnicodeAddress
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string Country { get; set; }
        public string County { get; set; }
        public string PostalCode { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public string FormattedAddress { get; set; }
        public string AddressNumber { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string ValidationText { get; set; }
        public string Dba { get; set; }
        public string GeocodeProvider { get; set; }
    }

    public class TempControlledReceivingHours
    {
        public string MondayOpenTime { get; set; }
        public string MondayCloseTime { get; set; }
        public bool MondayClosed { get; set; }
        public string TuesdayOpenTime { get; set; }
        public string TuesdayCloseTime { get; set; }
        public bool TuesdayClosed { get; set; }
        public string WednesdayOpenTime { get; set; }
        public string WednesdayCloseTime { get; set; }
        public bool WednesdayClosed { get; set; }
        public string ThursdayOpenTime { get; set; }
        public string ThursdayCloseTime { get; set; }
        public bool ThursdayClosed { get; set; }
        public string FridayOpenTime { get; set; }
        public string FridayCloseTime { get; set; }
        public bool FridayClosed { get; set; }
        public string SaturdayOpenTime { get; set; }
        public string SaturdayCloseTime { get; set; }
        public bool SaturdayClosed { get; set; }
        public string SundayOpenTime { get; set; }
        public string SundayCloseTime { get; set; }
        public bool SundayClosed { get; set; }
    }

    public class TempControlledShippingHours
    {
        public string MondayOpenTime { get; set; }
        public string MondayCloseTime { get; set; }
        public bool MondayClosed { get; set; }
        public string TuesdayOpenTime { get; set; }
        public string TuesdayCloseTime { get; set; }
        public bool TuesdayClosed { get; set; }
        public string WednesdayOpenTime { get; set; }
        public string WednesdayCloseTime { get; set; }
        public bool WednesdayClosed { get; set; }
        public string ThursdayOpenTime { get; set; }
        public string ThursdayCloseTime { get; set; }
        public bool ThursdayClosed { get; set; }
        public string FridayOpenTime { get; set; }
        public string FridayCloseTime { get; set; }
        public bool FridayClosed { get; set; }
        public string SaturdayOpenTime { get; set; }
        public string SaturdayCloseTime { get; set; }
        public bool SaturdayClosed { get; set; }
        public string SundayOpenTime { get; set; }
        public string SundayCloseTime { get; set; }
        public bool SundayClosed { get; set; }
    }

    public class Location
    {
        public string LocationId { get; set; }
        public string LocationCodeQualifier { get; set; }
        public string LocationNumber { get; set; }
        public string PartyCode { get; set; }
        public string PartyNumber { get; set; }
        public string LocationType { get; set; }
        public string LoadingWork { get; set; }
        public string UnloadingWork { get; set; }
        public string LoadingScheduling { get; set; }
        public string UnloadingScheduling { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Contact { get; set; }
        public PhysicalAddress PhysicalAddress { get; set; }
        public GeneralAddress GeneralAddress { get; set; }
        public DryReceivingHours DryReceivingHours { get; set; }
        public DryShippingHours DryShippingHours { get; set; }
        public string Status { get; set; }
        public string EmailAddress { get; set; }
        public string Fax { get; set; }
        public string Notes { get; set; }
        public CustomAddress CustomAddress { get; set; }
        public UnicodeAddress UnicodeAddress { get; set; }
        public string UnicodeContact { get; set; }
        public string DialingCode { get; set; }
        public string LoadingTypeRDN { get; set; }
        public string UnicodeName { get; set; }
        public TempControlledReceivingHours TempControlledReceivingHours { get; set; }
        public TempControlledShippingHours TempControlledShippingHours { get; set; }
        public string PortCode { get; set; }
    }

    public class Vendor
    {
        public string VendorId { get; set; }
        public string VendorName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Phone { get; set; }
        public string TerminalId { get; set; }
        public string ZoneId { get; set; }
        public bool HasUniqueItems { get; set; }
        public string ErpId { get; set; }
        public bool IsActive { get; set; }
        public string OrderCutOffTime { get; set; }
        public string TimeZone { get; set; }
        public string WCode { get; set; }
        public string CreateDate { get; set; }
        public string RegistryTimeZone { get; set; }
        public string VendorAddress1 { get; set; }
        public string VendorAddress2 { get; set; }
        public string VendorCity { get; set; }
        public string VendorState { get; set; }
        public string VendorZip { get; set; }
        public string VendorCountryCode { get; set; }
        public string VendorCustomerNumber { get; set; }
        public string VendorLocationNumber { get; set; }
        public List<Reference> References { get; set; }
        public List<Location> Locations { get; set; }
    }
    public class Concept
    {
        public string ConceptId { get; set; }
        public string ConceptName { get; set; }
        public string CustomerCode { get; set; }
        public string BranchId { get; set; }
        public string CoveringBranchId { get; set; }
        public bool UseDefaultFees { get; set; }
        public decimal CMargin { get; set; }
        public decimal CProdMargin { get; set; }
        public bool CognosProcess { get; set; }
        public bool FinProcess { get; set; }
        public string UserLogo { get; set; }
        public string ConceptLogo { get; set; }
        public string Theme { get; set; }
        public string SalesId { get; set; }
        public string ZoneId { get; set; }
        public string TermId { get; set; }
        public string ShortName { get; set; }
        public bool CompassProcess { get; set; }
        public string CreateDate { get; set; }
        public bool OpenPurchaseOrderCheck { get; set; }
        public string ParentGroupId { get; set; }
        public string HostUrl { get; set; }
        public string HostUrlImg { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string ParentGroupName { get; set; }
        public string ConceptShortName { get; set; }
        public string CCode { get; set; }
        public string LocationId { get; set; }
        public string RollupId { get; set; }
        public List<Reference> References { get; set; }
        public List<Location> Locations { get; set; }
    }

    public class EmailAddresses
    {
        public string EmailAddress { get; set; }
    }

    public class Account
    {
        public string AccountId { get; set; }
        public string ConceptId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Phone { get; set; }
        public string Zip { get; set; }
        public string LocationId { get; set; }
        public string StoreNumber { get; set; }
        public string ShipperCode { get; set; }
        public string WarehouseCode { get; set; }
        public bool Active { get; set; }
        public string CreateDate { get; set; }
        public string WebUserName { get; set; }
        public string WebPassword { get; set; }
        public bool ExportPricing { get; set; }
        public List<EmailAddresses> EmailAddresses { get; set; }
        public string ConceptColor { get; set; }
        public string ConceptName { get; set; }
        public string AccountName { get; set; }
        public string AccountAddress1 { get; set; }
        public string AccountAddress2 { get; set; }
        public string AccountCity { get; set; }
        public string AccountState { get; set; }
        public string AccountZip { get; set; }
        public string AccountCountryCode { get; set; }
        public Concept Concept { get; set; }
        public List<Reference> References { get; set; }
        public List<Location> Locations { get; set; }
    }

    public class InvoiceDetail
    {
        public string InvoiceDetailId { get; set; }
        public string VendorId { get; set; }
        public string InvoiceId { get; set; }
        public string InvoiceLineNumber { get; set; }
        public string ItemNumber { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal PriceOrdered { get; set; }
        public int QuantityOrdered { get; set; }
        public int QuantityShipped { get; set; }
        public int ConversionFactor { get; set; }
        public bool Catch { get; set; }
        public int Weight { get; set; }
        public int ExtendedTax { get; set; }
        public string Ogtin { get; set; }
        public decimal Margin { get; set; }
        public decimal ProductionMargin { get; set; }
        public string LotNumber { get; set; }
        public string CreateDate { get; set; }
        public string MasterRecordId { get; set; }
        public bool Visible { get; set; }
        public bool SubbedItem { get; set; }
        public string PackSize { get; set; }
        public decimal BuyPrice { get; set; }
        public int NonSystemQuantityOrdered { get; set; }
        public decimal ExtendedPrice { get; set; }
        public decimal TotalMargin { get; set; }
        public List<Reference> References { get; set; }
        public string Brand { get; set; }
        public string Lot { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalBuyPrice { get; set; }
        public string SKU { get; set; }
        public string UPC { get; set; }
        public string CHRUnit { get; set; }
        public string CHRDescription { get; set; }
        public string CHRItemNumber { get; set; }
        public string CHRPackSize { get; set; }
        public string SenderUnit { get; set; }
        public string SenderDescription { get; set; }
        public string SenderItemNumber { get; set; }
        public string SenderPackSize { get; set; }
        public string ReceiverUnit { get; set; }
        public string ReceiverDescription { get; set; }
        public string ReceiverItemNumber { get; set; }
        public string ReceiverPackSize { get; set; }
        public string GtinLotKey { get; set; }
        public bool IsConsolidated { get; set; }
    }

    public class MPData
    {
        public string SenderUniqueId { get; set; }
        public string SenderCompanyName { get; set; }
        public string ReceiverUniqueId { get; set; }
        public string ReceiverCompanyName { get; set; }
        public string InterchangeControlNumber { get; set; }
        public string GroupControlId { get; set; }
        public string GroupControlNumber { get; set; }
        public string DocumentControlId { get; set; }
        public string DocumentControlNumber { get; set; }
        public string InterchangeSenderId { get; set; }
        public string InterchangeReceiverId { get; set; }
        public string GroupSenderId { get; set; }
        public string GroupReceiverId { get; set; }
        public string Version { get; set; }
    }

    public class PaymentTerms
    {
        public string PaymentTermType { get; set; }
        public string PaymentTermsBasisDateCode { get; set; }
        public int PaymentTermsDiscountPercentage { get; set; }
        public string PaymentTermsDiscountDate { get; set; }
        public string PaymentTermsDiscountDueDays { get; set; }
        public string PaymentTermsNetDueDate { get; set; }
        public string PaymentTermsNetDueDays { get; set; }
        public decimal PaymentTermsDiscountAmount { get; set; }
        public string PaymentTermsDeferredDueDate { get; set; }
        public decimal PaymentTermsDeferredAmountDue { get; set; }
        public string PaymentTermsDescription { get; set; }
        public string PaymentMethodCode { get; set; }
        public string PaymentMethodId { get; set; }
        public string PaymentTermsStartDate { get; set; }
        public string AmountSubjectToDiscount { get; set; }
    }

    public class Contacts
    {
        public string ContactId { get; set; }
        public string ContactType { get; set; }
        public string ContactName { get; set; }
        public string PrimaryPhone { get; set; }
        public string PrimaryFax { get; set; }
        public string PrimaryEmail { get; set; }
        public List<Location> Locations { get; set; }
    }

    public class FreightTerms
    {
        public string FreightTermType { get; set; }
        public string FreightPayCode { get; set; }
        public string FreightLocationQualifier { get; set; }
        public string FreightLocationDescription { get; set; }
        public string FreightTitlePassageCode { get; set; }
        public string FreightTitlePassageLocation { get; set; }
        public string FreightRiskOfLossCode { get; set; }
        public string FreightDescription { get; set; }
    }

    public class Packaging
    {
        public string ItemDescriptionType { get; set; }
        public string PackagingCharacteristicCode { get; set; }
        public string PackagingDescriptionCode { get; set; }
        public string PackagingDescription { get; set; }
        public string UnitLoadOptionCode { get; set; }
        public string RangeMinimum { get; set; }
        public string RangeMaximum { get; set; }
        public string PackingMaterial { get; set; }
        public int PackagingWeight { get; set; }
        public string PackagingWeightUOM { get; set; }
        public int Volume { get; set; }
        public string VolumeUOM { get; set; }
    }

    public class Carrier
    {
        public string CarrierId { get; set; }
        public string CarrierTransMethodCode { get; set; }
        public string CarrierAlphaCode { get; set; }
        public string CarrierRouting { get; set; }
        public string EquipmentType { get; set; }
        public string SealStatusCode { get; set; }
        public string SealNumber { get; set; }
        public string TransitDirectionCode { get; set; }
        public string TransitTimeQualifier { get; set; }
        public string TransitTime { get; set; }
    }

    public class Sourcing
    {
        public string Area { get; set; }
        public string Zone { get; set; }
        public string Lot { get; set; }
        public string PickDate { get; set; }
    }

    public class Tax
    {
        public string TaxTypeCode { get; set; }
        public decimal TaxAmount { get; set; }
        public string TaxPercentQualifier { get; set; }
        public string TaxPercent { get; set; }
        public string JurisdictionQualifier { get; set; }
        public string JurisdictionCode { get; set; }
        public string TaxExemptCode { get; set; }
        public string RelationshipCode { get; set; }
        public string PctDollarBasis { get; set; }
        public string TaxHandlingCode { get; set; }
        public string TaxId { get; set; }
        public string AssignedId { get; set; }
        public string Description { get; set; }
    }

    public class ChargeAllowances
    {
        public bool AllowChargeIndicator { get; set; }
        public string AllowChargeCode { get; set; }
        public decimal AllowChargeAmount { get; set; }
        public string AllowChargePercent { get; set; }
        public string AllowChargeQuantity { get; set; }
        public string AllowChargeHandlingDescription { get; set; }
    }

    public class Notes
    {
        public string NoteCode { get; set; }
        public string NotesData1 { get; set; }
        public string NotesData2 { get; set; }
    }

    public class MonetaryAmounts
    {
        public string MonetaryAmountId { get; set; }
        public string MonetaryAmountCode { get; set; }
        public decimal MonetaryAmount { get; set; }
        public string CreditDebitFlag { get; set; }
    }

    public class WorkflowStatusDate
    {
        public string WorkflowStatusDateId { get; set; }
        public string WorkflowId { get; set; }
        public string WorkflowStatusTypeId { get; set; }
        public string WorkflowStatusDtUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public string DtUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string DtCreated { get; set; }
    }

    public class Workflow
    {
        public string WorkflowId { get; set; }
        public string PoHeaderId { get; set; }
        public string InvoiceId { get; set; }
        public string CurrentStatus { get; set; }
        public string CurrentStatusDate { get; set; }
        public bool IsHold { get; set; }
        public string HoldDtUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public string DtUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string DtCreated { get; set; }
        public List<WorkflowStatusDate> WorkflowStatusDates { get; set; }
    }
}
