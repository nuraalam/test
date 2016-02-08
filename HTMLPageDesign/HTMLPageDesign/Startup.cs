using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HTMLPageDesign.Startup))]
namespace HTMLPageDesign
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
