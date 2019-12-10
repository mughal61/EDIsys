using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EDIsystems.Startup))]
namespace EDIsystems
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
