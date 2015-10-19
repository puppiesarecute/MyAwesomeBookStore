using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyAwesomeBookStore.Startup))]
namespace MyAwesomeBookStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
