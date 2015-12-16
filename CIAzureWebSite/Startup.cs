using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CIAzureWebSite.Startup))]
namespace CIAzureWebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
