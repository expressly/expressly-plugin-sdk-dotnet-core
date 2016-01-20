using Microsoft.VisualStudio.TestTools.UnitTesting;
using Expressly.Api;

namespace Expressly.Testing
{
    [TestClass]
    public class InvoiceCustomerFilterTest
    {
        public static readonly string InvoiceCustomerFilterJson =
            "{\"email\":\"testa@test.com\"," +
            "\"from\":\"2015-12-01\"," +
            "\"to\":\"2015-12-31\"" + "}";


        public static InvoiceCustomerFilter GetInvoiceCustomerFilter()
        {
            return JsonFormatter.ConvertFromJson<InvoiceCustomerFilter>(InvoiceCustomerFilterJson);
        }


        [TestMethod, TestCategory("Unit")]
        public void InvoiceCustomerFilterObjectTest()
        {
            var testObject = GetInvoiceCustomerFilter();
            Assert.AreEqual("testa@test.com", testObject.email);
            Assert.AreEqual("2015-12-01", testObject.from);
            Assert.AreEqual("2015-12-31", testObject.to);
        }


        [TestMethod, TestCategory("Unit")]
        public void InvoiceCustomerFilterConvertToJsonTest()
        {
            Assert.IsFalse(GetInvoiceCustomerFilter().ConvertToJson().Length == 0);
        }


        [TestMethod, TestCategory("Unit")]
        public void InvoiceCustomerFilterToStringTest()
        {
            Assert.IsFalse(GetInvoiceCustomerFilter().ToString().Length == 0);
        }
    }
}
