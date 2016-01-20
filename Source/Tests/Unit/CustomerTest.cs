using Microsoft.VisualStudio.TestTools.UnitTesting;
using Expressly.Api;

namespace Expressly.Testing
{
    [TestClass]
    public class CustomerTest : BaseTest
    {

        [TestMethod, TestCategory("Unit")]
        public void CustomerObjectTest()
        {
            var testObject = TestModels.GetCustomer();

            Assert.IsTrue(!string.IsNullOrEmpty(testObject.email));
            Assert.AreEqual(0, testObject.userReference);

        }


        [TestMethod, TestCategory("Unit")]
        public void CustomerCustomerConvertToJsonTest()
        {
            Assert.IsFalse(TestModels.GetCustomer().ConvertToJson().Length == 0);
        }


        [TestMethod, TestCategory("Unit")]
        public void CustomerToStringTest()
        {
            Assert.IsFalse(TestModels.GetCustomer().ToString().Length == 0);
        }
    }
}
