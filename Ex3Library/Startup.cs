using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ex3Library.Startup))]
namespace Ex3Library
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
