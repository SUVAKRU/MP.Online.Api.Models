using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.Online.Api.Models.MasterData
{
    public class FileTypes
    {
        public int FileTypeId { get; set; }
        public string FileTypeName { get; set; }
        public bool IsActive { get; set; }
       public string TypeOfFile { get; set; }
        public int NoOfFiles { get; set; }
        public string FieldSeparator { get; set; }
    }
}
