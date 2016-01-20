using Expressly.Util;
using Newtonsoft.Json;

namespace Expressly.Api
{
    public class Customer : ExpresslySerializableObject
    {
        /// <summary>
        /// Customer email
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "email")]
        public string email { get; set; }


        /// <summary>
        /// User Reference
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userReference")]
        public int userReference { get; set; }


        /// <summary>
        /// Customer email
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customerData")]
        public CustomerData customerData { get; set; }

    }
}
