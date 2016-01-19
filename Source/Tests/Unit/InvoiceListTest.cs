using System.Collections.Generic;
using Expressly.Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressly.Testing
{
    [TestClass]
    public class InvoiceListTest
    {
        public static InvoiceList GetInvoiceList()
        {
            List<Invoice> invoices = new List<Invoice> { TestModels.GetInvoice(), TestModels.GetInvoice() };
            InvoiceList invoicesList = new InvoiceList { invoices = invoices };

            return invoicesList;
        }

        [TestMethod, TestCategory("Unit")]
        public void InvoiceListObjectTest()
        {
            var list = GetInvoiceList();
            Assert.AreEqual(list.invoices.Count, 2);
        }

        [TestMethod, TestCategory("Unit")]
        public void InvoiceListConvertToJsonTest()
        {
            Assert.IsFalse(GetInvoiceList().ConvertToJson().Length == 0);
        }

        [TestMethod, TestCategory("Unit")]
        public void InvoiceListToStringTest()
        {
            Assert.IsFalse(GetInvoiceList().ToString().Length == 0);
        }
    }
}
