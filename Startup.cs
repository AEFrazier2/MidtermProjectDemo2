using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Midterm_Demo.Startup))]
namespace Midterm_Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
