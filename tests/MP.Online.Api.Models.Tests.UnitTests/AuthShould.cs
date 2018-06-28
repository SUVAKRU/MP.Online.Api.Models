using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MP.Online.Api.Models.Auth0;

namespace MP.Online.Api.Models.Tests.UnitTests
{
    [TestClass]
    public class AuthShould
    {
        [TestMethod]
        public void TestAuth0Model()
        {
            var details = new Auth0Model()
            {
                Connection = "conn",
                Domain = "pass",
                AccessToken = "pass",
            };
        }

        [TestMethod]
        public void TestUserModel()
        {
            var details = new UserModel()
            {
                UserName = "Name",
                Name = "pass",
                Password = "pass",
                Connection = "conn",
                Email = "email",
            };
        }
    }
}
