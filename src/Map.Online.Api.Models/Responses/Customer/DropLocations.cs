using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Responses.Customer
{
    public class DropLocations : IHasResponseStatus
    {
        public string customerNumber { get; set; }
        public string locationPath { get; set; }
        public bool duplicateSourceFile { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
    }
}
