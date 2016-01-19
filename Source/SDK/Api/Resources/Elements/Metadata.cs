using System.Collections.Generic;
using Newtonsoft.Json;

namespace Expressly.Api
{
    public class Metadata : ExpresslySerializableObject
    {
        /// <summary>
        /// Sender
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sender")]
        public string sender { get; set; }


        /// <summary>
        /// Locale
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "locale")]
        public string locale { get; set; }


        /// <summary>
        /// Issuer Data
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "issuerData")]
        public List<object> issuerData { get; set; }
    }
}
