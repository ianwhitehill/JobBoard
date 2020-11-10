using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JobBoard.MVC.UI.Startup))]
namespace JobBoard.MVC.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
