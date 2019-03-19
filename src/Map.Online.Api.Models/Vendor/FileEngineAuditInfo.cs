using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Vendor
{
    public class FileEngineAuditInfo
    {
        public int AuditId { get; set; }
        public int TransactionId { get; set; }
        public string TransactionType { get; set; }
        public int TransactionTypeId { get; set; }
        public string InputFileName { get; set; }
        public string HeaderFileName { get; set; }
        public string FileType { get; set; }
        public bool IsProd { get; set; }
        //will have prod or setup based on the file process way.
        public string ProcessType { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public int GroupId { get; set; }
        public string CreatedDate { get; set; }
        public string TransactionName { get; set; }
        public string LastSuccessDate { get; set; }
        public string LastFailedDate { get; set; }
        public string StatusCode { get; set; }
        public string IsActualFile { get; set; }

        public List<BusinessComments> Comments { get; set; }

    }

    public class BusinessComments
    {
        public int CommentID { get; set; }
        public int AuditId { get; set; }
        public string Comment { get; set; }
        public int Status { get; set; }
        public bool IsActive { get; set; }
        public int AddedBy { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedDate { get; set; }
        public string VendorName { get; set; }
        public string StatusValue { get; set; }
    }
}
