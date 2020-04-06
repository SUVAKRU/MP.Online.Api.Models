using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.FileEngine
{
    public class SiMapTransactionResponse
    {

        public int FieldId { get; set; }
        public string FieldName { get; set; }
        public string FieldType { get; set; }
        public int SiMapFieldPositionId { get; set; }
        public int MapTemplateId { get; set; }
        public int SeqNum { get; set; }
        public string MapName { get; set; }
        public string Isactive { get; set; }
        public string FileTypeName { get; set; }
        public int NoOfFiles { get; set; }
        public string TypeOfFile { get; set; }
        public string FieldSeparator { get; set; }
        public string GUID { get; set; }
        public int TransactionID { get; set; }
        public int StartPosition { get; set; }
        public int Width { get; set; }
        public decimal Position { get; set; }
        public string DefaultValue { get; set; }
        public string CharName { get; set; }
        public string CharValue { get; set; }
        public int VendorId { get; set; }
        public string DataType { get; set; }
        public bool IsRightAligned { get; set; }

        public int FieldLengthtoDisplay { get; set; }
        public bool IsFieldValueFromRight { get; set; }
        public string HeaderText { get; set; }

    }
}
