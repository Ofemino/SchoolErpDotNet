using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WEBPRES.Startup))]
namespace WEBPRES
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
