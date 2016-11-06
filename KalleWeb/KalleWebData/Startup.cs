using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KalleWebData.Startup))]
namespace KalleWebData
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
