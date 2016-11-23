using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC4.Startup))]
namespace MVC4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
