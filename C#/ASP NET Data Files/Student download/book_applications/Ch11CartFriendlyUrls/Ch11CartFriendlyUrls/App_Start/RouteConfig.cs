using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;
using Microsoft.AspNet.FriendlyUrls.Resolvers;

namespace Ch11CartFriendlyUrls
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Temporary;
            routes.EnableFriendlyUrls(settings, new MyUrlResolver());
        }
    }

    public class MyUrlResolver : WebFormsFriendlyUrlResolver
    {
        // override so that mobile master page isn't used
        protected override bool TrySetMobileMasterPage(HttpContextBase ctx,
        System.Web.UI.Page page, string mobileSuffix)
        {
            return false;
        }
    }

}
