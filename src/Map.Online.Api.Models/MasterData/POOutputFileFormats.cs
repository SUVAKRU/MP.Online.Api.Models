using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.Online.Api.Models.MasterData
{
    public class POOutputFileFormats
    {
        public int POFileFormatID { get; set; }
        public string POFileFormatName { get; set; }
        public string POFileFormatDescription { get; set; }
        public string FileType { get; set; }
        public bool IsActive { get; set; }

    }
}
