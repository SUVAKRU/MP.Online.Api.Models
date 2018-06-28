using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MP.Online.Api.Models.FileEngine;
using MP.Online.Api.Models.FileEngine.Invoice;
using MP.Online.Api.Models.FileEngine.PO;

namespace MP.Online.Api.Models.Tests.UnitTests
{
    [TestClass]
    public class FileEngineSHould
    {
        string poFile;
        string invfile;

        [TestInitialize]
        public void Init()
        {

            poFile = "TestFiles\\InvTest.xml";
            invfile = "TestFiles\\POTest.xml";
        }
        [TestMethod]
        public void TestPOFileConfiguration()
        {
            var details = new POFileConfiguration()
            {
                FieldSeparator = 1,
                IsEnclosedWithQuotes = true,
                NumberOfColumns =1,
            };
        }


        [TestMethod]
        public void TestSendInvoiceToMPRequest()
        {
            var details = new InvoiceHeader()
            {
                
            };
        }
    }

    [TestClass]
    public class InvoiceShould
    {
        // IServiceClient client;
        List<InvoiceHeader> PoList;
  
        [TestMethod]
        public void testSendInvoiceToMPRequest()
        {

            PoList = new List<InvoiceHeader>();

            List<VendorReference> VendorList = new List<VendorReference>();
            VendorList.Add(new VendorReference { ReferenceName = "vname", ReferenceValue = "vValue", });

            List<ConceptReference> ConList = new List<ConceptReference>();
            ConList.Add(new ConceptReference { ReferenceName = "cname", ReferenceValue = "cValue", });

            List<AccountReference> AccList = new List<AccountReference>();
            AccList.Add(new AccountReference { ReferenceName = "Aname", ReferenceValue = "AValue", });

            List<Reference> HeadList = new List<Reference>();
            HeadList.Add(new Reference { ReferenceName = "Hname", ReferenceValue = "HValue", });

            List<InvoiceDetail> InvoiceDetailslist = new List<InvoiceDetail>();
            InvoiceDetailslist.Add(new InvoiceDetail() { InvoiceLineNumber = "InvoiceLineNumberNO", ItemNumber = "ItemNumber", Unit = "UNIT", Description = "Description", Quantity = "0",  Weight = "0",  Price = "0", ExtendedPrice = "0", ExtendedTax = "0", });


            PoList.Add(new InvoiceHeader()
            {
                InvoiceNumber = "InvoiceNumber",
                PurchaseOrderNumber = "PurchaseOrderNumber",
                OrderDate = new System.DateTime(2017 - 08 - 15),
                OriginalInvoiceNumber = "OriginalInvoiceNumber",
                DeliveryDate = new System.DateTime(2017 - 08 - 15),
                RequestedDeliveryDate = new System.DateTime(2017 - 08 - 15),
                ShipDate = new System.DateTime(2017 - 08 - 15),
                RequestedShipDate = new System.DateTime(2017 - 08 - 15),
                ConfirmedShipDate = new System.DateTime(2017 - 08 - 15),
                ConfirmedArrivalDate = new System.DateTime(2017 - 08 - 15),
                TotalQuantity = 0,
                TotalTax = 0,
                Amount = 0,
                Currency = "Currency",
                TermsId = 0,
                FreightStatusId = 0,
                OrderStatusId = 0,
                ProductTypeId = 0,
                PurchaseOrderHeaderId = 0,
                Action = "Action",
            });
        }

    }

    [TestClass]
    public  class POshould
    {
        SendPurchaseOrderToEDI PoList = new SendPurchaseOrderToEDI();
        [TestMethod]
        public void testSendPOToMPRequest()
        {
            
            List<VendorReference> VendorList = new List<VendorReference>();
            VendorList.Add(new VendorReference { ReferenceName = "vname", ReferenceValue = "vValue", });

            List<ConceptReference> ConList = new List<ConceptReference>();
            ConList.Add(new ConceptReference { ReferenceName = "cname", ReferenceValue = "cValue", });

            List<AccountReference> AccList = new List<AccountReference>();
            AccList.Add(new AccountReference { ReferenceName = "Aname", ReferenceValue = "AValue", });

            List<Reference> HeadList = new List<Reference>();
            HeadList.Add(new Reference { ReferenceName = "Hname", ReferenceValue = "HValue", });

            List<DetailReference> DetailList = new List<DetailReference>();
            DetailList.Add(new DetailReference { ReferenceName = "Dname", ReferenceValue = "DValue", });


            List<PurchaseOrderDetail> PODetailList = new List<PurchaseOrderDetail>();
            PODetailList.Add(new PurchaseOrderDetail() { PurchaseOrderLineNumber = "0", ItemNumber = "1", Unit = "1", PackSize = "0", Description = "0", OGtin = "0", ConceptItemNumber = "0", ConceptDescription = "0", ConceptUnit = "0", Quantity = "0", Price = "0", ExtendedPrice = "0", ExtendedTax = "0", ConversionFactor = "0", Catch = "0", LotNumber = "0", SubbedItem = "0", Weight = "0", LineNote = "0",  });


            new SendPurchaseOrderToEDI()
            {
                PurchaseOrderNumber = "2017-08-15T00:00:00",
                CreatedDate = "2017-08-15T00:00:00",
                OrderDate = "2017-08-15T00:00:00",
                RequestedDeliveryDate = "2017-08-15T00:00:00",
                RequestedShipDate = "2017-08-15T00:00:00",
                ActualDeliveryDate = "2017-08-15T00:00:00",
                ActualShipDate = "2017-08-15T00:00:00",
                TotalQuantity = "0",
                TotalTax = "0",
                Amount = "0",
                Currency = "USD",
                TermsId = "0",
                FreightStatusId = "0",
                OrderStatusId = "0",
                ProductTypeId = "0",
                PurchaseOrderHeaderId = "0",
                Action = "string",
                LineCount = "0",
                ExternalNote = "ExternalNote",

            };
        }
    }
}
