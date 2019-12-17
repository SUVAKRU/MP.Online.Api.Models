using Map.Online.Api.Models.Vendor;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Responses
{
    public class TransactionResponse : IHasResponseStatus
    {
        public string Message { get; set; }

        public List<TransactionDetails> TransactionDetails { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
    }
}
