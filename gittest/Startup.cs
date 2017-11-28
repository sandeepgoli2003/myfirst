using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gittest.Startup))]
namespace gittest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //start up
            // test moify
            //testing
            ConfigureAuth(app);
        }
    }
}
