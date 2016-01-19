using Microsoft.VisualStudio.TestTools.UnitTesting;
using Expressly.Api;

namespace Expressly.Testing
{
    [TestClass]
    public class EmailTest
    {
        [TestMethod, TestCategory("Unit")]
        public void EmailObjectTest()
        {
            var testObject = TestModels.GetEmail();
            Assert.AreEqual("test@gmail.com", testObject.email);
            Assert.AreEqual("personal", testObject.alias);
        }

        [TestMethod, TestCategory("Unit")]
        public void EmailConvertToJsonTest()
        {
            Assert.IsFalse(TestModels.GetEmail().ConvertToJson().Length == 0);
        }

        [TestMethod, TestCategory("Unit")]
        public void EmailToStringTest()
        {
            Assert.IsFalse(TestModels.GetEmail().ToString().Length == 0);
        }
    }
}
