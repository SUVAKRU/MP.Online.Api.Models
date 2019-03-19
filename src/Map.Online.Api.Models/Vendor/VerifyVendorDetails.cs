using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Vendor
{
    public class VerifyVendorDetails
    {
        int VendorId { get; set; }
        int VendorNumber { get; set; }

        string VendorName { get; set; }
        bool IsrecordExistorNot { get; set; }
    }
}
