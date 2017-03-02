using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Stor5Site.Startup))]
namespace Stor5Site
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
