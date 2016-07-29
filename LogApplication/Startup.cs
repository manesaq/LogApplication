using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LogApplication.Startup))]
namespace LogApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
