using System.Collections.Generic;

namespace Expressly.Api
{
    /// <summary>
    /// Represents a PayPal model object that can be serialized to and from a JSON string.
    /// </summary>
    public class ExpresslySerializableObject : IExpresslySerializableObject
    {
        /// <summary>
        /// Converts this object to a JSON string.
        /// </summary>
        /// <returns>A JSON-formatted string.</returns>
        public virtual string ConvertToJson()
        {
            return JsonFormatter.ConvertToJson(this);
        }
    }
}
