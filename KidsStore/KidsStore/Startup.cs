using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KidsStore.Startup))]
namespace KidsStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
