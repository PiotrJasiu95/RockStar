using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RockStar.Startup))]
namespace RockStar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
