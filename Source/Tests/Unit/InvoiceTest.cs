using Microsoft.VisualStudio.TestTools.UnitTesting;
using Expressly.Api;

namespace Expressly.Testing
{
    [TestClass]
    public class InvoiceTest : BaseTest
    {
        [TestMethod, TestCategory("Unit")]
        public void InvoiceObjectTest()
        {
            var testObject = TestModels.GetInvoice();
            Assert.AreEqual("testa@test.com", testObject.email);
            Assert.AreEqual(1, testObject.orderCount);
            Assert.AreEqual(100.00, testObject.preTaxTotal);
            Assert.AreEqual(110.00, testObject.postTaxTotal);
            Assert.AreEqual(10.00, testObject.tax);
            Assert.IsNotNull(testObject.orders);
            Assert.IsTrue(testObject.orders.Count == 1);

        }

        [TestMethod, TestCategory("Unit")]
        public void InvoiceConvertToJsonTest()
        {
            Assert.IsFalse(TestModels.GetInvoice().ConvertToJson().Length == 0);
        }

        [TestMethod, TestCategory("Unit")]
        public void InvoiceToStringTest()
        {
            Assert.IsFalse(TestModels.GetInvoice().ToString().Length == 0);
        }
    }
}
