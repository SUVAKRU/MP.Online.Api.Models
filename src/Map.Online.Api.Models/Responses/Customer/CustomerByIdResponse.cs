using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Map.Online.Api.Models.Vendor;
using ServiceStack;

namespace Map.Online.Api.Models.Responses.Customer
{
    public class CustomerByIdResponse: IHasResponseStatus
    {
    public string Message { get; set; }
    public ResponseStatus ResponseStatus { get; set; }
    public Models.Vendor.Vendor VendorDetail { get; set; }
    }
}
