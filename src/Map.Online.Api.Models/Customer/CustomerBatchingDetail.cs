using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Customer
{
    public class CustomerBatchingDetail
    {
        public int CustomerBatchingDetailId { get; set; }
        public int CustomerId { get; set; }
        public string customerName { get; set; }
        public char OccurrenceType { get; set; }
        public string OcurrenceTypeValue { get; set; }
        public string Value { get; set; }
        public string StartDate { get; set; }
        public string CustomerBatchingPath { get; set; }
        public string CustomerInvoicePath { get; set; }
        public string FileType { get; set; }
        public string CustomerNumer { get; set; }
        public bool IsActive { get; set; }
        public bool HasHeader { get; set; }
        public bool IsRepeatedHeader { get; set; }
        public string Times { get; set; }
        public string Days { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<BatchTimingDetail> BatchTimingDetails { get; set; }
    }

    public class BatchTimingDetail
    {
        public int BatchTimingDetailId { get; set; }
        public int CustomerBatchingDetailId { get; set; }
        public int Day { get; set; }
        public TimeSpan Time { get; set; }
        public bool IsActive { get; set; }
    }
}
