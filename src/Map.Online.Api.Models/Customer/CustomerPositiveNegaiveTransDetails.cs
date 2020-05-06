using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Customer
{
    public class CustomerPositiveNegaiveTransDetails
    {
        public int PositiveNegativeId { get; set; }
        public int CustomerTransactionId { get; set; }
        public decimal FirstPosition { get; set; }
        public string Operator { get; set; }
        public int CompareValue { get; set; }
        public string TrueValue { get; set; }
        public string FalseValue { get; set; }
        public decimal ResultPosition { get; set; }
    }
}
