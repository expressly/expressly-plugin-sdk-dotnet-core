using NUnit.Framework;


namespace Expressly.Testing
{
    [TestFixture]
    public class BannerTest
    {
        [Test, Category("Unit")]
        public void BannerObjectTest()
        {
            var testObject = TestModels.GetBanner();
            Assert.AreEqual("https://i.ytimg.com/vi/yaqe1qesQ8c/maxresdefault.jpg", testObject.bannerImageUrl);
            Assert.AreEqual("http://test.shop.com/expressly/api/49cb75d5-b823-4f0e-bdac-c2fee4bad9b6", testObject.migrationLink);
        }


        [Test, Category("Unit")]
        public void BannerConvertToJsonTest()
        {
            Assert.IsFalse(TestModels.GetBanner().ConvertToJson().Length == 0);
        }

        [Test, Category("Unit")]
        public void BannerToStringTest()
        {
            Assert.IsFalse(TestModels.GetBanner().ToString().Length == 0);
        }
    }
}
