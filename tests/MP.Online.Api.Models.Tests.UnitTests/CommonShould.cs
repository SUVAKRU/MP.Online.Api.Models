using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MP.Online.Api.Models.Common;

namespace MP.Online.Api.Models.Tests.UnitTests
{
    [TestClass]
    public class CommonShould
    {
        [TestMethod]
        public void TestBaseResponse()
        {
            var details = new BaseResponse()
            {
                Message = "mess",
                IsSuccess = true
            };
        }
        [TestMethod]
        public void TestKeyValue()
        {
            var details = new KeyValue()
            {
                Key = "Key",
                Value = 1
            };
        }
    }
}
