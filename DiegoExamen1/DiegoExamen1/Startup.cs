using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DiegoExamen1.Startup))]
namespace DiegoExamen1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
