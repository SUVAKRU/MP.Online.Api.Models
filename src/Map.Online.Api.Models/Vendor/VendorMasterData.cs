using MP.Online.Api.Models.MasterData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.Online.Api.Models.Vendor
{
    public class VendorMasterData
    {
        public List<GroupMaster> GroupMasterList { get; set; }
        public List<POOutputFileFormats> POOutputFileFormats { get; set; }
    }
}
