namespace Expressly.Api
{
    /// <summary>
    /// Defines an interface for a Expressly serializable responce.
    /// </summary>
    public interface IExpresslySerializableObject
    {
        /// <summary>
        /// Converts this object to a JSON string.
        /// </summary>
        /// <returns>A JSON-formatted string.</returns>
        string ConvertToJson();
    }
}
