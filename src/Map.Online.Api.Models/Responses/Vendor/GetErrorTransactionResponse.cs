﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;
using MP.Online.Api.Models.Vendor;

namespace MP.Online.Api.Models.Responses.Vendor
{
    public class GetErrorTransactionResponse:IHasResponseStatus
    {
        public ErrorTransactionDetail errorTransactionDetail { get; set; }
        public string Message { get; set; }

        public ResponseStatus ResponseStatus { get; set; }
    }
}
