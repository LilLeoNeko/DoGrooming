using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DoGrooming.Startup))]
namespace DoGrooming
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
