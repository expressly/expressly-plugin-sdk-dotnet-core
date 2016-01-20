using Newtonsoft.Json;

namespace Expressly.Api
{
    public class RegisteredPluginResponse : ExpresslySerializableObject
    {
        /// <summary>
        /// Registered plugin response
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "registered")]
        public bool registered { get; set; }
    }
}
