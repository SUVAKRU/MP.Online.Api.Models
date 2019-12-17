using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Responses.Customer
{
    public class SendCustomerJsonResponse : IHasResponseStatus
    {
        public ResponseStatus ResponseStatus { get ; set ; }
        public string Message { get; set; }
        public int  NoOfFiles { get; set; }
        public List<CustomerJsonFileInfo> JsonFilesInfo { get; set; }
    }

    public class CustomerJsonFileInfo
    {
        public string FileName { get; set; }

        public string Message { get; set; }
    }
}
