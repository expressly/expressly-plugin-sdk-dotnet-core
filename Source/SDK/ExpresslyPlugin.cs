using System;
using System.Collections.Generic;
using System.Web;
using Expressly.Log;
using Expressly.Util;

namespace Expressly.Api
{
    public static class ExpresslyPlugin
    {
        public readonly static string ApiKey;

        public readonly static string ApiBaseUrl;

        public readonly static APIContext APIContext;

        private static bool installed = false;

        private static IMerchantProvider merchantProvider;
        
        private static Logger logger = Logger.GetLogger(typeof(ExpresslyPlugin));

        static ExpresslyPlugin()
        {
            var config = GetConfig();
            ApiKey = config["apiKey"];
            ApiBaseUrl = config["apiBaseUrl"];
            APIContext = new APIContext { Config = config };
        }


        // getting properties from the config file
        private static Dictionary<string, string> GetConfig()
        {
            return Expressly.Api.ConfigManager.Instance.GetProperties();
        }


        /// <summary>
        /// Set Storage for Expressly Plugin Storage
        /// </summary>
        /// <returns>boolean status</returns>
        public static void SetMerchantProvider<T>() where T : IMerchantProvider, new()
        {
            merchantProvider = new T();
        }


        /// <summary>
        /// Install plugin
        /// </summary>
        /// <returns>boolean status</returns>
        public static bool Install()
        {
            if (!installed)
            {
                bool isInstalled = ExpresslyProvider.build().Install(APIContext, ApiKey, ApiBaseUrl);
                installed = isInstalled;
                return installed;
            } else
            {
                return true;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// Expressly Plugin Methods
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static Migration getCustomerData(string email)
        {
            if (merchantProvider == null)
            {
                throw new NotImplementedException("Couldn't find a valid IMerchantProvider implementation");
            }

            logger.Debug("Expressly plugin endpoint 'getCustomerData' is called. Params - email: " + email);

            return merchantProvider.getCustomerData(email);
        }


        public static InvoiceList getInvoices(InvoiceListRequest request)
        {
            if (merchantProvider == null)
            {
                throw new NotImplementedException("Couldn't find a valid IMerchantProvider implementation");
            }

            logger.Debug("Expressly plugin endpoint 'getInvoices' is called. Params - InvoiceListRequest: " + request);

            return merchantProvider.getInvoices(request);
        }


        public static EmailStatusList checkEmails(EmailAddressRequest request)
        {
            if (merchantProvider == null)
            {
                throw new NotImplementedException("Couldn't find a valid IMerchantProvider implementation");
            }

            logger.Debug("Expressly plugin endpoint 'checkEmails' is called. Params - EmailAddressRequest: " + request);

            return merchantProvider.checkEmails(request);
        }

        public static void popupHandler(string campaignCustomerUuid, HttpResponse response)
        {
            if (merchantProvider == null)
            {
                throw new NotImplementedException("Couldn't find a valid IMerchantProvider implementation");
            }

            merchantProvider.popupHandler(campaignCustomerUuid, response);
        }

        public static void confirmMigration(string campaignCustomerUuid, HttpResponse response)
        {
            if (merchantProvider == null)
            {
                throw new NotImplementedException("Not able to find IMerchantProvider implementation");
            }

            try
            {
                var customerMigrationData = ExpresslyProvider.build().FetchCustomerData(APIContext, campaignCustomerUuid);

                if (customerMigrationData.migration != null)
                {
                    if (merchantProvider.checkCustomerAlreadyExists(customerMigrationData.migration.customer.email))
                    {
                        merchantProvider.handleCustomerAlreadyExists(customerMigrationData.migration.customer.email, response);
                    }
                    else
                    {
                        string customerUserReference = merchantProvider.registerCustomer(customerMigrationData.migration.customer);

                        if (customerUserReference != null)
                        {
                            merchantProvider.sendPasswordResetEmail(customerUserReference);

                            if (customerMigrationData.cart != null)
                            {
                                if (merchantProvider.createCustomerCart(customerUserReference, customerMigrationData.cart))
                                {
                                    if (ExpresslyProvider.build().ConfirmMigration(APIContext, campaignCustomerUuid))
                                    {
                                        merchantProvider.loginAndRedirectCustomer(customerUserReference, response);
                                    }
                                }
                            }
                        }

                    }
                }
            }
            catch
            {
                merchantProvider.handleCustomerAlreadyExists(null, response);
            }
        }

    }
}
