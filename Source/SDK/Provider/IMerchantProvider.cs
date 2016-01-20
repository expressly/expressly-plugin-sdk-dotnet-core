using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Expressly.Api
{
    public interface IMerchantProvider
    {
        /// <summary>
        /// Gets migration customer data.
        /// </summary>
        /// <param name="email">Customer email</param>
        /// <returns>Correctly formatted and validated customer data object.</returns>
        Migration getCustomerData(string email);


        /// <summary>
        /// Collates all orders made by each customer of a campaign during a specific period of time.
        /// </summary>
        /// <param name="request">Request list of campaign emails and time period</param>
        /// <returns>Collection of orders organised by customer within the specified time period, in the correct, validated format.</returns>
        InvoiceList getInvoices(InvoiceListRequest request);


        /// <summary>
        /// Checks for emails that are currently registered and live at the merchant.
        /// </summary>
        /// <param name="request">Request list of campaign emails and time period</param>
        /// <returns>Collection of orders organised by customer within the specified time period, in the correct, validated format.</returns>
        EmailStatusList checkEmails(EmailAddressRequest request);


        /// <summary>
        /// Popup show handler
        /// </summary>
        /// <param name="campaignCustomerUuid">Uuid of the customer to render popup of</param>
        /// <param name="response">Current HttpResponse</param>
        void popupHandler(string campaignCustomerUuid, HttpResponse response);


        /// <summary>
        ///Method called when the existence of the customer in the shop is verified before the migration is concluded.
        ///user experience should be handled smoothly
        ///for example by being redirected to the homepage(avoid a black screen)
        /// </summary>
        /// <param name="email">Email can be null</param>
        /// <param name="response">Current HttpResponse</param>
        void handleCustomerAlreadyExists(string email, HttpResponse response);


        /// <summary>
        /// Checks the database for whether the customer already exists
        /// </summary>
        /// <param name="email">Email of the customer to check</param>
        /// <returns>True if the customer already exists</returns>
        bool checkCustomerAlreadyExists(string email);


        /// <summary>
        /// Reset user password and send them an email
        /// </summary>
        /// <param name="customerReference">customerReference used to identify the customer</param>
        /// <returns>True if reset and email sending is successful</returns>
        bool sendPasswordResetEmail(string customerReference);


        /// <summary>
        /// Persists customer in the database
        /// </summary>
        /// <param name="customerData">Customer containing the information needed to store the customer</param>
        /// <returns>Customer reference by wich the customer is identified by throughout the flow</returns>
        string registerCustomer(Customer customerData);


        /// <summary>
        /// Login and redirect customer to start page
        /// </summary>
        /// <param name="customerUserReference">Customer User Reference</param>
        /// <param name="response">Current HttpResponse</param>
        void loginAndRedirectCustomer(string customerUserReference, HttpResponse response);


        /// <summary>
        /// Persists the cart information against the customer.
        /// </summary>
        /// <param name="customerReference">Identify of customer</param>
        /// <param name="cart">cartData object containing product id (optional) and coupon code</param>
        /// <returns>boolean status</returns>
        bool createCustomerCart(string customerReference, Cart cart);
    }
}
