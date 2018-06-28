using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.Online.Api.Models.Vendor
{
    public class TransactionMapDetails
    {
        public int TransactionMapDetailId { get; set; }
        public int TransactionId { get; set; }
        public decimal Position { get; set; }
        public int FieldId { get; set; }
        public string DefaultValue { get; set; }
        public int StartPosition { get; set; }
        public int Width { get; set; }
        public int MAPCharId { get; set; }
        public string MAPCharValue { get; set; }
        public int CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }
        public string FieldType { get; set; }
    }
}
