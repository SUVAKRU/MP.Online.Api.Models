using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MP.Online.Api.Models.MasterData;

namespace MP.Online.Api.Models.Tests.UnitTests
{
    [TestClass]
    public class MasterDataShould
    {
        [TestMethod]
        public void TestXMLTypes()
        {
            var details = new XMLTypes()
            {
                XMLTypeId = 1,
                XMLType = "pass",
                TransactionTypeId = 1,
                IsActive = true,
            };
        }

        [TestMethod]
        public void TestXMLFields()
        {
            var details = new XMLFields()
            {
                XMLFieldId = 1,
                XMLTypeId = 1,
                DisplayName = "pass",
                IsActive = true,
                IsParent = true,
                IsRepeates = true,
                SortOrder = 1,
                DisplayOrder = 1,
                FieldType = "pass",
                ParentId = 1
               };
        }

        [TestMethod]
        public void TestTransactionType()
        {
            var details = new TransactionType()
            {
                TransactionTypeID = 1,
                TransactionTypeName = "pass",
                IsActive = true,
            };
        }

        [TestMethod]
        public void TestRoleMaster()
        {
            var details = new RoleMaster()
            {
                RoleId = 1,
                RoleName = "pass",
                IsActive = true,
            };
        }

        [TestMethod]
        public void TestQuantityFormats()
        {
            var details = new QuantityFormats()
            {
                QuantityFormatId = 1,
                QuantityFormatType = "pass",
                IsActive = true,
                value = "value"
            };
        }

        [TestMethod]
        public void TestPOOutputFileFormats()
        {
            var details = new POOutputFileFormats()
            {
                POFileFormatID = 1,
                POFileFormatName = "pass",
                POFileFormatDescription = "pass",
                IsActive = true,
                FileType = "value"
            };
        }

        [TestMethod]
        public void TestMapFields()
        {
            var details = new MapFields()
            {
                FieldId = 1,
                FieldName = "pass",
                ParentId = 1,
                ParentNode = "pass",
                FieldType = "pass",
                TransactionType = 1,
                DispalyName = "pass",
                DataType = "pass",
                DisplayOrder = 1
            };
        }

        [TestMethod]
        public void TestGroupMaster()
        {
            var details = new GroupMaster()
            {
                GroupId = 1,
                GroupName = "pass",
                IsActive = true
            };
        }
    }
}
