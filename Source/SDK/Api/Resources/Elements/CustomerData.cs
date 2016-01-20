using System.Collections.Generic;
using Newtonsoft.Json;

namespace Expressly.Api
{
    public class CustomerData : ExpresslySerializableObject
    {
        /// <summary>
        /// Customer First Name
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "firstName")]
        public string firstName { get; set; }


        /// <summary>
        /// Customer Last Name
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastName")]
        public string lastName { get; set; }


        /// <summary>
        /// Customer gender
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gender")]
        public string gender { get; set; }


        /// <summary>
        /// Customer billing address
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "billingAddress")]
        public int billingAddress { get; set; }


        /// <summary>
        /// Customer shipping address
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "shippingAddress")]
        public int shippingAddress { get; set; }


        /// <summary>
        /// Last updated date in UTC ISO8601 format.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dateUpdated")]
        public string dateUpdated { get; set; }


        /// <summary>
        /// Number of Customer Orders
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "numberOrdered")]
        public int numberOrdered { get; set; }


        /// <summary>
        /// Customer emails
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "emails")]
        public List<Email> emails { get; set; }


        /// <summary>
        /// Customer phones
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "phones")]
        public List<Phone> phones { get; set; }


        /// <summary>
        /// Customer addresses
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "addresses")]
        public List<Address> addresses { get; set; }
    }
}
