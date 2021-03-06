﻿using System;
using System.Collections.Generic;
using System.Configuration;

namespace Expressly.Api
{
    /// <summary>
    /// ConfigManager loads the configuration file and hands out appropriate parameters to application
    /// </summary>
    public sealed class ConfigManager
    {
        /// <summary>
        /// The configValue is readonly as it should not be changed outside constructor (but the content can)
        /// </summary>
        private readonly Dictionary<string, string> configValues;

        private static readonly Dictionary<string, string> defaultConfig;

        /// <summary>
        /// Explicit static constructor to tell C# compiler not to mark type as beforefieldinit
        /// </summary>
        static ConfigManager()
        {
            defaultConfig = new Dictionary<string, string>();
            // Default connection timeout in milliseconds
            defaultConfig[BaseConstants.HttpConnectionTimeoutConfig] = "30000";
            defaultConfig[BaseConstants.HttpConnectionRetryConfig] = "3";
            defaultConfig[BaseConstants.ApplicationModeConfig] = BaseConstants.SandboxMode;
        }

        /// <summary>
        /// Singleton instance of the ConfigManager
        /// </summary>
        private static volatile ConfigManager singletonInstance;

        private static object syncRoot = new Object();


        /// <summary>
        /// Gets the Singleton instance of the ConfigManager
        /// </summary>
        public static ConfigManager Instance
        {
            get
            {
                if (singletonInstance == null)
                {
                    lock (syncRoot)
                    {
                        if (singletonInstance == null)
                            singletonInstance = new ConfigManager();
                    }
                }
                return singletonInstance;
            }
        }

        /// <summary>
        /// Private constructor
        /// </summary>
        private ConfigManager()
        {
            object expresslyConfigSection = null;

            try
            {
                expresslyConfigSection = ConfigurationManager.GetSection("expressly");
            }
            catch (System.Exception ex)
            {
                throw new ConfigException("Unable to load 'expressly' section from *.config: " + ex.Message);
            }

            if (expresslyConfigSection == null)
            {
                throw new ConfigException(
                    "Cannot parse *.Config file. Ensure you have configured the 'expressly' section correctly.");
            }

            NameValueConfigurationCollection settings = (NameValueConfigurationCollection)expresslyConfigSection.GetType().GetProperty("Settings").GetValue(expresslyConfigSection, null);
            this.configValues = new Dictionary<string, string>();
            foreach (NameValueConfigurationElement setting in settings)
            {
                configValues.Add(setting.Name, setting.Value);
            }
        }

        /// <summary>
        /// Returns all properties from the config file
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, string> GetProperties()
        {
            // returns a copy of the configuration properties
            return new Dictionary<string, string>(this.configValues);
        }

        /// <summary>
        /// Creates new configuration that combines incoming configuration dictionary
        /// and defaults
        /// </summary>
        /// <returns>Default configuration dictionary</returns>
        public static Dictionary<string, string> GetConfigWithDefaults(Dictionary<string, string> config)
        {
            Dictionary<string, string> ret = null;
            if (config == null)
            {
                ret = new Dictionary<string, string>();
            }
            else
            {
                ret = new Dictionary<string, string>(config);
            }

            foreach (string key in ConfigManager.defaultConfig.Keys)
            {
                if (!ret.ContainsKey(key))
                {
                    ret.Add(key, ConfigManager.defaultConfig[key]);
                }
            }
            return ret;
        }

        /// <summary>
        /// Gets the default configuration value for the specified key.
        /// </summary>
        /// <param name="configKey">The key to lookup in the default configuration.</param>
        /// <returns>A string containing the default configuration value for the specified key. If the key is not found, returns null.</returns>
        public static string GetDefault(string configKey)
        {
            if (ConfigManager.defaultConfig.ContainsKey(configKey))
            {
                return ConfigManager.defaultConfig[configKey];
            }
            return null;
        }

        /// <summary>
        /// Returns whether or not live mode is enabled in the given configuration.
        /// </summary>
        /// <param name="config">Configuration to use</param>
        /// <returns>True if live mode is enabled; false otherwise.</returns>
        public static bool IsLiveModeEnabled(Dictionary<string, string> config)
        {
            return config != null &&
                config.ContainsKey(BaseConstants.ApplicationModeConfig) &&
                config[BaseConstants.ApplicationModeConfig] == BaseConstants.LiveMode;
        }

    }
}
