using Map.Online.Api.Models.Customer;
using ServiceStack;
using System.Collections.Generic;

namespace Map.Online.Api.Models.Responses.Customer
{
    public class CustomerTransactionResponse : IHasResponseStatus
    {
            public int TransactionId { get; set; }
            public string Message { get; set; }
            public List<TransactionDetails> TransactionDetails { get; set; }
            public List<RedropLocations> DropLocations { get; set; }
            public ResponseStatus ResponseStatus { get; set; }
    }
}
