using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Approach1.FrontEnd.Startup))]
namespace Approach1.FrontEnd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
