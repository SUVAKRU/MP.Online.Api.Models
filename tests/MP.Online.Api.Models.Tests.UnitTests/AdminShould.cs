using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MP.Online.Api.Models.Admin;

namespace MP.Online.Api.Models.Tests.UnitTests
{
    [TestClass]
    public class AdminShould
    {
        [TestMethod]
        public void TestLoginDetails()
        {
            var details = new LoginDetails()
            {
                UserName = "Name",
                Password = "pass",
                IsRemember = true
            };
        }

        [TestMethod]
        public void TestChangePasswordDto()
        {
            var details = new ChangePasswordDto()
            {
                UserName = "Name",
                OldPassword = "pass",
                NewPassword = "pass"
            };
        }


        [TestMethod]
        public void TestUserDetails()
        {
            var details = new UserDetails()
            {
                userId = 1,
                UserName = "name",
                Email = "Email",
                RoleName = "Email",
                RoleId = 1,
                VendorId = 1,
                Status = true,
                IsActive = true,
                CreatedBy = 1,
                UpdatedBy = 1,
            };
        }
    }
}
