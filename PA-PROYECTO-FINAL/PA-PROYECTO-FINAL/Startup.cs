using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PA_PROYECTO_FINAL.Startup))]
namespace PA_PROYECTO_FINAL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
