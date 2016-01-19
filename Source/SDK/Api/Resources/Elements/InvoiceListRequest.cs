using System.Collections.Generic;
using Newtonsoft.Json;

namespace Expressly.Api
{
    public class InvoiceListRequest : ExpresslySerializableObject
    {
        /// <summary>
        /// Invoices
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customers")]
        public List<InvoiceCustomerFilter> customers { get; set; }
    }
}
