using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Plaboo.Startup))]
namespace Plaboo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
