using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;

namespace Ch11CartASPNETRouting
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // ignore WebResource.axd file
            routes.Ignore("{resource}.axd/{*pathInfo}");

            // map static routes
            routes.MapPageRoute("Default", "Default", "~/Default.aspx");
            routes.MapPageRoute("ContactUs", "ContactUs", "~/ContactUs.aspx");
            routes.MapPageRoute("ShopCart", "Shop/Cart", "~/Cart.aspx");
            routes.MapPageRoute("ShopProducts", "Shop/Products", "~/Products.aspx");

            // map a dynamic route with a default value for the parameter
            routes.MapPageRoute("ShopOrder", "Shop/Order/{productID}",
                "~/Order.aspx", false,
                new RouteValueDictionary { { "productID", "" } });
        }
    }
}
