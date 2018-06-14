using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.MasterData
{
    public class CommonMaster
    {
        public List<DateFormats> DateFormats { get; set; }
        public List<EdiSegment> EdiSegments { get; set; }
        public List<FileTypes> FileTypes { get; set; }
        public List<GroupMaster> GroupMaster { get; set; }
        public List<RoleMaster> RoleMaster { get; set; }
        public List<MapFields> MapFields { get; set; }
        public List<TransactionType> TransactionTypes { get; set; }
        public List<QuantityFormats> QuantityFormats { get; set; }
        public List<Vendor.Vendor> Vendors { get; set; }
        public List<XMLTypes> XMLTypes { get; set; }
        public List<XMLFields> XMLFields { get; set; }
    }
}
