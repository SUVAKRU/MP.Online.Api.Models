using MP.Online.Api.Models.Vendor;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.Online.Api.Models.Responses.Vendor
{
    public class TransactionResponse : IHasResponseStatus
    {
        public string Message { get; set; }

        public List<TransactionDetails> TransactionDetails { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
    }
}
