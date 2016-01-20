using System;
using Expressly.Api;

namespace Expressly.Testing
{
    public class TestModels
    {
        public static Cart GetCart()
        {
            string CartJson =
            "{\"couponCode\":\"4er23\"," +
            "\"productId\":\"641356\"" + "}";

            return JsonFormatter.ConvertFromJson<Cart>(CartJson);
        }

        public static Banner GetBanner()
        {
            string BannerJson =
            "{\"bannerImageUrl\":\"https://i.ytimg.com/vi/yaqe1qesQ8c/maxresdefault.jpg\"," +
            "\"migrationLink\":\"http://test.shop.com/expressly/api/49cb75d5-b823-4f0e-bdac-c2fee4bad9b6\"" + "}";
            return JsonFormatter.ConvertFromJson<Banner>(BannerJson);
        }

        public static string GetPhoneJson ()
        {
            return "{\"type\":\"L\"," +
            "\"number\":\"02079460975\"," +
            "\"countryCode\":\"44\"" + "}";
        }

        public static Phone GetPhone()
        {
            return JsonFormatter.ConvertFromJson<Phone>(GetPhoneJson());
        }

        public static Address GetAddress()
        {
            return JsonFormatter.ConvertFromJson<Address>(GetAddressJson());
        }

        private static string GetAddressJson()
        {
            return "{\"firstName\":\"Test\"," +
                        "\"lastName\":\"Burberry\"," +
                        "\"address1\":\"Basement Flat\"," +
                        "\"address2\":\"61 Wellfield Road\"," +
                        "\"city\":\"Roath\"," +
                        "\"companyName\":\"company\"," +
                        "\"zip\":\"CF24 3DG\"," +
                        "\"phone\":0," +
                        "\"addressAlias\":\"home\"," +
                        "\"stateProvince\":\"Cardiff\"," +
                        "\"country\":\"GB\"" + "}";
        }

        public static CustomerData GetCustomerData()
        {
            string CustomerDataJson =
            "{\"firstName\":\"Test\"," +
            "\"lastName\":\"LastTest\"," +
            "\"gender\":\"M\"," +
            "\"billingAddress\":0," +
            "\"shippingAddress\":0," +
            "\"dateUpdated\":\"2015-12-10T18:24:42.000Z\"," +
            "\"numberOrdered\":0," +
            "\"emails\":[" + GetEmailJson() + "]," +
            "\"phones\":[" + GetPhoneJson() + "]," +
            "\"addresses\":[" + GetAddressJson() + "]}";

            return JsonFormatter.ConvertFromJson<CustomerData>(CustomerDataJson);
        }

        public static Customer GetCustomer()
        {
            var customer = new Customer
            {
                email = TestingUtil.GetRandomString() + "@gmail.com",
                customerData = GetCustomerData(),
                userReference = 0
            };

            return customer;
        }

        public static Migration GetMigration()
        {
            string MigrationJson =
                "{\"meta\":" + MetadataTest.MetadataJson + "," +
                "\"data\":" + TestModels.GetCustomer().ConvertToJson() + "}";
            return JsonFormatter.ConvertFromJson<Migration>(MigrationJson);
        }

        public static String GetOrderJson()
        {
            return "{\"id\":\"ORDER-5321311\"," +
             "\"date\":\"2015-07-10\"," +
            "\"itemCount\":2," +
            "\"coupon\":\"COUPON\"," +
            "\"currency\":\"GBP\"," +
            "\"preTaxTotal\":100.00," +
            "\"postTaxTotal\":110.00," +
            "\"tax\":10.00" + "}";

        }

        public static Order GetOrder()
        {
            return JsonFormatter.ConvertFromJson<Order>(GetOrderJson());
        }

        public static Invoice GetInvoice()
        {
            string InvoiceJson =
            "{\"email\":\"testa@test.com\"," +
            "\"orderCount\":1," +
            "\"preTaxTotal\":100.00," +
            "\"postTaxTotal\":110.00," +
            "\"tax\":10.00," +
            "\"orders\":[" + GetOrderJson() + "]}";
            return JsonFormatter.ConvertFromJson<Invoice>(InvoiceJson);
        }

        public static Email GetEmail()
        {
            return JsonFormatter.ConvertFromJson<Email>(GetEmailJson());
        }

        public static String GetEmailJson()
        {
            return "{\"email\":\"test@gmail.com\"," +
                "\"alias\":\"personal\"" + "}";
        }
    }
}
