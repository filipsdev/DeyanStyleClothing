using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeyanStyleClothing.Startup))]
namespace DeyanStyleClothing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
