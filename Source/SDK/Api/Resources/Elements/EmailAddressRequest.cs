using System.Collections.Generic;
using Newtonsoft.Json;

namespace Expressly.Api
{
    public class EmailAddressRequest : ExpresslySerializableObject
    {
        /// <summary>
        /// Emails array
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "emails")]
        public List<string> emails { get; set; }
    }
}
