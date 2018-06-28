
using ServiceStack;

namespace MP.Online.Api.Models.Responses.Vendor
{
    public class VendorByIdResponse: IHasResponseStatus
    {
    public string Message { get; set; }
    public ResponseStatus ResponseStatus { get; set; }
    public Models.Vendor.Vendor VendorDetail { get; set; }
    }
}
