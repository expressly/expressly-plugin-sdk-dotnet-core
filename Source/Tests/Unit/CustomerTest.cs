using NUnit.Framework;

namespace Expressly.Testing
{
    [TestFixture]
    public class CustomerTest : BaseTest
    {

        [Test, Category("Unit")]
        public void CustomerObjectTest()
        {
            var testObject = TestModels.GetCustomer();

            Assert.IsTrue(!string.IsNullOrEmpty(testObject.email));
            Assert.AreEqual(0, testObject.userReference);

        }


        [Test, Category("Unit")]
        public void CustomerCustomerConvertToJsonTest()
        {
            Assert.IsFalse(TestModels.GetCustomer().ConvertToJson().Length == 0);
        }


        [Test, Category("Unit")]
        public void CustomerToStringTest()
        {
            Assert.IsFalse(TestModels.GetCustomer().ToString().Length == 0);
        }
    }
}
