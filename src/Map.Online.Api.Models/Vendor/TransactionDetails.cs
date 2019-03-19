using Map.Online.Api.Models.Vendor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Vendor
{
    public class TransactionDetails
    {

        public int TransactionID { get; set; }
        public string TransactionName { get; set; }
        public int VendorID { get; set; }
        public int TransactionTypeId { get; set; }
        public int FileTypeId { get; set; }
        public string FileName { get; set; }
        public string OutputFileName { get; set; }
        public string GroupName { get; set; }
        public string Comments { get; set; }
        public string ApprovedDate { get; set; }
        public bool IsActiveInTest { get; set; }
        public bool IsActiveInProd { get; set; }
        public int NumberOfInputFiles { get; set; }
        public int NumberOfHeaderRows { get; set; }
        public int InputDateFormatID { get; set; }
        public string InputDateFormat { get; set; }
        public bool IsUnicodeReplaceRequired { get; set; }
        public string EffectiveDate { get; set; }
        public int CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }
        public byte[] DetailedContent { get; set; }
        public byte[] HeaderContent { get; set; }
        public byte[] OutputXMLData { get; set; }
        public int Status { get; set; }
        public string GUID { get; set; }
        public string FieldSeparator { get; set; }
        public List<Map> createMap { get; set; }
        public string StatusValue { get; set; }
        public string TransactionTypeValue { get; set; }
        public string FileTypeValue { get; set; }
        public string IgnoreRows { get; set; }
        public int NumberOfColumns { get; set; }
        public string SenderId { get; set; }
        public string ReceiverId { get; set; }
        public int Price { get; set; }
        public string DetailedContentString { get; set; }
        public string HeaderContentString { get; set; }
        public string OutputXMLDataString { get; set; }

        public string VendorName { get; set; }
        public  string HeaderNameText { get; set; }
        public  string DetailNameText { get; set; }
        public int QuantityFormatId { get; set; }
        public string QuantityFormatType { get; set; }
        public string HeaderLineItem { get; set; }
        public string DetailLineItem { get; set; }
        public string HeaderDateFormat { get; set; }
        public string DetailDateFormat { get; set; }
        public string POHeaderFileFormat { get; set; }
        public string PODetailFileFormat { get; set; }
        public string RelativeDateFormats { get; set; }
        public string FTPFolderName { get; set; }
        public int XMLTypeId { get; set; }
        public string SenderIdQualifier { get; set; }
        public string ReceiverIdQualifier { get; set; }
        public string SubElementSeparator{ get; set; }
        public string SenderCode { get; set; }
        public string ReceiverCode { get; set; }
        public string Version { get; set; }
        public string SegmentSeparator { get; set; }
        public string Preceder { get; set; }
        public int FieldLengthtoDisplay { get; set; }
        public bool IsFieldValueFromRight { get; set; }
        public string FooterText { get; set; }
        public decimal Position { get; set; }
        public string  FieldName { get; set; }

        public int StartPosition { get; set; }
        public int width { get; set; }
        public decimal HeaderInvoicePosition { get; set; }
        public decimal DetailInvoicePosition { get; set; }

        //vendor Details
        public string FilePath { get; set; }
        public string FileNameToMoveExternal { get; set; }

        public int ISA13Number { get; set; }
        public bool IsSplitRequired { get; set; }
    }

}
