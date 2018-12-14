using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ACMPanel.Startup))]
namespace ACMPanel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
