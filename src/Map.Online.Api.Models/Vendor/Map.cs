using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Vendor
{
    public class Map
    {
        public decimal Position { get; set; }
        public int PositionValue { get; set; }  
             
        //public int PositionOrder { get; set; }
        public int StartPosition { get; set; }  
        public int Width { get; set; }
        public int  EnclosedMapcharId { get; set; }
        public string DefaultValue { get; set; }
        public bool IsRightAligned { get; set; }
    }
}
