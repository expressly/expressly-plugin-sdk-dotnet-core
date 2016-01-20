using Microsoft.VisualStudio.TestTools.UnitTesting;
using Expressly.Api;

namespace Expressly.Testing
{
    [TestClass]
    public class AddressTest
    {
        
        [TestMethod, TestCategory("Unit")]
        public void AddressObjectTest()
        {
            var testObject = TestModels.GetAddress();
            Assert.AreEqual("Test", testObject.firstName);
            Assert.AreEqual("Burberry", testObject.lastName);
            Assert.AreEqual("Basement Flat", testObject.address1);
            Assert.AreEqual("61 Wellfield Road", testObject.address2);
            Assert.AreEqual("Roath", testObject.city);
            Assert.AreEqual("company", testObject.companyName);
            Assert.AreEqual("CF24 3DG", testObject.zip);
            Assert.AreEqual(0, testObject.phone);
            Assert.AreEqual("home", testObject.addressAlias);
            Assert.AreEqual("Cardiff", testObject.stateProvince);
            Assert.AreEqual("GB", testObject.country);
        }

        [TestMethod, TestCategory("Unit")]
        public void AddressConvertToJsonTest()
        {
            Assert.IsFalse(TestModels.GetAddress().ConvertToJson().Length == 0);
        }

        [TestMethod, TestCategory("Unit")]
        public void AddressToStringTest()
        {
            Assert.IsFalse(TestModels.GetAddress().ToString().Length == 0);
        }
    }
}
