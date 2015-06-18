using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FluentValidationMVCSample.Startup))]
namespace FluentValidationMVCSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
