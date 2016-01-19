using Microsoft.VisualStudio.TestTools.UnitTesting;
using Expressly.Api;

namespace Expressly.Testing
{
    [TestClass]
    public class MigrationTest : BaseTest
    {
        [TestMethod, TestCategory("Unit")]
        public void MigrationObjectTest()
        {
            var testObject = TestModels.GetMigration();
            Assert.IsNotNull(testObject);
            Assert.IsNotNull(testObject.metada);
            Assert.IsNotNull(testObject.customer);
        }


        [TestMethod, TestCategory("Unit")]
        public void MigrationConvertToJsonTest()
        {
            Assert.IsFalse(TestModels.GetMigration().ConvertToJson().Length == 0);
        }


        [TestMethod, TestCategory("Unit")]
        public void MigrationToStringTest()
        {
            Assert.IsFalse(TestModels.GetMigration().ToString().Length == 0);
        }
    }
}
