using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.MasterData
{
    public class EdiSegment
    {
       public int  SegmentID{get;set;}
       public string  SegmentName{get;set;}
        public bool IsDetailType { get; set; }
        public bool  IsActive{get;set;}
        public bool IsLoopSegment { get; set; }
        public int ColumnCount { get; set; }
        public bool IsLastSegment { get; set; }
        public int OrderSequence { get; set; }
        public string ClientType { get; set; }
        public bool IsFirstDetailItem { get; set; }
    }
}
