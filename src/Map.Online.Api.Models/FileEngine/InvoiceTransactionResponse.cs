using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.FileEngine
{
    public class InvoiceTransactionResponse
    {
        public int VendorInvTransDetailID { get; set; }
        public int TransactionID { get; set; }
        public string TransactionName { get; set; }
        public int FieldID { get; set; }
        public string FieldName { get; set; }
        public int Position { get; set; }
        public string FieldType { get; set; }
        public int ParentId { get; set; }
        public string ParentNode { get; set; }
        public int TransactionType { get; set; }
    }
}
