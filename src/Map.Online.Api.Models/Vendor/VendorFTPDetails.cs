using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.Online.Api.Models.Vendor
{
    public class VendorFTPDetails
    {
        public int vendorId { get; set; }
        public string IpAddressOrPort { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string CHRAccessedFTPPath { get; set; }
        public string CommsComment { get; set; }
        public int CreatedBy { get; set; }
        public int Status { get; set; }
        public int ModifiedBy { get; set; }
    }
}
