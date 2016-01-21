using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Collections.Generic;

namespace Expressly.Log
{
    /// <summary>
    /// Configuration for ExpresslyCoreSDK
    /// </summary>
    public static class LogConfiguration
    {
        /// <summary>
        /// Key for the loggers to be set in <appSettings><add key="ExpresslyLogger" value="Expressly.Log.DiagnosticsLogger, Expressly.Log.Log4netLogger"/></appSettings> in configuration file
        /// </summary>
        public const string ExpresslyLogKey = "ExpresslyLogger";

        /// <summary>
        /// AppSettings configuration key that defines the delimiter to be used when specifying the list of loggers.
        /// </summary>
        public const string ExpresslyLogDelimiterKey = "ExpresslyLogger.Delimiter";

        /// <summary>
        /// Default delimiter to use for the <see cref="ExpresslyLogDelimiterKey"/> value.
        /// </summary>
        public const string ExpresslyLogDefaultDelimiter = ",";

        private static List<string> configurationLoggerList = GetConfigurationLoggerList();

        /// <summary>
        /// Gets the list of loggers from the config.
        /// </summary>
        public static List<string> LoggerListInConfiguration
        {
            get
            {
                return configurationLoggerList;
            }
        }

        private static List<string> GetConfigurationLoggerList()
        {
            List<string> loggerList = new List<string>();

            var value = GetConfiguration(ExpresslyLogKey);
            var delimiter = GetConfiguration(ExpresslyLogDelimiterKey);

            if (string.IsNullOrEmpty(value))
            {
                return null;
            }

            if (string.IsNullOrEmpty(delimiter))
            {
                delimiter = ExpresslyLogDefaultDelimiter; // Default is a comma-separated list.
            }

            var splitList = new List<string>(value.Split(new string[] { delimiter }, StringSplitOptions.RemoveEmptyEntries));

            if (splitList == null || splitList.Count == 0)
            {
                return null;
            }

            foreach (string split in splitList)
            {
                if (!loggerList.Contains(split.Trim()))
                {
                    loggerList.Add(split.Trim());
                }
            }

            return loggerList;
        }

        private static string GetConfiguration(string name)
        {
            NameValueCollection appSetting = ConfigurationManager.AppSettings;

            if (appSetting == null)
            {
                return null;
            }

            string value = appSetting[name];
            return value;
        }

        private static bool GetConfigBool(string name)
        {
            string value = GetConfiguration(name);
            bool result;

            if (bool.TryParse(value, out result))
            {
                return result;
            }

            return default(bool);
        }
    }
}
