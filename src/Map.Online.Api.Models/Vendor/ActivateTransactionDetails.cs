using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Vendor
{
  public  class ActivateTransactionDetails
    {
        public int vendorId { get; set; } 
        public int transactionId { get; set; }
        public int status { get; set; }
        public string CustomerNumber { get; set; }
        public string CommonNumber { get; set; }
        public int createdBy { get; set; }
    }
}
