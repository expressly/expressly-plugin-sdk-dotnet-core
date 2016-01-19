using Newtonsoft.Json;

namespace Expressly.Api
{
    public class MerchantPing : ExpresslySerializableObject
    {
        /// <summary>
        /// Merchant Installed Data
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "installed")]
        public MerchantInstalledData installed { get; set; }


        /// <summary>
        /// Merchant Registered Data
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "registered")]
        public MerchantRegisteredData registered { get; set; }

    }


    public class MerchantInstalledData
    {
        /// <summary>
        /// Time of last ping in UTC ISO8601 format.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "timeOfLastPing")]
        public string timeOfLastPing { get; set; }


        /// <summary>
        /// A flag indicating is shop active and configured.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "success")]
        public bool success { get; set; }
    }


    public class MerchantRegisteredData
    {
        /// <summary>
        /// Time of last ping in UTC ISO8601 format.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "timeOfLastPing")]
        public string timeOfLastPing { get; set; }


        /// <summary>
        /// A flag indicating is shop active and configured.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "success")]
        public bool success { get; set; }
    }

}
