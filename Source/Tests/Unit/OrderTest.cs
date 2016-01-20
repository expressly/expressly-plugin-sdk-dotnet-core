using NUnit.Framework;

namespace Expressly.Testing
{
    [TestFixture]
    public class OrderTest
    {
        [Test, Category("Unit")]
        public void OrderObjectTest()
        {
            var testObject = TestModels.GetOrder();
            Assert.AreEqual("ORDER-5321311", testObject.id);
            Assert.AreEqual("2015-07-10", testObject.date);
            Assert.AreEqual(2, testObject.itemCount);
            Assert.AreEqual("COUPON", testObject.coupon);
            Assert.AreEqual("GBP", testObject.currency);
            Assert.AreEqual(100.00, testObject.preTaxTotal);
            Assert.AreEqual(110.00, testObject.postTaxTotal);
            Assert.AreEqual(10.00, testObject.tax);
        }

        [Test, Category("Unit")]
        public void OrderConvertToJsonTest()
        {
            Assert.IsFalse(TestModels.GetOrder().ConvertToJson().Length == 0);
        }

        [Test, Category("Unit")]
        public void OrderToStringTest()
        {
            Assert.IsFalse(TestModels.GetOrder().ToString().Length == 0);
        }
    }
}
