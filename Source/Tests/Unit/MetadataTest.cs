using Microsoft.VisualStudio.TestTools.UnitTesting;
using Expressly.Api;

namespace Expressly.Testing
{
    [TestClass]
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

        [TestMethod, TestCategory("Unit")]
        public void MetadataObjectTest()
        {
            var testObject = GetMetadata();
            Assert.AreEqual("http://test.shop.com/", testObject.sender);
            Assert.AreEqual("GBR", testObject.locale);
            Assert.IsTrue(testObject.issuerData.Count == 0);
        }

        [TestMethod, TestCategory("Unit")]
        public void MetadataConvertToJsonTest()
        {
            Assert.IsFalse(GetMetadata().ConvertToJson().Length == 0);
        }

        [TestMethod, TestCategory("Unit")]
        public void MetadataToStringTest()
        {
            Assert.IsFalse(GetMetadata().ToString().Length == 0);
        }
    }
}
