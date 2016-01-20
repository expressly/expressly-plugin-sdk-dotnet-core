using Newtonsoft.Json;

namespace Expressly.Api
{
    public class SuccessMessageResponse : ExpresslySerializableObject
    {
        /// <summary>
        /// Is success
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "success")]
        public bool success { get; set; }


        /// <summary>
        /// Message
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "msg")]
        public string msg { get; set; }
    }
}
