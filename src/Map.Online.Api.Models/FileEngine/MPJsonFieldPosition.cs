using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.FileEngine
{
    public class MPJsonFieldPosition
    {
        public int JsonFieldId { get; set; }
        public string JsonFieldName { get; set; }
        public int FieldId { get; set; }
        public bool IsParent { get; set; }
        public bool IsRepeats { get; set; }
        public int ParentId { get; set; }
        public int DisplayOrder { get; set; }
        public string DefaultValue { get; set; }
        public int SiMapFieldPositionId { get; set; }

    }
}
