using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Vendor
{
    public class DashBoard
    {
        public int Inprogress { get; set; }
        public int Rejected { get; set; }
        public int Passed { get; set; }
        public List<TransactionDetails> transactionGridData { get; set; }
    }

    public class TransactionGridData
    {
        public int Id { get; set; }
        public string TransactionName { get; set; }
        public string Approved { get; set; }
        public string Modified { get; set; }
        public string FileName { get; set; }
        public byte[] HeaderContent { get; set; }
        public byte[] DetailContent { get; set; }
        public int Status { get; set; }
        public string StatusValue { get; set; }
    }
}
