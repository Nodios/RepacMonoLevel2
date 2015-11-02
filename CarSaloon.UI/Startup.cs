using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarSaloon.UI.Startup))]
namespace CarSaloon.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
