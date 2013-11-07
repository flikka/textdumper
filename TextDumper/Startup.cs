using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TextDumper.Startup))]
namespace TextDumper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
