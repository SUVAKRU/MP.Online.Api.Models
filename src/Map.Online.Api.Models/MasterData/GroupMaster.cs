using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.MasterData
{
    public class GroupMaster
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public bool IsActive { get; set; }
    }
}
