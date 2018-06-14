using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;
namespace Map.Online.Api.Models.Responses
{
   public class UpdateUserResponse : IHasResponseStatus
    {
        public string Message { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
    }
}
