using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.MasterData
{
    public class MapFields
    {
        public int FieldId { get; set; }
        public string FieldName { get; set; }
        public int ParentId { get; set; }
        public string ParentNode { get; set; }
        public string FieldType { get; set; }
        public int TransactionType { get; set; }
        public string DispalyName { get; set; }
        public string DataType { get; set; }
        public int DisplayOrder { get; set; }
    }
}
