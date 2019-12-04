using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.MasterData
{
    public class XMLFields
    {
        public int XMLFieldId { get; set; }
        public string XMLField { get; set; }
        public string DisplayName { get; set; }
        public bool IsActive { get; set; }
        public int XMLTypeId { get; set; }
        public bool IsParent { get; set; }
        public bool IsRepeates { get; set; }
        public int SortOrder { get; set; }
        public int DisplayOrder { get; set; }
        public string FieldType { get; set; }
        public int ParentId { get; set; }
        public string ClientType { get; set; }
        public bool IsAttribute { get; set; }
        public bool IsXmlAttribute { get; set; }
    }
}
