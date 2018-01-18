using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tikanpoika.Startup))]
namespace Tikanpoika
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
