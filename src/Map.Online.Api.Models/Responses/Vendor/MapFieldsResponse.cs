using MP.Online.Api.Models.MasterData;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.Online.Api.Models.Responses.Vendor
{
    public class MapFieldsResponse : IHasResponseStatus
    {
        public List<MapFields> MapFieldsList { get; set; }
        public string Message { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
    }
}
