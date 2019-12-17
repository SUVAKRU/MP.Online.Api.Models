using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Customer
{
    public class VerifyCustomerDetails
    {
        int CustomerId { get; set; }
        string CustomerNumber { get; set; }

        string CustomerName { get; set; }
        bool IsrecordExistorNot { get; set; }
    }
}
