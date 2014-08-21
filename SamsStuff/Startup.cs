using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SamsStuff.Startup))]
namespace SamsStuff
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
