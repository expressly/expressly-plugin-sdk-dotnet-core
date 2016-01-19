namespace Expressly.Api
{
    /// <summary>
    /// Constants that are used by the Expressly SDK.
    /// </summary>
    public static class BaseConstants
    {
        /// <summary>
        /// Allowed application mode - live
        /// </summary>
        public const string LiveMode = "live";


        /// <summary>
        /// Allowed application mode - sandbox
        /// </summary>
        public const string SandboxMode = "sandbox";


        /// <summary>
        /// Sandbox REST API endpoint
        /// </summary>
        public const string RESTSandboxEndpoint = "http://dev.expresslyapp.com/api/";


        /// <summary>
        /// Live REST API endpoint
        /// </summary>
        public const string RESTLiveEndpoint = "https://prod.expresslyapp.com/api/";


        /// <summary>
        /// Configuration key for application mode
        /// </summary>
        public const string ApplicationModeConfig = "mode";


        /// <summary>
        /// Configuration key for End point
        /// </summary>
        public const string EndpointConfig = "endpoint";


        /// <summary>
        /// Configuration key for HTTP Connection Timeout
        /// </summary>
        public const string HttpConnectionTimeoutConfig = "connectionTimeout";


        /// <summary>
        /// Configuration key for HTTP Connection Retry
        /// </summary>
        public const string HttpConnectionRetryConfig = "requestRetries";


        /// <summary>
        /// Configuration key suffix for Api Base Url
        /// </summary>
        public const string ApiBaseUrl = "apiBaseUrl";


        /// <summary>
        /// Configuration key suffix for Api Key
        /// </summary>
        public const string ApiKey = "apiKey";


        /// <summary>
        /// User Agent HTTP Header
        /// </summary>
        public const string UserAgentHeader = "User-Agent";

        /// <summary>
        /// Content Type HTTP Header
        /// </summary>
        public const string ContentTypeHeader = "Content-Type";

        /// <summary>
        /// Application - Json Content Type
        /// </summary>
        public const string ContentTypeHeaderJson = "application/json";

        /// <summary>
        /// Application - Form URL Encoded Content Type
        /// </summary>
        public const string ContentTypeHeaderFormUrlEncoded = "application/x-www-form-urlencoded";

        /// <summary>
        /// Authorization HTTP Header
        /// </summary>
        public const string AuthorizationHeader = "Authorization";


        /// <summary>
        /// The name of this SDK.
        /// </summary>
        public const string SdkName = "Expressly-NET-SDK";

    }
}
