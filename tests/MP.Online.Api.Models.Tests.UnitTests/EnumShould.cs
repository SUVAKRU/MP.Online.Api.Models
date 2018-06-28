using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MP.Online.Api.Models.Tests.UnitTests
{
    [TestClass]
    public class EnumShould
    {
        [TestMethod]
        public void TestEnumsFileStatusCode()
        {
            Assert.AreEqual(MP.Online.Api.Models.Enums.Enums.FileStatusCode(1), "InProgress");
            Assert.AreEqual(MP.Online.Api.Models.Enums.Enums.FileStatusCode(2), "Passed");
            Assert.AreEqual(MP.Online.Api.Models.Enums.Enums.FileStatusCode(3), "Rejected");
            Assert.AreEqual(MP.Online.Api.Models.Enums.Enums.FileStatusCode(4), "");

        }
        [TestMethod]
        public void TestEnumsVendorStatusValue()
        {
            Assert.AreEqual(MP.Online.Api.Models.Enums.Enums.VendorStatusValue(1), "Inprogress");
            Assert.AreEqual(MP.Online.Api.Models.Enums.Enums.VendorStatusValue(2), "CommsApproved");
            Assert.AreEqual(MP.Online.Api.Models.Enums.Enums.VendorStatusValue(3), "CommsRejected");
            Assert.AreEqual(MP.Online.Api.Models.Enums.Enums.VendorStatusValue(4), "Approved");
            Assert.AreEqual(MP.Online.Api.Models.Enums.Enums.VendorStatusValue(5), "Rejected");
            Assert.AreEqual(MP.Online.Api.Models.Enums.Enums.VendorStatusValue(6), "");

        }
        [TestMethod]
        public void TestEnumsTransactionTypes()
        {
            Assert.AreEqual(MP.Online.Api.Models.Enums.Enums.TransactionTypes(1), "Invoice");
            Assert.AreEqual(MP.Online.Api.Models.Enums.Enums.TransactionTypes(2), "PO");
            Assert.AreEqual(MP.Online.Api.Models.Enums.Enums.TransactionTypes(4), "");
        }
    }
}
