using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Entity_Capstone.Startup))]
namespace Entity_Capstone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
