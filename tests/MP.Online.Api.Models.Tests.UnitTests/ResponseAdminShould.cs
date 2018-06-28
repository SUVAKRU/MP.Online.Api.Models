using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MP.Online.Api.Models.Responses;
using MP.Online.Api.Models.Responses.Admin;
using ServiceStack;

namespace MP.Online.Api.Models.Tests.UnitTests
{
    [TestClass]
    public class ResponseAdminShould
    {
        [TestMethod]
        public void TestChangePasswordResponses()
        {
            var details = new ChangePasswordResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() {ErrorCode = "dfads"}
            };
        }

        [TestMethod]
        public void TestCreateUserResponse()
        {
            var details = new CreateUserResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() { ErrorCode = "dfads" }
            };
        }

        [TestMethod]
        public void TestForgotPasswordResponse()
        {
            var details = new ForgotPasswordResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() { ErrorCode = "dfads" }
            };
        }


        [TestMethod]
        public void TestGetRolesResponse()
        {
            var details = new GetRolesResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() { ErrorCode = "dfads" }
            };
        }

        [TestMethod]
        public void TestGetUsersResponse()
        {
            var details = new GetUsersResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() { ErrorCode = "dfads" }
            };
        }

        [TestMethod]
        public void TestLoginResponse()
        {
            var details = new LoginResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() { ErrorCode = "dfads" }
            };
        }

        [TestMethod]
        public void TestUpdateUserResponse()
        {
            var details = new UpdateUserResponse()
            {
                Message = "Message",
                ResponseStatus = new ResponseStatus() { ErrorCode = "dfads" }
            };
        }
    }
}
