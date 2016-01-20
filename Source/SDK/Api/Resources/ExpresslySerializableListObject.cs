using System.Collections.Generic;

namespace Expressly.Api
{
    /// <summary>
    /// Represents a Expressly model object that can be serialized to and from JSON as an array.
    /// </summary>
    public class ExpresslySerializableListObject<T> : List<T>, IExpresslySerializableObject
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
