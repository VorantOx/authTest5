using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(authTest5.Startup))]
namespace authTest5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
