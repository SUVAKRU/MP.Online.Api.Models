﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;
using Map.Online.Api.Models.MasterData;

namespace Map.Online.Api.Models.Responses
{
    public class DateFormatsResponse :IHasResponseStatus
    {
        public List<DateFormats> DateFormatsList { get; set; }
        public string Message { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
    }
}
