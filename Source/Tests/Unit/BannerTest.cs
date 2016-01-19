using Microsoft.VisualStudio.TestTools.UnitTesting;
using Expressly.Api;


namespace Expressly.Testing
{
    [TestClass]
    public class BannerTest
    {
        [TestMethod, TestCategory("Unit")]
        public void BannerObjectTest()
        {
            var testObject = TestModels.GetBanner();
            Assert.AreEqual("https://i.ytimg.com/vi/yaqe1qesQ8c/maxresdefault.jpg", testObject.bannerImageUrl);
            Assert.AreEqual("http://test.shop.com/expressly/api/49cb75d5-b823-4f0e-bdac-c2fee4bad9b6", testObject.migrationLink);
        }


        [TestMethod, TestCategory("Unit")]
        public void BannerConvertToJsonTest()
        {
            Assert.IsFalse(TestModels.GetBanner().ConvertToJson().Length == 0);
        }
        
        [TestMethod, TestCategory("Unit")]
        public void BannerToStringTest()
        {
            Assert.IsFalse(TestModels.GetBanner().ToString().Length == 0);
        }
    }
}
