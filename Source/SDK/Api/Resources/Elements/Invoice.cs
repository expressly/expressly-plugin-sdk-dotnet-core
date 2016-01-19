using System.Collections.Generic;
using Newtonsoft.Json;

namespace Expressly.Api
{
    public class Invoice : ExpresslySerializableObject
    {
        /// <summary>
        /// Email
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "email")]
        public string email { get; set; }


        /// <summary>
        /// Order count
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "orderCount")]
        public int orderCount { get; set; }


        /// <summary>
        /// Pre tax total
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "preTaxTotal")]
        public double preTaxTotal { get; set; }


        /// <summary>
        /// Post tax total
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "postTaxTotal")]
        public double postTaxTotal { get; set; }


        /// <summary>
        /// Tax
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tax")]
        public double tax { get; set; }


        /// <summary>
        /// Orders list
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "orders")]
        public List<Order> orders { get; set; }
    }
}
