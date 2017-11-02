using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BarberShop.Startup))]
namespace BarberShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
