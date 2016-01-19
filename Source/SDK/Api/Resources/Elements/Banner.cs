using Expressly.Util;
using Newtonsoft.Json;

namespace Expressly.Api
{
    public class Banner : ExpresslySerializableObject
    {
        /// <summary>
        /// Banner Image Url
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bannerImageUrl")]
        public string bannerImageUrl { get; set; }


        /// <summary>
        /// Migration Link
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "migrationLink")]
        public string migrationLink { get; set; }
    }
}