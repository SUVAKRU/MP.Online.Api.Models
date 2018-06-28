﻿using MP.Online.Api.Models.Vendor;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.Online.Api.Models.Responses.Vendor
{
    public class GetVendorResponse : IHasResponseStatus
    {
        public VendorDashboard vendorDashboard { get; set; }
        public string Message { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
    }
}
