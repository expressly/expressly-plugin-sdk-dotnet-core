using NUnit.Framework;

namespace Expressly.Testing
{
    [TestFixture]
    public class EmailTest
    {
        [Test, Category("Unit")]
        public void EmailObjectTest()
        {
            var testObject = TestModels.GetEmail();
            Assert.AreEqual("test@gmail.com", testObject.email);
            Assert.AreEqual("personal", testObject.alias);
        }

        [Test, Category("Unit")]
        public void EmailConvertToJsonTest()
        {
            Assert.IsFalse(TestModels.GetEmail().ConvertToJson().Length == 0);
        }

        [Test, Category("Unit")]
        public void EmailToStringTest()
        {
            Assert.IsFalse(TestModels.GetEmail().ToString().Length == 0);
        }
    }
}
