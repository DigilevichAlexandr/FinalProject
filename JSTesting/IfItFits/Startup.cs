using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IfItFits.Startup))]
namespace IfItFits
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
