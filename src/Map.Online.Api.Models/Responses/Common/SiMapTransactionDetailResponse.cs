﻿using Map.Online.Api.Models.FileEngine;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Responses
{
    public class SiMapTransactionDetailResponse : IHasResponseStatus
    {
        public List<SiMapTransactionResponse> SiMapTransactionResponseList { get; set; }
        public string Message { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
    }
}
