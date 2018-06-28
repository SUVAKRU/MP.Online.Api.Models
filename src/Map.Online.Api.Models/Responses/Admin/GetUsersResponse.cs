using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;
using MP.Online.Api.Models.Admin;

namespace MP.Online.Api.Models.Responses
{
   public class GetUsersResponse : IHasResponseStatus
    {
        public string Message { get; set; }
        public List<UserDetails> UserDetailsList { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
  }
}
