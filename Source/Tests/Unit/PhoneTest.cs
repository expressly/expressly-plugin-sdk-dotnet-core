using Microsoft.VisualStudio.TestTools.UnitTesting;
using Expressly.Api;

namespace Expressly.Testing
{
    [TestClass]
    public class PhoneTest
    {
        [TestMethod, TestCategory("Unit")]
        public void PhoneObjectTest()
        {
            var testObject = TestModels.GetPhone();
            Assert.AreEqual("L", testObject.type);
            Assert.AreEqual("02079460975", testObject.number);
            Assert.AreEqual(44, testObject.countryCode);
        }

        [TestMethod, TestCategory("Unit")]
        public void PhoneConvertToJsonTest()
        {
            Assert.IsFalse(TestModels.GetPhone().ConvertToJson().Length == 0);
        }

        [TestMethod, TestCategory("Unit")]
        public void PhoneToStringTest()
        {
            Assert.IsFalse(TestModels.GetPhone().ToString().Length == 0);
        }
    }
}
