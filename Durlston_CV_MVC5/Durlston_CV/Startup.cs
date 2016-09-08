using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Durlston_CV.Startup))]
namespace Durlston_CV
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
