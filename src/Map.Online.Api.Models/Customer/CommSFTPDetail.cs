using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Customer
{
  public  class CommSFTPDetail
    {
        public int CustomerId { get; set; }
        public string IpAddressOrPort { get; set; }
        public string CHRAccessedFTPPath { get; set; }

        public string CommsComment { get; set; }
    }
}
