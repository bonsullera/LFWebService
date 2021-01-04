using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LFWebService.Startup))]
namespace LFWebService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
