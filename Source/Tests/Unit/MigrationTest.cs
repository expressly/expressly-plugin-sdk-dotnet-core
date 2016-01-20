using NUnit.Framework;

namespace Expressly.Testing
{
    [TestFixture]
    public class MigrationTest : BaseTest
    {
        [Test, Category("Unit")]
        public void MigrationObjectTest()
        {
            var testObject = TestModels.GetMigration();
            Assert.IsNotNull(testObject);
            Assert.IsNotNull(testObject.metada);
            Assert.IsNotNull(testObject.customer);
        }


        [Test, Category("Unit")]
        public void MigrationConvertToJsonTest()
        {
            Assert.IsFalse(TestModels.GetMigration().ConvertToJson().Length == 0);
        }


        [Test, Category("Unit")]
        public void MigrationToStringTest()
        {
            Assert.IsFalse(TestModels.GetMigration().ToString().Length == 0);
        }
    }
}
