using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Map.Online.Api.Models.Auth0
{
   public class Auth0Model
    {
        [JsonProperty("connection")]
        public string Connection { get; set; }
        public string Domain { get; set; }
        public string AccessToken { get; set; }
    }

    public class UserModel
    {
        [JsonProperty("username")]
        public string UserName { get; set; }
       
         [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }     
        [JsonProperty("connection")]
        public string Connection { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

    }


}
