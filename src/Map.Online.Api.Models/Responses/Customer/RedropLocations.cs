using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Responses.Customer
{
    public class RedropLocations : IHasResponseStatus
    {
        public int RedropLocationId { get; set; }
        public string customerNumber { get; set; }
        public string locationPath { get; set; }
        public bool isSourceDuplicate { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
    }
}
