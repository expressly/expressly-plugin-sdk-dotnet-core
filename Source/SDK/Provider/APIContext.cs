using System.Collections.Generic;
using Expressly.Util;
using System;
using System.Text;
namespace Expressly.Api
{
    /// <summary>
    /// APIContext is used when making HTTP calls to the Expressly REST API.
    /// </summary>
    public class APIContext
    {
        /// <summary>
        /// Initializes a new instance of <seealso cref="APIContext"/> that is used when making HTTP calls to the Expressly REST API.
        /// </summary>
        public APIContext() { }


        /// <summary>
        /// Gets or sets the Expressly configuration settings to be used when making API requests.
        /// </summary>
        public Dictionary<string, string> Config { get; set; }


        /// <summary>
        /// Gets or sets the HTTP headers to include when making HTTP requests to the API.
        /// </summary>
        public Dictionary<string, string> HTTPHeaders { get; set; }


        /// <summary>
        /// Gets the stored configuration and merges it with the application's default config.
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, string> GetConfigWithDefaults()
        {
            return ConfigManager.GetConfigWithDefaults(this.Config == null ? ConfigManager.Instance.GetProperties() : this.Config);
        }

        /// <summary>
        /// Get MerchantUuid
        /// </summary>
        /// <returns>merchantUuid</returns>
        public string GetMerchantUuid()
        {
            // Decode apikey
            byte[] data = Convert.FromBase64String(Config["apiKey"]);
            string decodedString = Encoding.UTF8.GetString(data);

            return decodedString.Split(new string[] { ":" }, StringSplitOptions.None)[0];
        }

        /// <summary>
        /// Get Api Key
        /// </summary>
        /// <returns>apiKey</returns>
        public string GetApiKey()
        {
            return Config["apiKey"];
        }

    }
}
