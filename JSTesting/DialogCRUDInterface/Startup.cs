using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DialogCRUDInterface.Startup))]
namespace DialogCRUDInterface
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
