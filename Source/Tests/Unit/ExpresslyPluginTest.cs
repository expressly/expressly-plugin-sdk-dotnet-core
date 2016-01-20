using Microsoft.VisualStudio.TestTools.UnitTesting;
using Expressly.Api;

namespace Expressly.Testing
{
    [TestClass]
    public class ExpresslyPluginTest : BaseTest
    {
        [TestMethod, TestCategory("Unit")]
        public void ExpresslyPluginConstructorTest()
        {
            Assert.IsNotNull(ExpresslyPlugin.ApiKey);
            Assert.IsNotNull(ExpresslyPlugin.ApiBaseUrl);
            Assert.IsNotNull(ExpresslyPlugin.APIContext);
            Assert.IsNotNull(ExpresslyPlugin.APIContext.Config);
        }



        [TestMethod, TestCategory("Functional")]
        public void ExpresslyPluginInstallTest()
        {
            try
            {
                var apiContext = TestingUtil.GetApiContext();
                this.RecordConnectionDetails();

                var isInstall = ExpresslyPlugin.Install();
                this.RecordConnectionDetails();

                Assert.IsTrue(isInstall);

            }
            catch (ConnectionException)
            {
                this.RecordConnectionDetails(false);
                throw;
            }
        }
    }
}
