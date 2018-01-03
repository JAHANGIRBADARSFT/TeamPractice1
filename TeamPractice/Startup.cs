using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamPractice.Startup))]
namespace TeamPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
