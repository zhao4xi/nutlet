using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nutlet.MvcUI.Startup))]
namespace Nutlet.MvcUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
