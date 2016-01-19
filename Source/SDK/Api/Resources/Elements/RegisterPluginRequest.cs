using Newtonsoft.Json;

namespace Expressly.Api
{
    public class RegisterPluginRequest : ExpresslySerializableObject
    {
        /// <summary>
        /// Shop plugin url
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "apiBaseUrl")]
        public string apiBaseUrl { get; set; }


        /// <summary>
        /// Api Key from Expressly portal
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "apiKey")]
        public string apiKey { get; set; }


        /// <summary>
        /// Plugin Version
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pluginVersion")]
        public string pluginVersion { get; set; }
    }
}
