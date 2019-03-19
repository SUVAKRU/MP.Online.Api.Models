using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Responses.Vendor
{
    public class SendJsonResponse : IHasResponseStatus
    {
        public ResponseStatus ResponseStatus { get ; set ; }
        public string Message { get; set; }
        public int  NoOfFiles { get; set; }
        public List<JsonFileInfo> JsonFilesInfo { get; set; }
    }

    public class JsonFileInfo
    {
        public string FileName { get; set; }

        public string Message { get; set; }
    }
}
