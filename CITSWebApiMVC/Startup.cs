using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CITSWebApiMVC.Startup))]
namespace CITSWebApiMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
