using System.Collections.Generic;
using Expressly.Api;
using NUnit.Framework;

namespace Expressly.Testing
{
    [TestFixture]
    public class InvoiceListTest
    {
        public static InvoiceList GetInvoiceList()
        {
            List<Invoice> invoices = new List<Invoice> { TestModels.GetInvoice(), TestModels.GetInvoice() };
            InvoiceList invoicesList = new InvoiceList { invoices = invoices };

            return invoicesList;
        }

        [Test, Category("Unit")]
        public void InvoiceListObjectTest()
        {
            var list = GetInvoiceList();
            Assert.AreEqual(list.invoices.Count, 2);
        }

        [Test, Category("Unit")]
        public void InvoiceListConvertToJsonTest()
        {
            Assert.IsFalse(GetInvoiceList().ConvertToJson().Length == 0);
        }

        [Test, Category("Unit")]
        public void InvoiceListToStringTest()
        {
            Assert.IsFalse(GetInvoiceList().ToString().Length == 0);
        }
    }
}
