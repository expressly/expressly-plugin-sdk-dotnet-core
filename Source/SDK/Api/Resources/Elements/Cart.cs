using Newtonsoft.Json;

namespace Expressly.Api
{
    public class Cart : ExpresslySerializableObject
    {
        /// <summary>
        /// Coupon Code value
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "couponCode")]
        public string couponCode { get; set; }


        /// <summary>
        /// Product Id value
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "productId")]
        public string productId { get; set; }
    }
}
