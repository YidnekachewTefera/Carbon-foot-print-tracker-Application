using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(carbon_footprint_tracker.Startup))]
namespace carbon_footprint_tracker
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
