using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthAndRedirect.Startup))]
namespace AuthAndRedirect
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
