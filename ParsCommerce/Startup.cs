using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ParsCommerce.Startup))]
namespace ParsCommerce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
