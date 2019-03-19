using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Vendor
{
   public class VendorMapping
    {
        public int VednorMappingId { get; set; }
        public string VendorCode { get; set; }
        public int VendorNumber { get; set; }
        public bool IsActive{ get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string  CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
