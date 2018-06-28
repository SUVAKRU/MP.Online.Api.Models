using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.Online.Api.Models.Vendor
{
    public class ExportMap
    {
        public int VendorId { set; get; }
        public string VendorName { set; get; }
        public string TransactionName { set; get; }
        public string TransactionType { set; get; }
        public string InputDateformat { set; get; }
        public string InputFileType { set; get; }
        public string NoofHeaderRows { set; get; }
        public string RowsToIgnore { set; get; }
        public string SenderID { set; get; }
        public string ReceiverID { set; get; }
        public string CreatedDate { set; get; }

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


    }
}










