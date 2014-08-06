using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test.MongoDB.AspNet.Identity.Startup))]
namespace Test.MongoDB.AspNet.Identity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
