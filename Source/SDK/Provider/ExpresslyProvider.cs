using Expressly.Util;
using System;
namespace Expressly.Api
{
    /// <summary>
    ///  All logic concerning requesting the expressly backend endpoints
    /// </summary>
    public class ExpresslyProvider
    {
        ///TODO: abstract this and add it to the builder: 
///        private ExpresslyClient client;

        private ExpresslyProvider()
        {
        }
        public static ExpresslyProvider build()
        {
            return new ExpresslyProvider();
        }

        /// <summary>
        /// Install plugin
        /// </summary>
        /// <returns>boolean status</returns>
        public bool Install(APIContext APIContext, String ApiKey, String ApiBaseUrl)
        {
            // Validate
            ArgumentValidator.ValidateAndSetupAPIContext(APIContext);
            ArgumentValidator.Validate(ApiKey, "apiKey");
            ArgumentValidator.Validate(ApiBaseUrl, "apiBaseUrl");

            // Configure and send the request
            var resourcePath = "v2/plugin/merchant";
            var model = new RegisterPluginRequest() { apiBaseUrl = ApiBaseUrl, apiKey = ApiKey, pluginVersion = "v2" };

            var responceCode = ExpresslyClient.ConfigureAndExecute(APIContext, ExpresslyClient.HttpMethod.POST, resourcePath, model.ConvertToJson());
            return responceCode != null && responceCode.ToString() == "204";
        }

        /// <summary>
        /// Get Banner
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <param name="merchantUuid">Email</param>
        /// <returns>Banner Object</returns>
        public Banner GetBanner(APIContext apiContext, string email, string merchantUuid = "")
        {
            // Set Up default value
            merchantUuid = merchantUuid.Length == 0 ? apiContext.GetMerchantUuid() : merchantUuid;

            // Validate
            ArgumentValidator.ValidateAndSetupAPIContext(apiContext);
            ArgumentValidator.Validate(email, "email");
            ArgumentValidator.Validate(merchantUuid, "merchantUuid");

            var queryParameters = new QueryParameters();
            queryParameters["email"] = email;

            // Configure and send the request
            var pattern = "v2/banner/{0}";
            var resourcePath = SDKUtil.FormatURIPath(pattern, new object[] { merchantUuid }) + queryParameters.ToUrlFormattedString();
            return ExpresslyClient.ConfigureAndExecute<Banner>(apiContext, ExpresslyClient.HttpMethod.GET, resourcePath);
        }

        /// <summary>
        /// Create Campaign
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <param name="campaignCustomerUuid">Customer uuid</param>
        /// <returns>HTML of the popup</returns>
        public String GetPopupHtml(APIContext apiContext, string campaignCustomerUuid)
        {
            // Validate
            ArgumentValidator.ValidateAndSetupAPIContext(apiContext);
            ArgumentValidator.Validate(campaignCustomerUuid, "uuid");

            // Configure and send the request
            var pattern = "v2/migration/{0}";
            var resourcePath = SDKUtil.FormatURIPath(pattern, new object[] { campaignCustomerUuid });

            return ExpresslyClient.ConfigureAndExecute<String>(apiContext, ExpresslyClient.HttpMethod.GET, resourcePath);
        }

        /// <summary>
        /// Fetch Customer Data 
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <param name="campaignCustomerUuid">Customer uuid</param>
        /// <returns>MigrationDataObject</returns>
        public MigrationDataObject FetchCustomerData(APIContext apiContext, string campaignCustomerUuid)
        {
            // Validate
            ArgumentValidator.ValidateAndSetupAPIContext(apiContext);
            ArgumentValidator.Validate(campaignCustomerUuid, "uuid");

            // Configure and send the request
            var pattern = "v2/migration/{0}/user";
            var resourcePath = SDKUtil.FormatURIPath(pattern, new object[] { campaignCustomerUuid });

            return ExpresslyClient.ConfigureAndExecute<MigrationDataObject>(apiContext, ExpresslyClient.HttpMethod.GET, resourcePath);
        }

        /// <summary>
        /// Confirm Migration
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <param name="campaignCustomerUuid">Customer uuid</param>
        /// <returns>Is success</returns>
        public bool ConfirmMigration(APIContext apiContext, string campaignCustomerUuid)
        {
            // Validate
            ArgumentValidator.ValidateAndSetupAPIContext(apiContext);
            ArgumentValidator.Validate(campaignCustomerUuid, "uuid");

            // Configure and send the request
            var pattern = "v2/migration/{0}/success";
            var resourcePath = SDKUtil.FormatURIPath(pattern, new object[] { campaignCustomerUuid });

            return ExpresslyClient.ConfigureAndExecute<SuccessMessageResponse>(apiContext, ExpresslyClient.HttpMethod.POST, resourcePath).success;
        }


    }
}