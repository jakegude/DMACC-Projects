using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ch25Cart.Startup))]
namespace Ch25Cart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
