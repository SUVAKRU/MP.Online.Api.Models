﻿using Map.Online.Api.Models.Customer;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Responses.Customer
{
   public  class GetVerifyCustomerResponse : IHasResponseStatus
    {
        public VerifyCustomerDetails verifyCustomerDetails { get; set; }
        public string Message { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
    }
}
