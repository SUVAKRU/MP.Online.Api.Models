using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.Online.Api.Models.FileEngine
{
    public class TransactionMapDetailResponse
    {
        public int TransactionMapDetailID { get; set; }
        public int TransactionID { get; set; }
        public string TransactionName { get; set; }
        public int FieldID { get; set; }
        public string FieldName { get; set; }
        public decimal Position { get; set; }
        public string FieldType { get; set; }
        public int ParentId { get; set; }
        public string ParentNode { get; set; }
        public int TransactionType { get; set; }
        public int MapCharId { get; set; }
        public int StartPosition { get; set; }
        public int Width { get; set; }
        public string CharName { get; set; }
        public string CharValue { get; set; }

        public int FileTypeId { get; set; }
        public string FileTypeName { get; set; }
        public int NoOfFiles { get; set; }
        public string TypeOfFile { get; set; }
        public string FieldSeparator { get; set; }
        public string DefaultValue { get; set; }
        public string DataType { get; set; }
        public string DisplayName { get; set; }
        public bool IsRightAligned { get; set; }
    }
}
