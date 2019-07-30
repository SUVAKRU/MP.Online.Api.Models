using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Enums
{
  
    public enum FileStatus
    {
        InProgress=1,
        Passed=2,
        Rejected=3,
    }

    public enum VendorStatus
    {
       Inprogress=1,
       CommsApproved=2,
       CommsRejected=3,
       Approved=4,
       Rejected=5
    }

    public enum TransactionType
    {
        Invoice=1,
        PO=2,
        CustomerInvoice=3,
        CustomerPO=4
    }


    //public enum AuditingStatus
    //{
    //    Start = 01,
    //    Processfile = 02,
    //    ReadDetailData = 03,
    //    ReadHeaderData = 04,
    //    PrepareOutData = 05,
    //    ConvertDate = 06,
    //    CalculateLineNumber = 07,
    //    WritetoFile = 08,
    //    Success = 09,
    //    Failed = 10
    //}
     
     public static class Enums
    { 
        public static string FileStatusCode(int statusCode)
        {
            string result = string.Empty;
            switch(statusCode)
            {
                case 1:
                    result = FileStatus.InProgress.ToString();
                    break;
                case 2:
                    result = FileStatus.Passed.ToString();
                    break;
                case 3:
                    result = FileStatus.Rejected.ToString();
                    break;
                default:
                    result = "";
                    break;
            }
            return result;
        }

        public static string VendorStatusValue(int statusCode)
        {
            string Result = string.Empty;
            switch(statusCode)
            {
                case 1:
                    Result= VendorStatus.Inprogress.ToString();
                    break;
                case 2:
                    Result= VendorStatus.CommsApproved.ToString();
                    break;
                case 3:
                    Result= VendorStatus.CommsRejected.ToString();
                    break;
                case 4:
                    Result = VendorStatus.Approved.ToString();
                    break;
                case 5:
                    Result = VendorStatus.Rejected.ToString();
                    break;
                default:
                    Result = "";
                    break;
            }
            return Result;
        }

        public static string TransactionTypes(int transactionTypeId)
        {
            string Result = string.Empty;
            switch(transactionTypeId)
            {
                case 1:
                    Result = TransactionType.Invoice.ToString();
                    break;
                case 2:
                    Result = TransactionType.PO.ToString();
                    break;
                default:
                    Result = "";
                    break;

    
            }
            return Result;
        }

        //public static string AuditingStatus(string StatusCode)
        //{
        //    string Result = string.Empty;
        //    switch(StatusCode)
        //    {
        //        case "A01":
        //            Result = "Start";
        //            break;
        //        case "A02":
        //            Result = "Process file";
        //            break;
        //        case "A03":
        //            Result = "Read detail data";
        //            break;
        //        case "A04":
        //            Result = "Read header data";
        //            break;
        //        case "A05":
        //            Result = "Prepare out data";
        //            break;
        //        case "A06":
        //            Result = "Convert date";
        //            break;
        //        case "A07":
        //            Result = "Calculate line number";
        //            break;
        //        case "A08":
        //            Result = "Write to file";
        //            break;
        //        case "A09":
        //            Result = "Success";
        //            break;
        //        case "A10":
        //            Result = "Failed";
        //            break;
        //        default:
        //            Result = "";
        //            break;
        //    }
        //    return Result;
        //}
    }
}
