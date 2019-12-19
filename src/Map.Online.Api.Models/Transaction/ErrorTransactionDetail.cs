using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Transaction
{
   public class ErrorTransactionDetail
    {
        public int transactionId { get; set; }
        public int AuditId { get; set; }
        public string Message{ get; set; }
        public string errorDescription { get; set; }
        public string source { get; set; }

        public int createdBy { get; set; }
    }
}
