using System.Collections.Generic;
using Newtonsoft.Json;

namespace Expressly.Api
{
    public class InvoiceList : ExpresslySerializableObject
    {
        /// <summary>
        /// Invoices
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoices")]
        public List<Invoice> invoices { get; set; }
    }
}
