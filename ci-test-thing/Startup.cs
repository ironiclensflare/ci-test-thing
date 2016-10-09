using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ci_test_thing.Startup))]
namespace ci_test_thing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
