using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MP.Online.Api.Models.Responses.Vendor;
using ServiceStack;

namespace MP.Online.Api.Models.Tests.UnitTests
{
    [TestClass]
    public class ResponseVendorShould
    {

        [TestMethod]
        public void TestActivateTransactionResponse()
        {
            var details = new ActivateTransactionResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() {ErrorCode = "dfads"}
            };
        }
        [TestMethod]
        public void testChangeStatusResponse()
        {
            var details = new ChangeStatusResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() { ErrorCode = "dfads" }
            };
        }
        [TestMethod]
        public void testCreateTransactionResponse()
        {
            var details = new CreateTransactionResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() { ErrorCode = "dfads" }
            };
        }
        [TestMethod]
        public void testDashboardResponse()
        {
            var details = new DashboardResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() { ErrorCode = "dfads" }
            };
        }
        [TestMethod]
        public void testDateFormatsResponse()
        {
            var details = new DateFormatsResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() { ErrorCode = "dfads" }
            };
        }
        [TestMethod]
        public void testEdiSegmentResponse()
        {
            var details = new EdiSegmentResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() { ErrorCode = "dfads" }
            };
        }
        [TestMethod]
        public void testErrorTransactionResponse()
        {
            var details = new ErrorTransactionResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() { ErrorCode = "dfads" }
            };
        }
        [TestMethod]
        public void testFileContentResponse()
        {
            var details = new FileContentResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() { ErrorCode = "dfads" }
            };
        }
        [TestMethod]
        public void testFileEngineAuditInfoResponse()
        {
            var details = new FileEngineAuditInfoResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() { ErrorCode = "dfads" }
            };
        }
        [TestMethod]
        public void testFileProcessingResponse()
        {
            var details = new FileProcessingResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() { ErrorCode = "dfads" }
            };
        }
        [TestMethod]
        public void testFileTypesResponse()
        {
            var details = new FileTypesResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() { ErrorCode = "dfads" }
            };
        }
        [TestMethod]
        public void testGetCurrentMapDetailsResponse()
        {
            var details = new GetCurrentMapDetailsResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() { ErrorCode = "dfads" }
            };
        }
        [TestMethod]
        public void testGetErrorTransactionResponse()
        {
            var details = new GetErrorTransactionResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() { ErrorCode = "dfads" }
            };
        }
        [TestMethod]
        public void testGetVendorFTPDetailResponse()
        {
            var details = new GetVendorFTPDetailResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() { ErrorCode = "dfads" }
            };
        }
        [TestMethod]
        public void testGetVendorResponse()
        {
            var details = new GetVendorResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() { ErrorCode = "dfads" }
            };
        }
        [TestMethod]
        public void testGetVerifyVendorResponse()
        {
            var details = new GetVerifyVendorResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() { ErrorCode = "dfads" }
            };
        }
        [TestMethod]
        public void testGroupsResponse()
        {
            var details = new GroupsResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() { ErrorCode = "dfads" }
            };
        }
        [TestMethod]
        public void testInvoiceTransactionResponse()
        {
            var details = new InvoiceTransactionResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() { ErrorCode = "dfads" }
            };
        }
        [TestMethod]
        public void testMapFieldsResponse()
        {
            var details = new MapFieldsResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() { ErrorCode = "dfads" }
            };
        }
        [TestMethod]
        public void testPOOutputFileFormatResponse()
        {
            var details = new POOutputFileFormatResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() { ErrorCode = "dfads" }
            };
        }

        [TestMethod]
        public void testRoleMasterResponse()
        {
            var details = new RoleMasterResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() { ErrorCode = "dfads" }
            };
        }
        [TestMethod]
        public void testSaveVendorResponse()
        {
            var details = new SaveVendorResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() { ErrorCode = "dfads" }
            };
        }
        [TestMethod]
        public void testSiMapTransactionDetailResponse()
        {
            var details = new SiMapTransactionDetailResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() { ErrorCode = "dfads" }
            };
        }
        [TestMethod]
        public void testTransactionResponse()
        {
            var details = new TransactionResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() { ErrorCode = "dfads" }
            };
        }
        [TestMethod]
        public void testTransactionTypesResponse()
        {
            var details = new TransactionTypesResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() { ErrorCode = "dfads" }
            };
        }
        [TestMethod]
        public void testUpdateVendorResponse()
        {
            var details = new UpdateVendorResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() { ErrorCode = "dfads" }
            };
        }
        [TestMethod]
        public void testVendorByIdResponse()
        {
            var details = new VendorByIdResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() { ErrorCode = "dfads" }
            };
        }
        [TestMethod]
        public void testVendorFTPDetailResponse()
        {
            var details = new VendorFTPDetailResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() { ErrorCode = "dfads" }
            };
        }
    }
}
