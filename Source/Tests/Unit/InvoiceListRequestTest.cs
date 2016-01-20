using System.Collections.Generic;
using Expressly.Api;
using NUnit.Framework;

namespace Expressly.Testing
{
    [TestFixture]
    public class InvoiceListRequestTest
    {
        public static InvoiceListRequest GetInvoiceListRequest()
        {
            List<InvoiceCustomerFilter> filters = new List<InvoiceCustomerFilter> { InvoiceCustomerFilterTest.GetInvoiceCustomerFilter() };
            InvoiceListRequest invoiceListRequest = new InvoiceListRequest { customers = filters };

            return invoiceListRequest;
        }

        [Test, Category("Unit")]
        public void InvoiceListRequestObjectTest()
        {
            var list = GetInvoiceListRequest();
            Assert.AreEqual(list.customers.Count, 1);
        }

        [Test, Category("Unit")]
        public void InvoiceListRequestConvertToJsonTest()
        {
            Assert.IsFalse(GetInvoiceListRequest().ConvertToJson().Length == 0);
        }

        [Test, Category("Unit")]
        public void InvoiceListRequestToStringTest()
        {
            Assert.IsFalse(GetInvoiceListRequest().ToString().Length == 0);
        }
    }
}
