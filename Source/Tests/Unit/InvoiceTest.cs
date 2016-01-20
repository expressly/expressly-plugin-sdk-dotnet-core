using NUnit.Framework;

namespace Expressly.Testing
{
    [TestFixture]
    public class InvoiceTest : BaseTest
    {
        [Test, Category("Unit")]
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

        [Test, Category("Unit")]
        public void InvoiceConvertToJsonTest()
        {
            Assert.IsFalse(TestModels.GetInvoice().ConvertToJson().Length == 0);
        }

        [Test, Category("Unit")]
        public void InvoiceToStringTest()
        {
            Assert.IsFalse(TestModels.GetInvoice().ToString().Length == 0);
        }
    }
}
