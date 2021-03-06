// <copyright file="SendInvoiceToMPRequestTest.cs">Copyright ©  2017</copyright>
using System;
using MP.Online.Api.Models.FileEngine.Invoice;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MP.Online.Api.Models.FileEngine.Invoice.Tests
{
    /// <summary>This class contains parameterized unit tests for SendInvoiceToMPRequest</summary>
    [PexClass(typeof(SendInvoiceToMPRequest))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class SendInvoiceToMPRequestTest
    {
    }
}
