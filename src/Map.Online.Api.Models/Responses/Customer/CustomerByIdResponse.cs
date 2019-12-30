using Map.Online.Api.Models.Customer;
using ServiceStack;

namespace Map.Online.Api.Models.Responses.Customer
{
    public class CustomerByIdResponse : IHasResponseStatus
    {
        public string Message { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
        public CustomerDetails CustomerDetail { get; set; }
    }
}
