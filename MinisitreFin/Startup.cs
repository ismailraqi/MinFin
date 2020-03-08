using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MinisitreFin.Startup))]
namespace MinisitreFin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
