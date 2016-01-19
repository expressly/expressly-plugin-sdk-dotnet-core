using Newtonsoft.Json;

namespace Expressly.Api
{
    public class Address : ExpresslySerializableObject
    {
        /// <summary>
        /// First Name
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "firstName")]
        public string firstName { get; set; }

        /// <summary>
        /// Last Name
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastName")]
        public string lastName { get; set; }


        /// <summary>
        /// Main address
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "address1")]
        public string address1 { get; set; }


        /// <summary>
        /// Additional address
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "address2")]
        public string address2 { get; set; }


        /// <summary>
        /// City
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "city")]
        public string city { get; set; }


        /// <summary>
        /// Company Name
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "companyName")]
        public string companyName { get; set; }


        /// <summary>
        /// ZIP code
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "zip")]
        public string zip { get; set; }


        /// <summary>
        /// Phone
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "phone")]
        public int phone { get; set; }


        /// <summary>
        /// Address alias
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "addressAlias")]
        public string addressAlias { get; set; }


        /// <summary>
        /// State or province
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "stateProvince")]
        public string stateProvince { get; set; }


        /// <summary>
        /// Country
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "country")]
        public string country { get; set; }
    }
}
