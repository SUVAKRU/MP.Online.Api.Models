using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.Online.Api.Models.Responses.Admin
{
     public class ChangePasswordResponse : IHasResponseStatus
    {
        public string Message { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
    }
}
