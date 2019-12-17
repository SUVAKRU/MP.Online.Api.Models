using Map.Online.Api.Models.Common;
using Map.Online.Api.Models.Responses.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Customer
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerNumber { get; set; }
        public string CustomerName { get; set; }
        public string companyName { get; set; }
        public string primaryContactName { get; set; }
        public string supportContact { get; set; }
        public string emailAddress { get; set; }
        public string primaryTechnicalContact { get; set; }

        public bool isActive { get; set; }
        public int status { get; set; }
        public string statusValue { get; set; }
        //public bool isUnicodeReplaceRequired { get; set; }
        public int createdBy { get; set; }
        public int updatedBy { get; set; }
        //public int POHeaderFileFormatId { get; set; }
        //public int PODetailFileFormatId { get; set; }
        public string FilePath { get; set; }
        public string FileNameToMoveExternal { get; set; }
        public int ISA13Number { get; set; }
        public bool IsSplitRequired { get; set; }
        
        public bool IsPdfRequired { get; set; }
        public string InvoiceDropLocation { get; set; }

        //public string CustomerNumber { get; set; }
        public string CustomerFTPPath { get; set; }
        public int CustomerDetailId { get; set; }
        public string CustomerFileFormat { get; set; }
        public string CustomerNaming { get; set; }
        public string CFileNaming { get; set; }

        public bool IsDefaultToInvoice { get; set; }
        public string InvoiceFileName { get; set; }
        public string POAckFileName { get; set; }
        public List<RedropLocations> ReDropLocations { get; set; }
    }
}
