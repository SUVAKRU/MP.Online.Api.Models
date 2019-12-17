using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Customer
{
    public class CustomerDashboard
    {
        public int InProgress { get; set; }
        public int Approved { get; set; }
        public int Rejected { get; set; }
        public List<Customer> CustomerList { get; set; }
    }
}
