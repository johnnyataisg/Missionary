using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Missionary.Startup))]
namespace Missionary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
