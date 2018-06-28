using MP.Online.Api.Models.FileEngine;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.Online.Api.Models.Responses.Vendor
{
    public class InvoiceTransactionResponse : IHasResponseStatus
    {
        public List<TransactionMapDetailResponse> TransactionMapDetailResponseList { get; set; }
        public string Message { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
    }
}
