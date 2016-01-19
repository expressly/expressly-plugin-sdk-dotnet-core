using Microsoft.VisualStudio.TestTools.UnitTesting;
using Expressly.Api;

namespace Expressly.Testing
{
    [TestClass]
    public class CartTest
    {
        [TestMethod, TestCategory("Unit")]
        public void CartObjectTest()
        {
            var testObject = TestModels.GetCart();
            Assert.AreEqual("4er23", testObject.couponCode);
            Assert.AreEqual("641356", testObject.productId);
        }

        [TestMethod, TestCategory("Unit")]
        public void CartConvertToJsonTest()
        {
            Assert.IsFalse(TestModels.GetCart().ConvertToJson().Length == 0);
        }

        [TestMethod, TestCategory("Unit")]
        public void CartToStringTest()
        {
            Assert.IsFalse(TestModels.GetCart().ToString().Length == 0);
        }
    }
}
