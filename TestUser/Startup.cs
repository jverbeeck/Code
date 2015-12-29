using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestUser.Startup))]
namespace TestUser
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
