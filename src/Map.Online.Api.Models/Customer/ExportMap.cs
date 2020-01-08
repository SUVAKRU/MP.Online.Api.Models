using System.Collections.Generic;

namespace Map.Online.Api.Models.Customer
{
    public class ExportMap
    {
        public int CustomerId { set; get; }
        //public string VendorName { set; get; }
        public string TransactionName { set; get; }
        public string TransactionType { set; get; }
        public string InputDateformat { set; get; }
        public string InputFileType { set; get; }
        public string NoofHeaderRows { set; get; }
        public int NumberOfFooterRows { get; set; }
        public string RowsToIgnore { set; get; }
        public string SenderID { set; get; }
        public string ReceiverID { set; get; }
        public string CreatedDate { set; get; }
        public string HeaderNameText { get; set; }
        public string DetailNameText { get; set; }
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
        public string SubElementSeparator { get; set; }
        public string SenderCode { get; set; }
        public string ReceiverCode { get; set; }
        public string Version { get; set; }
        public string SegmentSeparator { get; set; }
        public string Preceder { get; set; }
        public int FieldLengthtoDisplay { get; set; }
        public bool IsFieldValueFromRight { get; set; }
        public string FooterText { get; set; }
        public string CustomerNumber { get; set; }
        public string CommonNumber { get; set; }
        public List<ExportMapDetails> ExportMapDetailsCount { get; set; }
    }

    public class ExportMapDetails
    {
        public string Width { set; get; }
        public string StartPosition { set; get; }
        public string FieldName { set; get; }

        public string Position { set; get; }
        public string DefaultValue { set; get; }
        public string IsEnclosedwith { set; get; }
        public string FieldID { set; get; }
        public string SegmentName { get; set; }
        public string XMLSegmentName { get; set; }
        public string HeaderText { get; set; }
    }
}










