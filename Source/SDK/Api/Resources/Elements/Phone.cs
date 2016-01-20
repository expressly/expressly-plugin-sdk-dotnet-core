using Newtonsoft.Json;

namespace Expressly.Api
{
    public class Phone : ExpresslySerializableObject
    {
        /// <summary>
        /// Phone type
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type")]
        public string type { get; set; }


        /// <summary>
        /// Phone number
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "number")]
        public string number { get; set; }


        /// <summary>
        /// Country Code
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "countryCode")]
        public int countryCode { get; set; }
    }
}
