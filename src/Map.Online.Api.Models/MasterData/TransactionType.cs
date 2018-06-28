using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.Online.Api.Models.MasterData
{
    public class TransactionType
    {
      public int TransactionTypeID { get; set; }
        public string TransactionTypeName { get; set; }
        public bool IsActive { get; set; }
    }
}
