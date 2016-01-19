using System.Collections.Generic;
using Newtonsoft.Json;

namespace Expressly.Api
{
    public class EmailStatusList : ExpresslySerializableObject
    {
        /// <summary>
        /// Existing emails array
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "existing")]
        public List<string> existing { get; set; }


        /// <summary>
        /// Pending emails array
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pending")]
        public List<string> pending { get; set; }


        /// <summary>
        /// Deleted emails array
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deleted")]
        public List<string> deleted { get; set; }
    }
}
