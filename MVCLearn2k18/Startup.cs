using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCLearn2k18.Startup))]
namespace MVCLearn2k18
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
