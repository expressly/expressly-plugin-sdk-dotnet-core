using System;
using Expressly.Util;
using Newtonsoft.Json;

namespace Expressly.Api
{
    public class MigrationDataObject : ExpresslySerializableObject
    {
        /// <summary>
        /// Migration object
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "migration")]
        public Migration migration { get; set; }


        /// <summary>
        /// Cart object
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cart")]
        public Cart cart { get; set; }
    }

    public class Migration : ExpresslySerializableObject
    {
        /// <summary>
        /// Customer email
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "meta")]
        public Metadata metada { get; set; }


        /// <summary>
        /// Customer object
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "data")]
        public Customer customer { get; set; }

        ///----

        /// <summary>
        /// Confirm Migration
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <param name="campaignCustomerUuid">Customer uuid</param>
        /// <returns>Is success</returns>
        public static bool ConfirmMigration(APIContext apiContext, string campaignCustomerUuid)
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
