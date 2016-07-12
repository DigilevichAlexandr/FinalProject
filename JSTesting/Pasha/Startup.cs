using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pasha.Startup))]
namespace Pasha
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
