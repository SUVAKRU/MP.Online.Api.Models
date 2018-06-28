
using System.Collections.Generic;
using MP.Online.Api.Models.Vendor;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MP.Online.Api.Models.Tests.UnitTests
{
    [TestClass]
    public class VendorShould
    {
        [TestMethod]
        public void TestActivateTransactionDetails()
        {
            var details = new ActivateTransactionDetails()
            {
                vendorId = 1234,
                transactionId = 1234,
                status = 1,
                createdBy = 1234
            };
        }

        [TestMethod]
        public void TestAdminApproval()
        {
            var details = new AdminApproval()
            {
                ModifiedBy = 1234,
                VendorId = 1234,
                Status = 1
            };
        }

        [TestMethod]
        public void TestCommSFTPDetaill()
        {
            var details = new CommSFTPDetail()
            {
                vendorId = 1234,
                IpAddressOrPort = "1234",
                CHRAccessedFTPPath = "1",
                CommsComment = "1"
            };
        }

        [TestMethod]
        public void TestCustomProperties()
        {
            var details = new CustomProperties()
            {
                StartPosition = 1234,
                Width = 123,
                Enclosed = "1",
                DefaultValue = 1
            };
        }

        [TestMethod]
        public void TestDashBoard()
        {
                List<TransactionDetails> grid = new List<TransactionDetails>();
                grid.Add(new TransactionDetails
                {
                    TransactionID = 1,
                    TransactionName = "1",
                    VendorID = 1,
                    TransactionTypeId = 1,
                    FileTypeId = 1,
                    FileName = "1",
                    OutputFileName = "1",
                    GroupName = "1",
                    Comments = "1",
                    ApprovedDate = "1",
                    IsActiveInTest = true,
                    IsActiveInProd = true,
                    NumberOfInputFiles = 1,
                    NumberOfHeaderRows = 1,
                    InputDateFormatID = 1,
                    InputDateFormat = "1",
                    IsUnicodeReplaceRequired = true,
                    EffectiveDate = "1",
                    CreatedBy = 1,
                    CreatedDate = "1",
                    ModifiedBy = 1,
                    ModifiedDate = "1",
                    Status = 1,
                    GUID = "1",
                    FieldSeparator = "1",
                    StatusValue = "1",
                    TransactionTypeValue = "1",
                    FileTypeValue = "1",
                    IgnoreRows = "1",
                    NumberOfColumns = 1,
                    SenderId = "1",
                    ReceiverId = "1",
                    Price = 1,
                    DetailedContentString = "1",
                    HeaderContentString = "1",
                    OutputXMLDataString = "1",
                    VendorName = "1",
                    HeaderNameText = "1",
                    DetailNameText = "1",
                    QuantityFormatId = 1,
                    QuantityFormatType = "1",
                    HeaderLineItem = "1",
                    DetailLineItem = "1",
                    HeaderDateFormat = "1",
                    DetailDateFormat = "1",
                    POHeaderFileFormat = "1",
                    PODetailFileFormat = "1",
                    RelativeDateFormats = "1",
                    FTPFolderName = "1",
                    XMLTypeId = 1,
                    SenderIdQualifier = "1",
                    ReceiverIdQualifier = "1",
                    SubElementSeparator = "1",
                    SenderCode = "1",
                    ReceiverCode = "1",
                    Version = "1",
                    SegmentSeparator = "1",
                    PONumberLength = 1,
                    IsPONumberFromRight = true,
                    Preceder = "1",
                });

            var details = new DashBoard()
                {
                    Inprogress = 1234,
                    Rejected = 123,
                    Passed = 1,
                    transactionGridData = grid
                };

             var detailsDB = new TransactionGridData()
            {
                Id = 1234,
                TransactionName = "1",
                Approved = "1",
                Modified = "1",
                FileName = "1",
                Status = 1,
                StatusValue = "1"
            };
        }

        [TestMethod]
        public void TestErrorTransactionDetail()
        {
            var details = new ErrorTransactionDetail()
            {
                transactionId = 1234,
                AuditId = 123,
                Message = "1",
                errorDescription = "1",
                source = "1",
                createdBy = 1
            };
        }

        [TestMethod]
        public void TestExportMap()
        {
            List<ExportMapDetails> grid = new List<ExportMapDetails>();
            grid.Add(new ExportMapDetails
            {
                Width = "1",
                StartPosition = "1",
                FieldName = "1",
                Position = "1",
                DefaultValue = "1",
                IsEnclosedwith = "1",
                FieldID = "1",
                SegmentName = "1",
                XMLSegmentName = "1"

            });
            var details = new ExportMap()
            {
                VendorId = 1234,
                VendorName = "1",
                TransactionName = "1",
                TransactionType = "1",
                InputDateformat = "1",
                InputFileType = "1",
                NoofHeaderRows = "1",
                RowsToIgnore = "1",
                SenderID = "1",
                ReceiverID = "1",
                CreatedDate = "1",
                ExportMapDetailsCount = grid

            };
        }

        [TestMethod]
        public void TestFileContents()
        {
            var details = new FileContent()
            {
                TransactionId = 1234,
                NoOfFiles = 123,
                TypeOfFile = "1",
                FieldSeparator = "1",
                HeaderFileName = "1",
                DetailFileName = "1"
            };
        }

        [TestMethod]
        public void TestFileEngineAuditInfo()
        {
            var details = new FileEngineAuditInfo()
            {
                AuditId = 1234,
                TransactionId = 123,
                TransactionType = "1",
                TransactionTypeId = 1,
                InputFileName = "1",
                HeaderFileName = "1",
                FileType = "1",
                IsProd = true,
                ProcessType = "1",
                Status = "1",
                Description = "1",
                VendorId = 123,
                VendorName = "1",
                GroupId = 123,
                CreatedDate = "1",
                TransactionName = "1",
                LastSuccessDate = "1",
                LastFailedDate = "1",
                StatusCode = "1"
            };
        }

        [TestMethod]
        public void TestMap()
        {
            var details = new Map()
            {
                Position = 1234,
                PositionValue = 123,
                StartPosition = 1234,
                Width = 123,
                EnclosedMapcharId = 123,
                DefaultValue = "1",
                IsRightAligned = true
            };
        }

        [TestMethod]
        public void TestTransactionMapDetails()
        {
            var details = new TransactionMapDetails()
            {
                TransactionMapDetailId = 1234,
                TransactionId = 123,
                Position = 1234,
                FieldId = 123,
                DefaultValue = "1",
                StartPosition = 123,
                Width = 1234,
                MAPCharId = 123,
                MAPCharValue = "1",
                CreatedBy = 123,
                CreatedDate = "1",
                ModifiedBy = 123,
                ModifiedDate = "1",
                FieldType = "1"
            };
        }

        [TestMethod]
        public void TestVendor()
        {
            var details = new MP.Online.Api.Models.Vendor.Vendor()
            {
                vendorId = 123,
                vendorNumber = 123,
                vendorName = "1",
                companyName = "1",
                primaryContactName = "1",
                secondaryContactName = "1",
                primaryOfficePhone = "1",
                secondaryOfficePhone = "1",
                primaryContactEmailAddress = "1",
                secondaryContactEmailAddress = "1",
                supportContact = "1",
                emailAddress = "1",
                primaryTechnicalContact = "1",
                secondaryTechnicalContact = "1",
                primaryTechnicalEmailAddress = "1",
                secondaryTechnicalEmailAddress = "1",
                primaryTechnicalPhone = "1",
                secondaryTechnicalPhone = "1",
                groupId = 123,
                groupName = "1",
                isActive = true,
                status = 123,
                statusValue = "1",
                isUnicodeReplaceRequired = true,
                createdBy = 123,
                updatedBy = 123,
                POHeaderFileFormatId = 123,
                PODetailFileFormatId = 123
            };
        }

        [TestMethod]
        public void TestVendorDashboard()
        {
            var details = new VendorDashboard()
            {
                InProgress = 1234,
                Approved = 123,
                Rejected = 1234,

            };
        }

        [TestMethod]
        public void TestVendorFTPDetails()
        {
            var details = new VendorFTPDetails()
            {
                vendorId = 1234,
                CreatedBy = 123,
                Status = 1234,
                ModifiedBy = 1234,
                IpAddressOrPort = "1",
                UserName = "1",
                Password = "1",
                CHRAccessedFTPPath = "1",
                CommsComment = "1"
            };
        }
    }
}
