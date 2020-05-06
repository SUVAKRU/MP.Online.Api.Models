using Map.Online.Api.Models.Responses.Vendor;
using ServiceStack;
using System.Collections.Generic;

namespace Map.Online.Api.Models.Responses
{
    public class CreateTransactionResponse : IHasResponseStatus
    {
        public int TransactionId { get; set; }
        public string Message { get; set; }
        public List<VendorRedropLocations> DropLocations { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
    }
}
