using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Vendor
{
  public  class CommSFTPDetail
    {
        public int vendorId { get; set; }
        public string IpAddressOrPort { get; set; }
        public string CHRAccessedFTPPath { get; set; }

        public string CommsComment { get; set; }
    }
}
