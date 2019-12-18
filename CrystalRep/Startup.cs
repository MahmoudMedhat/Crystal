using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrystalRep.Startup))]
namespace CrystalRep
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
