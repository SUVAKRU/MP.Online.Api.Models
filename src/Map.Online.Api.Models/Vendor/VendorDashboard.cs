using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Vendor
{
    public class VendorDashboard
    {
        public int InProgress { get; set; }
        public int Approved { get; set; }
        public int Rejected { get; set; }
        public List<Vendor> VendorList { get; set; }
    }
}
