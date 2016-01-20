using System;
using System.Linq;
using System.Web;
using Expressly.Api;
using Expressly.Util;

namespace Expressly
{
    internal class MerchantRouter : IHttpModule
    {
        private ExpresslyProvider expresslyProvider;

        void IHttpModule.Init(HttpApplication context)
        {
            context.BeginRequest += new EventHandler(this.Сontext_BeginRequest);
            expresslyProvider = ExpresslyProvider.build();
        }

        private void Сontext_BeginRequest(Object sender, EventArgs e)
        {
            HttpContext context = ((HttpApplication)sender).Context;

            if (context.Request.FilePath.Equals("/expressly/api/ping") && context.Request.HttpMethod == "GET")
            {
                var pingResponse = new PingPluginResponse { expressly = "Stuff is happening!" };

                context.Response.StatusCode = 200;
                context.Response.ContentType = BaseConstants.ContentTypeHeaderJson;
                context.Response.Write(JsonFormatter.ConvertToJson(pingResponse));
                context.Response.End();
            }

            if (context.Request.FilePath.Equals("/expressly/api/registered") && context.Request.HttpMethod == "GET")
            {
                if (isAuthenticated(context.Request))
                {
                    var registeredResponse = new RegisteredPluginResponse { registered = true };

                    context.Response.StatusCode = 200;
                    context.Response.ContentType = BaseConstants.ContentTypeHeaderJson;
                    context.Response.Write(JsonFormatter.ConvertToJson(registeredResponse));
                    context.Response.End();
                }
                else
                {
                    context.Response.StatusCode = 401;
                }

            }

            if (context.Request.FilePath.Contains("/expressly/api/user") && context.Request.HttpMethod == "GET" && SDKUtil.IsIncludeEmail(context.Request.FilePath))
            {
                if (isAuthenticated(context.Request))
                {
                    var customerData = ExpresslyPlugin.getCustomerData(context.Request.FilePath.Split('/').Last());

                    context.Response.StatusCode = 200;
                    context.Response.ContentType = BaseConstants.ContentTypeHeaderJson;
                    context.Response.Write(JsonFormatter.ConvertToJson(customerData));
                    context.Response.End();

                }
                else
                {
                    context.Response.StatusCode = 401;
                }

            }


            if (context.Request.FilePath.Contains("/expressly/api/batch/invoice") && context.Request.HttpMethod == "POST")
            {
                if (isAuthenticated(context.Request))
                {
                    var requestBody = context.Request.GetRequestBody();

                    var invoiceListRequest = JsonFormatter.ConvertFromJson<InvoiceListRequest>(requestBody);

                    if (invoiceListRequest.customers != null)
                    {
                        var invoices = ExpresslyPlugin.getInvoices(invoiceListRequest);

                        context.Response.StatusCode = 200;
                        context.Response.ContentType = BaseConstants.ContentTypeHeaderJson;
                        context.Response.Write(JsonFormatter.ConvertToJson(invoices));
                        context.Response.End();
                    }
                    else
                    {
                        context.Response.StatusCode = 404;
                    }
                }
                else
                {
                    context.Response.StatusCode = 401;
                }

            }

            if (context.Request.FilePath.Contains("/expressly/api/batch/customer") && context.Request.HttpMethod == "POST")
            {
                if (isAuthenticated(context.Request))
                {
                    var requestBody = context.Request.GetRequestBody();

                    var emailAddressRequest = JsonFormatter.ConvertFromJson<EmailAddressRequest>(requestBody);

                    if (emailAddressRequest.emails != null)
                    {
                        var emails = ExpresslyPlugin.checkEmails(emailAddressRequest);

                        context.Response.StatusCode = 200;
                        context.Response.ContentType = BaseConstants.ContentTypeHeaderJson;
                        context.Response.Write(JsonFormatter.ConvertToJson(emails));
                        context.Response.End();
                    }
                    else
                    {
                        context.Response.StatusCode = 404;
                    }
                }
                else
                {
                    context.Response.StatusCode = 401;
                }

            }

            if (context.Request.FilePath.Contains("/expressly/api") && context.Request.HttpMethod == "GET" && SDKUtil.IsIncludeCampaignCustomerUuid(context.Request.FilePath))
            {
                if (ExpresslyPlugin.Install())
                {
                    ExpresslyPlugin.popupHandler(context.Request.FilePath.Split('/').Last(), context.Response);
                }
            }


            if (context.Request.FilePath.Contains("/expressly/api") && context.Request.HttpMethod == "GET" && context.Request.FilePath.Split('/').Last() == "migrate")
            {
                var campaignCustomerUuid = context.Request.Url.Segments[context.Request.Url.Segments.Length - 2].Replace("/", "");

                if (campaignCustomerUuid.Length == 36)
                {
                    if (ExpresslyPlugin.Install())
                    {
                        ExpresslyPlugin.confirmMigration(campaignCustomerUuid, context.Response);
                    }
                }
            }

        }

        private bool isAuthenticated(HttpRequest request)
        {
            if (request.Headers.AllKeys.Contains("Authorization"))
            {
                ArgumentValidator.Validate(ExpresslyPlugin.APIContext.Config["apiKey"], "apiKey");

                var expectedAuthorizationHeader = "Basic " + ExpresslyPlugin.APIContext.Config["apiKey"];

                return expectedAuthorizationHeader.Equals(request.Headers.GetValues("Authorization").FirstOrDefault());
            }

            return false;
        }

        void IHttpModule.Dispose() { }

    }
}
