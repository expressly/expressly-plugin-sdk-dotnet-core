using Expressly.Api;
using NUnit.Framework;

namespace Expressly.Testing
{
    [TestFixture]
    public class APIContextTest
    {
        [Test, Category("Unit")]
        public void APIContextValidConstructorTest()
        {
            var apiContext = new APIContext();
            Assert.IsNull(apiContext.Config);
            Assert.IsNull(apiContext.HTTPHeaders);
        }

    }
}
