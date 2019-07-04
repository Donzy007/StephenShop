using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShephenShop.WebUI.Startup))]
namespace ShephenShop.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
