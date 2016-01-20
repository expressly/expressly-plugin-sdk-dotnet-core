using Microsoft.VisualStudio.TestTools.UnitTesting;
using Expressly.Api;

namespace Expressly.Testing
{
    [TestClass]
    public class CustomerDataTest : BaseTest
    {
        [TestMethod, TestCategory("Unit")]
        public void CustomerDataObjectTest()
        {
            var testObject = TestModels.GetCustomerData();
            Assert.AreEqual("Test", testObject.firstName);
            Assert.AreEqual("LastTest", testObject.lastName);
            Assert.AreEqual("M", testObject.gender);
            Assert.AreEqual(0, testObject.billingAddress);
            Assert.AreEqual(0, testObject.shippingAddress);
            Assert.AreEqual("2015-12-10T18:24:42.000Z", testObject.dateUpdated);
            Assert.AreEqual(0, testObject.numberOrdered);
            Assert.IsTrue(testObject.emails.Count == 1);
            Assert.IsNotNull(testObject.emails);
            Assert.IsTrue(testObject.phones.Count == 1);
            Assert.IsNotNull(testObject.phones);
            Assert.IsTrue(testObject.addresses.Count == 1);
            Assert.IsNotNull(testObject.addresses);
        }

        [TestMethod, TestCategory("Unit")]
        public void CustomerDataConvertToJsonTest()
        {
            Assert.IsFalse(TestModels.GetCustomerData().ConvertToJson().Length == 0);
        }

        [TestMethod, TestCategory("Unit")]
        public void CustomerDataToStringTest()
        {
            Assert.IsFalse(TestModels.GetCustomerData().ToString().Length == 0);
        }
    }
}
