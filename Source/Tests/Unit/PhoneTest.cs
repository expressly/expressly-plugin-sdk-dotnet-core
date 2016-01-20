using NUnit.Framework;

namespace Expressly.Testing
{
    [TestFixture]
    public class PhoneTest
    {
        [Test, Category("Unit")]
        public void PhoneObjectTest()
        {
            var testObject = TestModels.GetPhone();
            Assert.AreEqual("L", testObject.type);
            Assert.AreEqual("02079460975", testObject.number);
            Assert.AreEqual(44, testObject.countryCode);
        }

        [Test, Category("Unit")]
        public void PhoneConvertToJsonTest()
        {
            Assert.IsFalse(TestModels.GetPhone().ConvertToJson().Length == 0);
        }

        [Test, Category("Unit")]
        public void PhoneToStringTest()
        {
            Assert.IsFalse(TestModels.GetPhone().ToString().Length == 0);
        }
    }
}
