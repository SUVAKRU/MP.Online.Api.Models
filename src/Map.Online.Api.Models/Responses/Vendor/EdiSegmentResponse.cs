using Map.Online.Api.Models.MasterData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;

namespace Map.Online.Api.Models.Responses.Vendor
{
    public class EdiSegmentResponse:IHasResponseStatus
    {
        public List<EdiSegment> ediSegmentList { get; set; }
        public string Message { get; set; }
        public ResponseStatus ResponseStatus { get; set; }

    }
}
