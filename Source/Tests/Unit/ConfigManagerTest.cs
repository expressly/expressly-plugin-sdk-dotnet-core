using System.Collections.Generic;
using Expressly.Api;
using NUnit.Framework;

namespace Expressly.Testing
{
    [TestFixture]
    public class ConfigManagerTest
    {
        [Test, Category("Unit")]
        public void LoadConfigDefaults()
        {
            var config = ConfigManager.GetConfigWithDefaults(null);
            Assert.IsNotNull(config);
            Assert.AreEqual("30000", config[BaseConstants.HttpConnectionTimeoutConfig]);
            Assert.AreEqual("3", config[BaseConstants.HttpConnectionRetryConfig]);
            Assert.AreEqual("sandbox", config[BaseConstants.ApplicationModeConfig]);
        }

        [Test, Category("Unit")]
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

        [Test, Category("Unit")]
        public void VerifyIsLiveModeEnabledWithDefaultConfig()
        {
            var config = ConfigManager.GetConfigWithDefaults(null);
            Assert.IsFalse(ConfigManager.IsLiveModeEnabled(config));
        }

        [Test, Category("Unit")]
        public void VerifyIsLiveModeEnabledWithSandboxModeSet()
        {
            var config = new Dictionary<string, string>
            {
                { BaseConstants.ApplicationModeConfig, BaseConstants.SandboxMode }
            };
            Assert.IsFalse(ConfigManager.IsLiveModeEnabled(config));
        }

        [Test, Category("Unit")]
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
