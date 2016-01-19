using System.Collections.Generic;
using Expressly.Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressly.Testing
{
    [TestClass]
    public class InvoiceListRequestTest
    {
        public static InvoiceListRequest GetInvoiceListRequest()
        {
            List<InvoiceCustomerFilter> filters = new List<InvoiceCustomerFilter> { InvoiceCustomerFilterTest.GetInvoiceCustomerFilter() };
            InvoiceListRequest invoiceListRequest = new InvoiceListRequest { customers = filters };

            return invoiceListRequest;
        }

        [TestMethod, TestCategory("Unit")]
        public void InvoiceListRequestObjectTest()
        {
            var list = GetInvoiceListRequest();
            Assert.AreEqual(list.customers.Count, 1);
        }

        [TestMethod, TestCategory("Unit")]
        public void InvoiceListRequestConvertToJsonTest()
        {
            Assert.IsFalse(GetInvoiceListRequest().ConvertToJson().Length == 0);
        }

        [TestMethod, TestCategory("Unit")]
        public void InvoiceListRequestToStringTest()
        {
            Assert.IsFalse(GetInvoiceListRequest().ToString().Length == 0);
        }
    }
}
