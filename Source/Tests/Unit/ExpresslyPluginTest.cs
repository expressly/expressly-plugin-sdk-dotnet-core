using Expressly.Api;
using NUnit.Framework;

namespace Expressly.Testing
{
    [TestFixture]
    public class ExpresslyPluginTest : BaseTest
    {
        [Test, Category("Unit")]
        public void ExpresslyPluginConstructorTest()
        {
            Assert.IsNotNull(ExpresslyPlugin.ApiKey);
            Assert.IsNotNull(ExpresslyPlugin.ApiBaseUrl);
            Assert.IsNotNull(ExpresslyPlugin.APIContext);
            Assert.IsNotNull(ExpresslyPlugin.APIContext.Config);
        }



        [Test, Category("Unit")]
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
