using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevIO.AppMvc.Startup))]
namespace DevIO.AppMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
