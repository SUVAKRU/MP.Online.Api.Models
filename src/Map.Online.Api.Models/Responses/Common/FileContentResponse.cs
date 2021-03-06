﻿using Map.Online.Api.Models.Transaction;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Responses
{
    public class FileContentResponse : IHasResponseStatus
    {
        public FileContent fileContent { get; set; }
        public string Message { get; set; }
        public ResponseStatus ResponseStatus { get; set; }

    }
}
