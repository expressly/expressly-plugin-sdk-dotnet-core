using Newtonsoft.Json;

namespace Expressly.Api
{
    public class InvoiceCustomerFilter : ExpresslySerializableObject
    {
        /// <summary>
        /// Email
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "email")]
        public string email { get; set; }


        /// <summary>
        /// Start time in UTC ISO8601 format.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "from")]
        public string from { get; set; }


        /// <summary>
        /// End time in UTC ISO8601 format.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "to")]
        public string to { get; set; }
    }
}
