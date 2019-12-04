using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.MasterData
{
    public class XMLTypes
    {
        public int XMLTypeId { get; set; }
        public string XMLType { get; set; }
        public int TransactionTypeId { get; set; }
        public bool IsActive { get; set; }
        public string ClientType { get; set; }
    }
}
