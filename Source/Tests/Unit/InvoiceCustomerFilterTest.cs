using Expressly.Api;
using NUnit.Framework;

namespace Expressly.Testing
{
    [TestFixture]
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


        [Test, Category("Unit")]
        public void InvoiceCustomerFilterObjectTest()
        {
            var testObject = GetInvoiceCustomerFilter();
            Assert.AreEqual("testa@test.com", testObject.email);
            Assert.AreEqual("2015-12-01", testObject.from);
            Assert.AreEqual("2015-12-31", testObject.to);
        }


        [Test, Category("Unit")]
        public void InvoiceCustomerFilterConvertToJsonTest()
        {
            Assert.IsFalse(GetInvoiceCustomerFilter().ConvertToJson().Length == 0);
        }


        [Test, Category("Unit")]
        public void InvoiceCustomerFilterToStringTest()
        {
            Assert.IsFalse(GetInvoiceCustomerFilter().ToString().Length == 0);
        }
    }
}
