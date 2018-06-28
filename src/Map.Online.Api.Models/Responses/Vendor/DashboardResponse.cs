using MP.Online.Api.Models.Vendor;
using ServiceStack;


namespace MP.Online.Api.Models.Responses.Vendor
{
    public class DashboardResponse : IHasResponseStatus
    {
        public DashBoard dashBoard { get; set; }
        public string Message { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
    }
}
