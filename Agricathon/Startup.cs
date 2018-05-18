using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Agricathon.Startup))]
namespace Agricathon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
