using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(carbon_footprint_application.Startup))]
namespace carbon_footprint_application
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
