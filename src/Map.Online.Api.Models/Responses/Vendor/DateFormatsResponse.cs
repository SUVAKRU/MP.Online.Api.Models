﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;
using MP.Online.Api.Models.MasterData;

namespace MP.Online.Api.Models.Responses.Vendor
{
    public class DateFormatsResponse :IHasResponseStatus
    {
        public List<DateFormats> DateFormatsList { get; set; }
        public string Message { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
    }
}
