using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.Online.Api.Models.Vendor
{
    public class FileContent
    {
        public int TransactionId { get; set; }
        public int NoOfFiles { get; set; }
        public string TypeOfFile { get; set; }
        public string FieldSeparator { get; set; }
        public byte[] HeaderContent { get; set; }
        public byte[] DetailContent { get; set; }
        public string HeaderFileName { get; set; }
        public string DetailFileName { get; set; }
    }
}
