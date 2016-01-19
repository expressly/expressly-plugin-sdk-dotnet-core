using Newtonsoft.Json;

namespace Expressly.Api
{
    public class Order : ExpresslySerializableObject
    {
        /// <summary>
        /// Order id
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public string id { get; set; }


        /// <summary>
        /// Order date
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "date")]
        public string date { get; set; }


        /// <summary>
        /// Order item count
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "itemCount")]
        public int itemCount { get; set; }


        /// <summary>
        /// Coupon
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "coupon")]
        public string coupon { get; set; }


        /// <summary>
        /// Currency
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "currency")]
        public string currency { get; set; }


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
    }
}
