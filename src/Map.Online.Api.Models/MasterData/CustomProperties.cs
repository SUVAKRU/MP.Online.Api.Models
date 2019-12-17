using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Vendor
{
   public class CustomProperties
    {
        public int StartPosition { get; set; }
        public int Width { get; set; }
        public string Enclosed { get; set; }

        public int DefaultValue { get; set; }
    }
}
