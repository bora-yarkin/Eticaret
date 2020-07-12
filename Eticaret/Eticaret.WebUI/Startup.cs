using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Eticaret.WebUI.Startup))]
namespace Eticaret.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
