using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Car_Dealership_MVC.Startup))]
namespace Car_Dealership_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
