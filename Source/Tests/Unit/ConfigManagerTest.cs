using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Expressly.Api;
using Expressly;

namespace Expressly.Testing
{
    [TestClass]
    public class ConfigManagerTest
    {
        [TestMethod, TestCategory("Unit")]
        public void LoadConfigDefaults()
        {
            var config = ConfigManager.GetConfigWithDefaults(null);
            Assert.IsNotNull(config);
            Assert.AreEqual("30000", config[BaseConstants.HttpConnectionTimeoutConfig]);
            Assert.AreEqual("3", config[BaseConstants.HttpConnectionRetryConfig]);
            Assert.AreEqual("sandbox", config[BaseConstants.ApplicationModeConfig]);
        }

        [TestMethod, TestCategory("Unit")]
        public void LoadConfigFromAppConfig()
        {
            var config = ConfigManager.Instance.GetProperties();
            Assert.IsNotNull(config);
            Assert.AreEqual("sandbox", config[BaseConstants.ApplicationModeConfig]);
            Assert.AreEqual("360000", config[BaseConstants.HttpConnectionTimeoutConfig]);
            Assert.AreEqual("1", config[BaseConstants.HttpConnectionRetryConfig]);
            Assert.AreEqual("Y2Q4MDNlYTMtY2YwNi00OTk0LTkxMDItOGNjODMxNjkzNzlmOm55TzRnNnB3QlNhZFB3WjhTVmNzeXdkVUE5VlNXeUU2", config[BaseConstants.ApiKey]);
            Assert.AreEqual("http://test.shop.com", config[BaseConstants.ApiBaseUrl]);
        }

        [TestMethod, TestCategory("Unit")]
        public void VerifyIsLiveModeEnabledWithDefaultConfig()
        {
            var config = ConfigManager.GetConfigWithDefaults(null);
            Assert.IsFalse(ConfigManager.IsLiveModeEnabled(config));
        }

        [TestMethod, TestCategory("Unit")]
        public void VerifyIsLiveModeEnabledWithSandboxModeSet()
        {
            var config = new Dictionary<string, string>
            {
                { BaseConstants.ApplicationModeConfig, BaseConstants.SandboxMode }
            };
            Assert.IsFalse(ConfigManager.IsLiveModeEnabled(config));
        }

        [TestMethod, TestCategory("Unit")]
        public void VerifyIsLiveModeEnabledWithLiveModeSet()
        {
            var config = new Dictionary<string, string>
            {
                { BaseConstants.ApplicationModeConfig, BaseConstants.LiveMode }
            };
            Assert.IsTrue(ConfigManager.IsLiveModeEnabled(config));
        }
    }
}
