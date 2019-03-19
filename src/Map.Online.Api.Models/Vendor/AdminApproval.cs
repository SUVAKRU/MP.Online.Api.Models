using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Vendor
{
    public class AdminApproval
    {
        public int ModifiedBy { get; set; }
        public int VendorId { get; set; }
        public int Status { get; set; }
    }
}
