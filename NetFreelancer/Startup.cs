using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NetFreelancer.Startup))]
namespace NetFreelancer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
