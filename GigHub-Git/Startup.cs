using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GigHub_Git.Startup))]
namespace GigHub_Git
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
