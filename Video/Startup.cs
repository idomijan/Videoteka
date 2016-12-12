using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Video.Startup))]
namespace Video
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
