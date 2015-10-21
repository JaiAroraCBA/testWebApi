using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testWebApi.Startup))]
namespace testWebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
