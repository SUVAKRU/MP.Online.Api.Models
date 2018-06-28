using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.Online.Api.Models.MasterData
{
    public class QuantityFormats
    {
        public int QuantityFormatId { get; set; }
        public string QuantityFormatType { get; set; }
        public bool IsActive { get; set; }
        public string  value { get; set; }
    }
}
