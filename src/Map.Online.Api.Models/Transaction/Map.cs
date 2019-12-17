
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Transaction
{
    public class Map
    {
        public decimal Position { get; set; }
        public int PositionValue { get; set; }
        public int FieldId { get; set; }
        public string FieldName { get; set; }
        public string FieldType { get; set; }
        //public int PositionOrder { get; set; }
        public int StartPosition { get; set; }  
        public int Width { get; set; }
        public int  EnclosedMapcharId { get; set; }
        public string DefaultValue { get; set; }
        public bool IsRightAligned { get; set; }
        public int FieldLengthtoDisplay { get; set; }
        public bool IsFieldValueFromRight { get; set; }
        public string IsEnclosedwith { get; set; }
        public string SegmentName { get; set; }
        public string XMLSegmentName { get; set; }
        public int Index{ get; set; }
        public int TransactionMapDetailId { get; set; }
    }
}
