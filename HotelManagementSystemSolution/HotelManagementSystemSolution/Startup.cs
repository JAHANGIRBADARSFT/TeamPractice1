using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HotelManagementSystemSolution.Startup))]
namespace HotelManagementSystemSolution
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
