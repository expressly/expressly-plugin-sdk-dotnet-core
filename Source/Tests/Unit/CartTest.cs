using NUnit.Framework;

namespace Expressly.Testing
{
    [TestFixture]
    public class CartTest
    {
        [Test, Category("Unit")]
        public void CartObjectTest()
        {
            var testObject = TestModels.GetCart();
            Assert.AreEqual("4er23", testObject.couponCode);
            Assert.AreEqual("641356", testObject.productId);
        }

        [Test, Category("Unit")]
        public void CartConvertToJsonTest()
        {
            Assert.IsFalse(TestModels.GetCart().ConvertToJson().Length == 0);
        }

        [Test, Category("Unit")]
        public void CartToStringTest()
        {
            Assert.IsFalse(TestModels.GetCart().ToString().Length == 0);
        }
    }
}
