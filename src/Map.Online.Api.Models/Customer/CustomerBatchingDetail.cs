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
        public char OccurrenceType { get; set; }
        public bool IsDay { get; set; }
        public DateTime Date { get; set; }
        public string CustomerPickPath { get; set; }
        public bool IsActive { get; set; }
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
