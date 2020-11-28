using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CITSMVC.Startup))]
namespace CITSMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
