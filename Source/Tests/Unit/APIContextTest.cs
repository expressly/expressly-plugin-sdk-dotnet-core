using Microsoft.VisualStudio.TestTools.UnitTesting;
using Expressly.Api;

namespace Expressly.Testing
{
    [TestClass]
    public class APIContextTest
    {
        [TestMethod, TestCategory("Unit")]
        public void APIContextValidConstructorTest()
        {
            var apiContext = new APIContext();
            Assert.IsNull(apiContext.Config);
            Assert.IsNull(apiContext.HTTPHeaders);
        }

    }
}
