﻿using Map.Online.Api.Models.MasterData;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Responses
{
    public class TransactionTypesResponse : IHasResponseStatus
    {
        public List<TransactionType> TransactionTypesList { get; set; }
        public string Message { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
    }
}
