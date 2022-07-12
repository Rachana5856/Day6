using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EFrame.Startup))]
namespace EFrame
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
