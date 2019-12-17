using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Customer
{
   public class CustomerMapping
    {
        public int CustomerMappingId { get; set; }
        public int customerId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerNumber { get; set; }
        public bool IsActive{ get; set; }
        public string FTPPath { get; set; }
        public char Type { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string  CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
