using Map.Online.Api.Models.MasterData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Customer
{
    public class CustomerMasterData
    {
        public List<GroupMaster> GroupMasterList { get; set; }
        public List<POOutputFileFormats> POOutputFileFormats { get; set; }
    }
}
