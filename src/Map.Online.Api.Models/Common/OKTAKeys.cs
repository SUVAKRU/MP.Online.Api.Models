using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Common
{
    public class OKTAKeys
    {
        public List<Key> keys { get; set; }
    }
    public class Key
    {
        public string kty { get; set; }
        public string alg { get; set; }
        public string kid { get; set; }
        public string use { get; set; }
        public string e { get; set; }
        public string n { get; set; }
    }
}
