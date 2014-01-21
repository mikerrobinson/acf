using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ACF.Web.Startup))]
namespace ACF.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
