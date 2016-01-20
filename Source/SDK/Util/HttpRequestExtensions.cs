using System.IO;
using System.Web;

namespace Expressly.Util
{
    /// <summary>
    /// Extension methods for HTTP Request.
    /// </summary>
    public static class HttpRequestExtensions
    {

        public static string GetRequestBody(this HttpRequest request)
        {
            StringWriter writer = new StringWriter();
            WriteBody(request, writer);

            return writer.ToString();
        }


        private static void WriteBody(HttpRequest request, StringWriter writer)
        {
            StreamReader reader = new StreamReader(request.InputStream);

            try
            {
                string body = reader.ReadToEnd();
                writer.WriteLine(body);
            }
            finally
            {
                reader.BaseStream.Position = 0;
            }
        }
    }
}
