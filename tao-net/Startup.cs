using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tao_net.Startup))]
namespace tao_net
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
