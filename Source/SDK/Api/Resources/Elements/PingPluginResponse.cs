using Newtonsoft.Json;

namespace Expressly.Api
{
    public class PingPluginResponse : ExpresslySerializableObject
    {
        /// <summary>
        /// Plugin Response
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "expressly")]
        public string expressly { get; set; }
    }
}
