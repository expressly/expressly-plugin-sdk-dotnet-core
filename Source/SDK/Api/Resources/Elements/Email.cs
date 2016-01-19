using Newtonsoft.Json;

namespace Expressly.Api
{
    public class Email : ExpresslySerializableObject
    {
        /// <summary>
        /// Customer email
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "email")]
        public string email { get; set; }


        /// <summary>
        /// Alias
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "alias")]
        public string alias { get; set; }
    }
}
