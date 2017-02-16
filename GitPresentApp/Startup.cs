using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitPresentApp.Startup))]
namespace GitPresentApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
