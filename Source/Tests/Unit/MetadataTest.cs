using Expressly.Api;
using NUnit.Framework;

namespace Expressly.Testing
{
    [TestFixture]
    public class MetadataTest
    {
        public static readonly string MetadataJson =
            "{\"sender\":\"http://test.shop.com/\"," +
            "\"locale\":\"GBR\"," +
            "\"issuerData\":[]}";


        public static Metadata GetMetadata()
        {
            return JsonFormatter.ConvertFromJson<Metadata>(MetadataJson);
        }

        [Test, Category("Unit")]
        public void MetadataObjectTest()
        {
            var testObject = GetMetadata();
            Assert.AreEqual("http://test.shop.com/", testObject.sender);
            Assert.AreEqual("GBR", testObject.locale);
            Assert.IsTrue(testObject.issuerData.Count == 0);
        }

        [Test, Category("Unit")]
        public void MetadataConvertToJsonTest()
        {
            Assert.IsFalse(GetMetadata().ConvertToJson().Length == 0);
        }

        [Test, Category("Unit")]
        public void MetadataToStringTest()
        {
            Assert.IsFalse(GetMetadata().ToString().Length == 0);
        }
    }
}
