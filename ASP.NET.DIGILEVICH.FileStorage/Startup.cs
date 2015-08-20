using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP.NET.DIGILEVICH.FileStorage.Startup))]
namespace ASP.NET.DIGILEVICH.FileStorage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
